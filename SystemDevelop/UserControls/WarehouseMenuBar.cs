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
            reciveListButton.BackColor = Color.LightBlue;
            orderListButton.BackColor = SystemColors.Control;           
            stockListButton.BackColor = SystemColors.Control;

        }

        private void orderDetail_Click(object sender, EventArgs e)
        {
            orderListButton.BackColor = Color.LightBlue;
            stockListButton.BackColor = SystemColors.Control;
            reciveListButton.BackColor = SystemColors.Control;
        }

        private void order_Click(object sender, EventArgs e)
        {
            orderListButton.BackColor = SystemColors.Control;
            stockListButton.BackColor = SystemColors.Control;
            reciveListButton.BackColor = SystemColors.Control;
        }

        private void stock_Click(object sender, EventArgs e)
        {
            stockListButton.BackColor = Color.LightBlue;
            orderListButton.BackColor = SystemColors.Control;
            reciveListButton.BackColor = SystemColors.Control;
        }

        private void WarehouseMenuBar_Load(object sender, EventArgs e)
        {
            reciveListButton.BackColor = Color.LightBlue;
            orderListButton.BackColor = SystemColors.Control;
            stockListButton.BackColor = SystemColors.Control;
        }

        private void notIssued_Click(object sender, EventArgs e)
        {
            reciveListButton.BackColor = SystemColors.Control;
            orderListButton.BackColor = SystemColors.Control;
            stockListButton.BackColor = SystemColors.Control;
        }

        private void notIssue_Click(object sender, EventArgs e)
        {
            reciveListButton.BackColor = SystemColors.Control;
            orderListButton.BackColor = SystemColors.Control;
            stockListButton.BackColor = SystemColors.Control;
        }
    }
}
