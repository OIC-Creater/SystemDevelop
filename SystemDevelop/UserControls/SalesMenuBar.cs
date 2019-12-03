using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemDevelop.UserControls
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
