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
    public partial class SalesMenuBar : UserControl
    {
        public SalesMenuBar()
        {
            InitializeComponent();
        }

        private void reciveDetail_Click(object sender, EventArgs e)
        {
            reciveListButton.BackColor = Color.LightBlue;
            reciveAddButton.BackColor = SystemColors.Control;
            pigeonButton.BackColor = SystemColors.Control;
        }

        private void recive_Click(object sender, EventArgs e)
        {
            reciveListButton.BackColor = SystemColors.Control;
            reciveAddButton.BackColor = Color.LightBlue;
            pigeonButton.BackColor = SystemColors.Control;
        }

        private void pigeon_Click(object sender, EventArgs e)
        {
            reciveListButton.BackColor = SystemColors.Control;
            reciveAddButton.BackColor = SystemColors.Control;
            pigeonButton.BackColor = Color.LightBlue;
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {
            reciveListButton.BackColor = Color.LightBlue;
            reciveAddButton.BackColor = SystemColors.Control;
            pigeonButton.BackColor = SystemColors.Control;
        }
    }
}
