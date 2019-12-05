using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelop.UserControls
{
    public partial class WarehouseMenuBar : UserControl
    {
        public WarehouseMenuBar()
        {
            InitializeComponent();
        }
        
        private void reciveDetail_Click(object sender, EventArgs e)
        {
            reciveDetail.BackColor = Color.LightBlue;
            orderDetail.BackColor = SystemColors.Control;           
            stock.BackColor = SystemColors.Control;
        }

        private void orderDetail_Click(object sender, EventArgs e)
        {
            orderDetail.BackColor = Color.LightBlue;
            stock.BackColor = SystemColors.Control;
            reciveDetail.BackColor = SystemColors.Control;
        }

        private void order_Click(object sender, EventArgs e)
        {
            orderDetail.BackColor = SystemColors.Control;
            stock.BackColor = SystemColors.Control;
            reciveDetail.BackColor = SystemColors.Control;
        }

        private void stock_Click(object sender, EventArgs e)
        {
            stock.BackColor = Color.LightBlue;
            orderDetail.BackColor = SystemColors.Control;
            reciveDetail.BackColor = SystemColors.Control;
        }

        private void WarehouseMenuBar_Load(object sender, EventArgs e)
        {
            reciveDetail.BackColor = Color.LightBlue;
            orderDetail.BackColor = SystemColors.Control;
            stock.BackColor = SystemColors.Control;
        }
    }
}
