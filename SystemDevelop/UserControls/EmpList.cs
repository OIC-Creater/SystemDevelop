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
            employee.EmployeeId = selectedData.Cells[0].Value.ToString();
            employee.Password = selectedData.Cells[1].Value.ToString();
            employee.EmployeeName = selectedData.Cells[2].Value.ToString();
            employee.EmployeeKatakana = selectedData.Cells[3].Value.ToString();
            employee.AffiliationId = selectedData.Cells[4].Value.ToString();
            employee.PhoneNumber = selectedData.Cells[5].Value.ToString();
            employee.PigeonId = selectedData.Cells[6].Value.ToString();
            employee.WorkingFlag = Convert.ToBoolean(selectedData.Cells[7].Value);
            return employee;
        }
    }
}
