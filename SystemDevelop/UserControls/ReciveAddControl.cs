using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using SystemDevelop.DataModels;
using System.Linq;

namespace SystemDevelop.UserControls
{
    public partial class ReciveAddControl : UserControl
    {
        private ReciveOrder reciveOrder;
        private ReciveOrderDetail reciveOrderDetail;
        public ReciveAddControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime datatime = DateTime.Now;
            String reciveOrderId = $"G{(DatabaseInstance.ReciveOrderTable.Count + 1).ToString("00000")}";
            try
            {
                reciveOrder = new ReciveOrder
                {
                    ReciveOrderId = reciveOrderId,
                    ShopId = shopComboBox.Text,
                    PigeonId = pigeonComboBox.Text,
                    SalesOfficeId = "B001",
                    EmployeeId = "E00001",
                    Date = datatime,
                    ReceiptCheck = false
                };
                DatabaseInstance.ReciveOrderTable.Insert(reciveOrder);
                DatabaseInstance.ReciveOrderTable.Sync();
                
                reciveOrderDetail = new ReciveOrderDetail
                {
                    ReciveOrderDetailId = $"GD{(DatabaseInstance.ReciveOrderDetailTable.Count + 1).ToString("00000")}",
                    ReciveOrderId = reciveOrderId,
                    ProductId = "PD00001",
                    Quantity = int.Parse(amountTextBox.Text)

                };
                DatabaseInstance.ReciveOrderDetailTable.Insert(reciveOrderDetail);
                DatabaseInstance.ReciveOrderDetailTable.Sync();


                var stockId = DatabaseInstance.ProductTable.Where(p => p.ProductId == "PD00001").First().StockId;
                DatabaseInstance.StockTable.Where(s => s.StockId == stockId).FirstOrDefault().StockAmount = 
                    DatabaseInstance.StockTable.Where(s => s.StockId == stockId).FirstOrDefault().StockAmount - int.Parse(amountTextBox.Text);
                DatabaseInstance.StockTable.Sync();
                DatabaseInstance.UpdateUnion();
            }
            catch
            {
                MessageBox.Show("受注の登録に失敗しました");
            }


            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
            }

            StreamWriter sw = File.CreateText("受注.json");
            string json = @"{""ReciveOrder"":";

            using (var stream = new MemoryStream())
            using (var sr = new StreamReader(stream))
            {
                var serializer = new DataContractJsonSerializer(typeof(ReciveOrder));
                serializer.WriteObject(stream, reciveOrder);
                stream.Position = 0;
                json += sr.ReadToEnd();
            }
            using (var stream = new MemoryStream())
            using (var sr = new StreamReader(stream))
            {
                json += @",""ReciveOrderDetail"":";
                var serializer = new DataContractJsonSerializer(typeof(ReciveOrderDetail));
                serializer.WriteObject(stream, reciveOrderDetail);
                stream.Position = 0;
                json += sr.ReadToEnd();
            }
            json += "}";
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            sw.Write(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));
            sw.Close();
            File.AppendAllText("受注.json", "a");

        }
    }
}
