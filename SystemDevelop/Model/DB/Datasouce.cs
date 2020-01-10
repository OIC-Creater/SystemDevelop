using ObjectDatabase;
using System.ComponentModel;
using System.Windows.Forms;
using SystemDevelop.DataModels;

namespace SystemDevelop.Model.DB
{
    public class DataSource
    {
        public static void SetAllDataSource(MainForm form)
        {
        }

        public static void SetDataSource<T>(DataGridView dataGridVeuw,DataTable<T> table) where T : IDataModel,new()
        {
            dataGridVeuw.DataSource = GetDataSource<T>(table);   
        }

        public static BindingList<T> GetDataSource<T> (DataTable<T> table) where T : IDataModel, new()
        {
            BindingList<T> dataSouce
                = new BindingList<T>(table.ToArray());
            
            return dataSouce;
        }
    }
}
