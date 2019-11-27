using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelop.UserControll
{
    public partial class SalesMenuBar : UserControl
    {
        public SalesMenuBar()
        {
            InitializeComponent();
        }

        private void reciveDetail_Click(object sender, EventArgs e)
        {
            reciveDetail.BackColor = Color.LightBlue;
            recive.BackColor = SystemColors.Control;
            pigeon.BackColor = SystemColors.Control;
        }

        private void recive_Click(object sender, EventArgs e)
        {
            reciveDetail.BackColor = SystemColors.Control;
            recive.BackColor = Color.LightBlue;
            pigeon.BackColor = SystemColors.Control;
        }

        private void pigeon_Click(object sender, EventArgs e)
        {
            reciveDetail.BackColor = SystemColors.Control;
            recive.BackColor = SystemColors.Control;
            pigeon.BackColor = Color.LightBlue;
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {
            reciveDetail.BackColor = Color.LightBlue;
            recive.BackColor = SystemColors.Control;
            pigeon.BackColor = SystemColors.Control;
        }
    }
}
