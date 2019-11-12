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
    public partial class LoginScreen : Form
    {

        private HomeScreen homeScreen;
        private Login login;
        public LoginScreen()
        {
            InitializeComponent();
            homeScreen = new HomeScreen(this);
            login = new Login(homeScreen,this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.AuthUser(idTextBox.Text, passWordTextBox.Text);
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passWordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passWordTextBox.Text);
            }
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passWordTextBox.Text);
            }
        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passWordTextBox.Text);
            }
        }
       
    }
}
