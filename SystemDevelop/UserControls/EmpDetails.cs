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
    public partial class EmpDetails : UserControl
    {
        public EmpDetails()
        {
            InitializeComponent();
        }

        public void SetDetail(Employee employee)
        {
            empId.Text = employee.EmployeeId;
            empName.Text = employee.EmployeeName;
            empAffiliation.Text = employee.AffiliationId;
            empPassword.Text = employee.Password;
            empPhone.Text = employee.PhoneNumber;
            pigeonName.Text = employee.PigeonId;
            empHiring.Text = employee.WorkingFlag.ToString();
        }
    }
}
