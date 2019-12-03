
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
            //PasswordHash ph = new PasswordHash();
            //string hashedPass = ph.Hash(pass);
            employee = new Employee();
            /*string sql = $"SELECT * FROM 社員表 WHERE パスワード = '{pass}' AND 社員ID = '{user}'";

            OleDbCommand cmd = new OleDbCommand(sql,oleDb);
            OleDbDataReader oledr = null;
            try
            {
                oledr = cmd.ExecuteReader();
                if (oledr.HasRows)
                {
                    oledr.Read();
                    employee.ID = oledr[0].ToString();
                    employee.Name = oledr[1].ToString();
                    employee.Password = oledr[2].ToString();
                    employee.BelongsID = int.Parse(oledr[3].ToString());
                    employee.PhoneNumber = oledr[4].ToString();
                    employee.NowWork = oledr[5].ToString();
                    employee.PigeonID  = oledr[6].ToString();
                    return true;
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
            }*/

            employee.ID = "1";
            employee.Name = "1";
            employee.Password = "1";
            employee.BelongsID = int.Parse("2");
            employee.PhoneNumber = "1";
            employee.NowWork = "1";
            employee.PigeonID = "1";
            return true;
        }
    }
}
