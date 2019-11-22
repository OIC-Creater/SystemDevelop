using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelop.Model.DB
{
    class DbCreate
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../DB/db.accdb";


        public bool ConnectDb(out OleDbConnection oleDbConnection)
        {
            try
            {
                OleDbConnection oleDb = CreateDb();

                oleDb.Open();

                oleDbConnection = oleDb;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                oleDbConnection = null;
                return false;
            }
            
        }

        private OleDbConnection CreateDb()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
