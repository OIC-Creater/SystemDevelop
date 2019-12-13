
using SystemDevelop.Model.DB;
using System.Data.OleDb;
using System;
using System.Windows.Forms;
using SystemDevelop.DataModels;

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
            employee = new Employee();
            string sql = $"SELECT * FROM 社員 WHERE パスワード = '{pass}' AND 社員ID = '{user}'";

            OleDbCommand cmd = new OleDbCommand(sql,oleDb);
            OleDbDataReader oledr = null;
            try
            {
                oledr = cmd.ExecuteReader();
                if (oledr.HasRows)
                {
                    oledr.Read();
                    if (Convert.ToBoolean(oledr["雇用中"].ToString()))
                    {
                        employee.EmployeeId = oledr["社員ID"].ToString();
                        employee.EmployeeName = oledr["社員名"].ToString();
                        employee.Password = oledr["パスワード"].ToString();
                        employee.AffiliationId = oledr["所属ID"].ToString();
                        employee.PhoneNumber = oledr["電話番号"].ToString();
                        employee.WorkingFlag = Convert.ToBoolean(oledr["雇用中"].ToString());
                        employee.PigeonId = oledr["ハトID"].ToString();
                        return true;
                    }

                    MessageBox.Show("IDまたはパスワードが間違っています");
                    return false;
                }
                else
                {
                    MessageBox.Show("IDまたはパスワードが間違っています");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
