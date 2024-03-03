using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class AddEmployeesForm : Form
    {
        public AddEmployeesForm()
        {
            InitializeComponent();
        }
        
        private List<Employee> _employeesList = new List<Employee>();

        private void AddEmployeesForm_Load(object sender, EventArgs e)
        {
            _employeesList = FilesManager.ReadEmployees("employees.txt");
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
                var addedEmployees = _employeesList.Where(employee => employee.Phone == phoneBox.Text).ToList();
                int lastId;
                if (_employeesList.Count() > 0)
                {
                    lastId = _employeesList.Last().Id;
                }
                else
                {
                    lastId = 0;
                }
                if (addedEmployees.Count != 0)
                {
                    MessageBox.Show(@"Працівник з таким номером телефону вже існує");
                    return;
                }

                if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length == 18)
                {
                    Employee employee = new Employee(lastId+1, fnameBox.Text, snameBox.Text, phoneBox.Text);
                    _employeesList.Add(employee);
                    FilesManager.WriteEmployees(_employeesList, "employees.txt");
                    PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                    if (form != null) form.addNewEmpToComboboxes(employee);
                    MessageBox.Show(@"Додано");
                    Close();
                    return;
                }
                MessageBox.Show(@"Заповніть всі поля!");
        }
    }
}