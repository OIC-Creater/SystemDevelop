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
    public partial class EmpAddControl : UserControl
    {
        public EmpAddControl()
        {
            InitializeComponent();
        }

        private void EmpAddControl_Load(object sender, EventArgs e)
        {
            empId.Text = $"E{(DatabaseInstance.EmployeeTable.Count + 1).ToString("00000000")}";
            affiliationAddComboBox.Items.Add("倉庫");
            affiliationAddComboBox.Items.Add("営業所");
            affiliationAddComboBox.Items.Add("本社");

        }

        private void empAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee
                {
                    EmployeeId = empId.Text,
                    Password = psswordAddTextBox.Text,
                    EmployeeName = empNameTextBox.Text,
                    EmployeeKatakana = empKanaTextBox.Text,
                    AffiliationId = affiliationId.Text,
                    PhoneNumber = empPhoneTextBox.Text,
                    PigeonId = $"E{(DatabaseInstance.PigeonTable.Count + 1).ToString("00000000")}",
                    WorkingFlag = true
                };
                DatabaseInstance.EmployeeTable.Insert(emp);
                DatabaseInstance.EmployeeTable.Sync();
            }
            catch
            {
                MessageBox.Show("社員の追加に失敗しました");
            }
        }

        private void affiliationAddComboBox_TextChanged(object sender, EventArgs e)
        {
            if (affiliationAddComboBox.Text == "倉庫") affiliationId.Text = "A01";
            else if (affiliationAddComboBox.Text == "営業所") affiliationId.Text = "A02";
            else if (affiliationAddComboBox.Text == "本社") affiliationId.Text = "A03";
        }
    }
}
