using System;
using System.Drawing;
using System.Windows.Forms;
using SystemDevelop.Model;


namespace SystemDevelop
{
    public partial class MainForm : Form
    {
        private Login login;
        private bool logined = false;

        public MainForm()
        {
            InitializeComponent();
            login = new Login(this);
            this.WindowState = FormWindowState.Maximized;
            loginControl.loginButton.Click += LoginButtonClick;
            headerControl.logoutButton.Click += LogoutButtonClick;
            warehouseMenuBar.Visible = false;
            salesMenuBar.Visible = false;
            headerControl.Visible = false;
            loginControl.Visible = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text);
            }
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text);
            }
        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text);
            }
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            var result = login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text);
            if (result.result)
            {
                logined = true;
                headerControl.Visible = true;
                switch (result.syozoku)
                {
                    case 1:
                        salesMenuBar.Visible = true;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = false;
                        break;
                    case 2:
                        salesMenuBar.Visible = false;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = true;
                        break;
                }
                
            }
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            /*logined = false;
            warehouseMenuBar.Visible = false;
            salesMenuBar.Visible = false;
            headerControl.Visible = false;
            loginControl.Visible = true;*/
            this.Close();
        }
    }
}
