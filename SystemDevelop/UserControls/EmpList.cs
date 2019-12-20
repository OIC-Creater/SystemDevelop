using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemDevelop.DataModels;
using SystemDevelop.Model.DB;

namespace SystemDevelop.UserControls
{
    public partial class EmpList : UserControl
    {
        public EmpList()
        {
            InitializeComponent();
        }

        public Employee GetRowData()
        {
            Employee employee = new Employee();
            DataGridViewRow selectedData = empGridView.CurrentRow;
            Console.WriteLine(selectedData);
            return DatabaseInstance.EmployeeTable.Where(e => e.EmployeeId == selectedData.Cells[0].Value.ToString()).First();
        }

        private void empGridView_VisibleChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataSource.SetDataSource<Employee>(empGridView, DatabaseInstance.EmployeeTable);
            }
            
        }
    }
}
