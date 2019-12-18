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
    public partial class MainOfficeManuBar : UserControl
    {
        public MainOfficeManuBar()
        {
            InitializeComponent();
        }

        

        private void employeeList_Click(object sender, EventArgs e)
        {
            employeeListButton.BackColor = Color.LightBlue;
            manufacturerListButton.BackColor = SystemColors.Control;
            shopListButton.BackColor = SystemColors.Control;
            businessOfficeListButton.BackColor = SystemColors.Control;
            newProductButton.BackColor = SystemColors.Control;
        }

        private void manufacturerList_Click(object sender, EventArgs e)
        {
            employeeListButton.BackColor = SystemColors.Control;
            manufacturerListButton.BackColor = Color.LightBlue;
            shopListButton.BackColor = SystemColors.Control;
            businessOfficeListButton.BackColor = SystemColors.Control;
            newProductButton.BackColor = SystemColors.Control;
        }

        private void shopList_Click(object sender, EventArgs e)
        {
            employeeListButton.BackColor = SystemColors.Control;
            manufacturerListButton.BackColor = SystemColors.Control;
            shopListButton.BackColor = Color.LightBlue;
            businessOfficeListButton.BackColor = SystemColors.Control;
            newProductButton.BackColor = SystemColors.Control;
        }
        private void businessOfficeList_Click(object sender, EventArgs e)
        {
            employeeListButton.BackColor = SystemColors.Control;
            manufacturerListButton.BackColor = SystemColors.Control;
            shopListButton.BackColor = SystemColors.Control;
            businessOfficeListButton.BackColor = Color.LightBlue;
            newProductButton.BackColor = SystemColors.Control;
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            employeeListButton.BackColor = SystemColors.Control;
            manufacturerListButton.BackColor = SystemColors.Control;
            shopListButton.BackColor = SystemColors.Control;
            businessOfficeListButton.BackColor = SystemColors.Control;
            newProductButton.BackColor = Color.LightBlue;
        }
    }
}
