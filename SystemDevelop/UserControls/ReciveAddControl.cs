using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using SystemDevelop.DataModels;

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
                    Date = datatime.ToString(),
                    ReceiptCheck = false
                };
                DatabaseInstance.ReciveOrderTable.Insert(reciveOrder);
                DatabaseInstance.ReciveOrderTable.Sync();

                try
                {
                    reciveOrderDetail = new ReciveOrderDetail
                    {
                        ReciveOrderDetailId = $"GD{(DatabaseInstance.ReciveOrderDetailTable.Count + 1).ToString("00000")}",
                        ReciveOrderId = reciveOrderId,
                        ProductId = "PD00001",
                        Quantity = int.Parse(amountTextBox.Text)

                    };
                    DatabaseInstance.ReciveOrderDetailTable.Insert(reciveOrderDetail);
                    DatabaseInstance.ReciveOrderDetailTable.Sync();
                }
                catch
                {
                }
            }
            catch
            {
                MessageBox.Show("受注の登録に失敗しました");
            }


            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
            }

            StreamWriter sw = File.CreateText("受注.txt");
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
            File.AppendAllText("test.txt", "a");

        }
    }
}
