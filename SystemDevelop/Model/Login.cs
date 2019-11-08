
using SystemDevelop.Model.DB;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System;

namespace SystemDevelop.Model
{
    public class Login
    {
        private DbCreate dbCreate = new DbCreate();
        private OleDbConnection oleDb;
        public Login()
        {
            if (dbCreate.ConnectDb(out OleDbConnection oleDb))
            {
                this.oleDb = oleDb;
            }
        }
        public void AuthUser(string user, string pass)
        {
            PasswordHash ph = new PasswordHash();
            string hashedPass = ph.Hash(pass);

            string sql = $"SELECT * FROM ログイン認証 WHERE pass = '{hashedPass}'";

            OleDbCommand cmd = new OleDbCommand(sql,oleDb);
            OleDbDataReader oledr = null;
            try
            {
                oledr = cmd.ExecuteReader();
                if (oledr.HasRows)
                {
                    MessageBox.Show("hoge");
                }
                else
                {
                    MessageBox.Show("huga");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
