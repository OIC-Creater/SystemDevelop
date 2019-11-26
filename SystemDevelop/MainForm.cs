using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemDevelop.Model;


namespace SystemDevelop
{
    public partial class MainForm : Form
    {
        private Login login;
        private bool menuBar = true;

        public MainForm()
        {
            InitializeComponent();
            login = new Login(this);
            this.WindowState = FormWindowState.Maximized;
            header.menuButton.Click += button_Click;
        }

        private void  button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            menuControl.Visible = false;
            if (menuBar)
            {
                menuControl.ItemSize = new Size(0, 1);
                menuControl.SizeMode = TabSizeMode.Fixed;
                menuBar = false;
                button.Text = ">";
            }
            else
            {
                menuControl.ItemSize = new Size(350, 200);
                menuControl.SizeMode = TabSizeMode.Normal;
                menuBar = true;
                button.Text = "<";
            }
            menuControl.Visible = true;
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            menuControl.Alignment = TabAlignment.Left;

            menuControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            menuControl.DrawItem += new DrawItemEventHandler(TabControl1_DrawItem);
            menuControl.TabPages.Remove(stockPage);
            menuControl.TabPages.Remove(orderPage);
            menuControl.TabPages.Remove(productPage);
            menuControl.TabPages.Remove(reciveOrderPage);

        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = (TabControl)sender;
            TabPage page = tab.TabPages[e.Index];
            string txt = page.Text;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            sf.FormatFlags |= StringFormatFlags.LineLimit;

            Brush foreBrush, backBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                foreBrush = Brushes.Black;
                backBrush = Brushes.LightBlue;
            }
            else
            {
                foreBrush = Brushes.Gray;
                backBrush = Brushes.White;
            }
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            e.Graphics.DrawString(txt, page.Font, foreBrush, e.Bounds, sf);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool logined = login.AuthUser(idTextBox.Text, passTextBox.Text);
            if (logined)
            {
                menuControl.TabPages.Insert(1,stockPage);
                menuControl.TabPages.Insert(2,orderPage);
                menuControl.TabPages.Insert(3,productPage);
                menuControl.TabPages.Insert(4,reciveOrderPage);
            }
        }

        private void MenuBarButton_Click(object sender, EventArgs e)
        {
            /*Button button = (Button)sender;
            menuControl.Visible = false;
            if (menuBar)
            {
                menuControl.ItemSize = new Size(0, 1);
                menuControl.SizeMode = TabSizeMode.Fixed;
                menuBar = false;
                button.Text = ">";
            }
            else
            {
                menuControl.ItemSize = new Size(350, 200);
                menuControl.SizeMode = TabSizeMode.Normal;
                menuBar = true;
                button.Text = "<";
            }
            menuControl.Visible = true;*/

        }
    }
}
