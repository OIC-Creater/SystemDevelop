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
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=./test.accdb";


        public void ConnectDb()
        {
            try
            {
                OleDbConnection oleDb = CreateDb();

                oleDb.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private OleDbConnection CreateDb()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
