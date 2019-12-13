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
            employeeList.BackColor = Color.LightBlue;
            manufacturerList.BackColor = SystemColors.Control;
            shopList.BackColor = SystemColors.Control;
            businessOfficeList.BackColor = SystemColors.Control;
            newProduct.BackColor = SystemColors.Control;
        }

        private void manufacturerList_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = SystemColors.Control;
            manufacturerList.BackColor = Color.LightBlue;
            shopList.BackColor = SystemColors.Control;
            businessOfficeList.BackColor = SystemColors.Control;
            newProduct.BackColor = SystemColors.Control;
        }

        private void shopList_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = SystemColors.Control;
            manufacturerList.BackColor = SystemColors.Control;
            shopList.BackColor = Color.LightBlue;
            businessOfficeList.BackColor = SystemColors.Control;
            newProduct.BackColor = SystemColors.Control;
        }
        private void businessOfficeList_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = SystemColors.Control;
            manufacturerList.BackColor = SystemColors.Control;
            shopList.BackColor = SystemColors.Control;
            businessOfficeList.BackColor = Color.LightBlue;
            newProduct.BackColor = SystemColors.Control;
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            employeeList.BackColor = SystemColors.Control;
            manufacturerList.BackColor = SystemColors.Control;
            shopList.BackColor = SystemColors.Control;
            businessOfficeList.BackColor = SystemColors.Control;
            newProduct.BackColor = Color.LightBlue;
        }
    }
}
