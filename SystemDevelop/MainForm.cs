using System;
using System.Drawing;
using System.Windows.Forms;
using SystemDevelop.DataModels;
using SystemDevelop.Model;


namespace SystemDevelop
{
    public partial class MainForm : Form
    {
        private Login login;
        private bool logined = false;
        private Employee employee;

        public MainForm()
        {
            InitializeComponent();
            login = new Login(this);
            loginControl.loginButton.Click += LoginButtonClick;
            headerControl.logoutButton.Click += LogoutButtonClick;
            salesMenuBar.recive.Click += ReciveButtonClick;

        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }


        private void ReciveButtonClick(object sender, EventArgs e)
        {
            reciveControl.Visible = true;
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            Login();
        }
        
        private void Login()
        {
            if (login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text, out employee))
            {
                headerControl.userLabel.Text += $" {employee.Name}";
                logined = true;
                headerControl.Visible = true;
                switch (employee.BelongsID)
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
            logined = false;
            warehouseMenuBar.Visible = false;
            salesMenuBar.Visible = false;
            headerControl.Visible = false;
            loginControl.Visible = true;
        }
    }
}
