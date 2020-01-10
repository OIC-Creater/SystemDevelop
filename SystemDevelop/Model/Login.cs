using System.Windows.Forms;
using SystemDevelop.DataModels;
using System.Linq;
using System;

namespace SystemDevelop.Model
{
    public class Login
    {
        public bool AuthUser(string user, string pass, out Employee employee)
        {
            PasswordHash ph = new PasswordHash();
            string hashedPass = ph.Hash(pass);

            var emp = DatabaseInstance.EmployeeTable.Where(e => e.Password == pass && e.EmployeeId == user).FirstOrDefault();
            try
            {
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
            catch(Exception e)
            {
                MessageBox.Show("IDまたはパスワードが間違っています");
                employee = null;
                return false;
            }
            
        }
    }
}
