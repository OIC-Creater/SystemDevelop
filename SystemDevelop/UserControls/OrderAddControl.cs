using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemDevelop.DataModels;

namespace SystemDevelop.UserControls
{
    public partial class OrderAddControl : UserControl
    {
        public OrderAddControl()
        {
            InitializeComponent();
        }

        private void orderAddButton_Click(object sender, EventArgs e)
        {
            DateTime datatime = DateTime.Now;
            string productId = DatabaseInstance.ProductTable.Where(p => p.ProductName == productComboBox.Text).First().ProductId;
            string settingId = DatabaseInstance.ProductTable.Where(p => p.ProductId == productId).First().SettingId;
            try
            {
                Order order = new Order
                {
                    OrderId = orderId.Text,
                    EmployeeId = "E00001",
                    発注日 = datatime
                };
                DatabaseInstance.OrderTable.Insert(order);
                DatabaseInstance.OrderTable.Sync();

                var orderDetail = new OrderDetail
                {
                    OrderDetailId = $"POD{(DatabaseInstance.ReciveOrderDetailTable.Count + 1).ToString("00000")}",
                    OrderId = orderId.Text,
                    ProductId = productId,
                    Quantity = DatabaseInstance.SettingTable.Where(s => s.SettingId == settingId).First().OrderQuantity

                };
                DatabaseInstance.OrderDetailTable.Insert(orderDetail);
                DatabaseInstance.OrderDetailTable.Sync();


                var stockId = DatabaseInstance.ProductTable.Where(p => p.ProductId == productId).First().StockId;
                DatabaseInstance.StockTable.Where(s => s.StockId == stockId).FirstOrDefault().StockAmount =
                    DatabaseInstance.StockTable.Where(s => s.StockId == stockId).FirstOrDefault().StockAmount 
                    + DatabaseInstance.SettingTable.Where(s => s.SettingId == settingId).First().OrderQuantity;
                DatabaseInstance.StockTable.Sync();
                DatabaseInstance.UpdateUnion();
                MessageBox.Show("発注の登録に成功しました");
                orderId.Text = orderId.Text = $"PO{(DatabaseInstance.OrderTable.Count + 1).ToString("00000")}";
                productComboBox.Text = "";
            }
            catch
            {
                MessageBox.Show("発注の登録に失敗しました");
            }
        }

        private void OrderAddControl_Load(object sender, EventArgs e)
        {
            productComboBox.Items.AddRange(DatabaseInstance.ProductTable.ToArray().Select(el => el.ProductName).ToArray());
        }
    }
}
