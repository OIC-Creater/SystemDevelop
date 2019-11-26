using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelop
{
    public partial class Header : UserControl
    {

        private bool menuBar = true;

        public Header()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
           /* Button button = (Button)sender;
            main.menuControl.Visible = false;
            if (menuBar)
            {
                main.menuControl.ItemSize = new Size(0, 1);
                main.menuControl.SizeMode = TabSizeMode.Fixed;
                menuBar = false;
                button.Text = ">";
            }
            else
            {
                main.menuControl.ItemSize = new Size(350, 200);
                main.menuControl.SizeMode = TabSizeMode.Normal;
                menuBar = true;
                button.Text = "<";
            }
            main.menuControl.Visible = true;*/
        }
    }
}
