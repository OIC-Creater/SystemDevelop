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
            salesMenuBar.reciveDetail.Click += ReciveDetail_Click;
            salesMenuBar.pigeon.Click += Pigeon_Click;
            salesMenuBar.unDispatched.Click += UnDispatched_Click;
            warehouseMenuBar.reciveDetail.Click += OrderButtonClick;
            warehouseMenuBar.orderDetail.Click += OrderAnButtonClick;
            warehouseMenuBar.stock.Click += StockButtonClick;
            warehouseMenuBar.notIssued.Click += NotIssued_Click;
        }

        

        private void NotIssued_Click(object sender, EventArgs e)
        {
            notIssue.Visible = true;
            stockControl.Visible = false;
            placeControl.Visible = false;
            orderControl.Visible = false;
        }

        
        
        private void StockButtonClick(object sender, EventArgs e)
        {
            stockControl.Visible = true;
            pigeonList.Visible = false;
            notIssue.Visible = false;
            orderControl.Visible = false;
        }
        private void OrderButtonClick(object sender, EventArgs e)
        {
            orderControl.Visible = true;
            notIssue.Visible = false;
            stockControl.Visible = false;
            placeControl.Visible = false;
        }
        private void OrderAnButtonClick(object sender,EventArgs e)
        {
            placeControl.Visible = true;
            orderControl.Visible = false;
            notIssue.Visible = false;
            stockControl.Visible = false;
        }
        private void ReciveDetail_Click(object sender, EventArgs e)
        {
            orderControl.Visible = true;
            reciveControl.Visible = false;
            pigeonList.Visible = false;
            unDispatched.Visible = false;
        }
        private void ReciveButtonClick(object sender, EventArgs e)
        {
            reciveControl.Visible = true;
            orderControl.Visible = false;
            pigeonList.Visible = false;
            unDispatched.Visible = false;
        }
        private void Pigeon_Click(object sender, EventArgs e)
        {
            pigeonList.Visible = true;
            reciveControl.Visible = false;
            orderControl.Visible = false;
            unDispatched.Visible = false;
        }
        private void UnDispatched_Click(object sender, EventArgs e)
        {
            unDispatched.Visible = true;
            pigeonList.Visible = false;
            reciveControl.Visible = false;
            orderControl.Visible = false;
        }
        private void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
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
