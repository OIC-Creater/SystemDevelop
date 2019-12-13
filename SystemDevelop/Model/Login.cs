
using SystemDevelop.Model.DB;
using System.Data.OleDb;
using System;
using System.Windows.Forms;
using SystemDevelop.DataModels;
using System.Linq;

namespace SystemDevelop.Model
{
    public class Login
    {
        private DbCreate dbCreate = new DbCreate();
        private OleDbConnection oleDb;
        private MainForm loginScreen;
        public Login(MainForm loginScreen)
        {
            this.loginScreen = loginScreen;
            if (dbCreate.ConnectDb(out OleDbConnection oleDb))
            {
                this.oleDb = oleDb;
            }
        }

        public bool AuthUser(string user, string pass, out Employee employee)
        {
            PasswordHash ph = new PasswordHash();
            string hashedPass = ph.Hash(pass);

            var emp = DatabaseInstance.EmployeeTable.Where(e => e.Password == pass && e.EmployeeId == user).FirstOrDefault();
            if (emp.WorkingFlag)
            {
                employee = emp;
                return true;
            }
            else
            {
                MessageBox.Show("IDまたはパスワードが間違っています");
                employee = null;
                return false;
            }
        }
    }
}
