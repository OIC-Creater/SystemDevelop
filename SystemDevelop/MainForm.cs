using System;
using System.Collections;
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
            foreach (Control con in GetAllControls(this))
            {
                foreach (Control c in con.Controls)
                {
                    string typeName = c.GetType().ToString();
                    if (typeName.Contains("TextBox")||
                        typeName.Contains("ComboBox")) c.Text = "";
                }
                con.Visible = false;
            }
            loginControl.Visible = true;
            headerControl.userLabel.Text = $"ÉçÉOÉCÉìíÜÅF";
        }


        public Control[] GetAllControls(Control form)
        {
            ArrayList buf = new ArrayList();
            foreach (Control c in form.Controls)
            {
                if(c.GetType().ToString().Contains("UserControl")) buf.Add(c);
            }
            return (Control[])buf.ToArray(typeof(Control));
        }
    }
}
