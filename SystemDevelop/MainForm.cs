using System;
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
            loginControl.idTextBox.KeyDown += OnEnter;
            loginControl.passTextBox.KeyDown += OnEnter;
            headerControl.logoutButton.Click += LogoutButtonClick;
            salesMenuBar.recive.Click += ReciveButtonClick;
            salesMenuBar.recive.Click += ReciveButtonClick;
            warehouseMenuBar.orderDetail.Click += OrderButtonClick;
        }
        private void OrderButtonClick(object sender,EventArgs e)
        {
            orderControl.Visible = true;
        }
        private void OnEnter(object sender, KeyEventArgs e)
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

            Control[] all = Controller.GetAllControls(this);
            foreach (Control c in all)
            {
                foreach (Control con in c.Controls)
                {
                    if (con.GetType().ToString().Contains("TextBox") ||
                       con.GetType().ToString().Contains("ComboBox"))
                        con.Text = "";
                }
                c.Visible = false;
            }
            headerControl.userLabel.Text = "ログイン中：";
            loginControl.Visible = true;
        }
    }
}
