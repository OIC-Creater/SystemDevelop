using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace SystemDevelop.Model.DB
{
    /// <summary>
    /// DBへの操作のAPI
    /// </summary>
    class DbClient
    {

        //private 
        /// <summary>
        /// Adapterの作成
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="table"></param>
        public void CreateAdapter(OleDbConnection connection, string table)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM t_{table}", connection);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            
            /*adapter.InsertCommand = new OleDbCommand(
                $"INSERT INTO {} (CustomerID, CompanyName) " +
                "VALUES (?, ?)");

            adapter.UpdateCommand = new OleDbCommand(
                $"UPDATE Customers SET CustomerID = ?, CompanyName = ? " +
                $"WHERE CustomerID = ?");

            adapter.DeleteCommand = new OleDbCommand(
                $"DELETE FROM Customers WHERE CustomerID = ?");
                */
        }
    }
}
