
using SystemDevelop.Model.DB;
using System.Data.OleDb;

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
        public (bool result,int syozoku) AuthUser(string user, string pass)
        {
            /*PasswordHash ph = new PasswordHash();
            string hashedPass = ph.Hash(pass);
            
            string sql = $"SELECT * FROM ログイン認証 WHERE pass = '{hashedPass}' AND id = '{user}'";

            OleDbCommand cmd = new OleDbCommand(sql,oleDb);
            OleDbDataReader oledr = null;
            try
            {
                oledr = cmd.ExecuteReader();
                if (oledr.HasRows)
                {
                    homeScreen.Show();
                    loginScreen.Hide();
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
            return (true,2);
        }
    }
}
