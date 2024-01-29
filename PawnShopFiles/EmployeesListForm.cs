using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class EmployeesListForm : Form
    {
        public EmployeesListForm()
        {
            InitializeComponent();
        }

        private List<Employee> _employeeslist = new List<Employee>();

        public void reload()
        {
            _employeeslist = FilesManager.ReadEmployees("employees.txt");
            InitializeTable();
        }

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void InitializeTable()
        {
            employeesTable.Columns.Clear();
            employeesTable.Columns.Add("id", "ID");
            employeesTable.Columns.Add("firstname", "Ім'я");
            employeesTable.Columns.Add("surname", "Прізвище");
            employeesTable.Columns.Add("phone", "Телефон");

            employeesTable.Rows.Clear();
            if (_employeeslist.Count() > 0)
            {
                foreach (var employee in _employeeslist)
                {
                    employeesTable.Rows.Add(employee.Id, employee.Fname, employee.Sname, employee.Phone);
                }
            }
        }

    private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var addedEmployees = _employeeslist.Where(employee => employee.Phone == phoneBox.Text).ToList();
            int lastId;
            if (_employeeslist.Count() > 0)
            {
                lastId = _employeeslist.Last().Id;
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

            if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length < 14)
            {
                Employee employee = new Employee(lastId+1, snameBox.Text, snameBox.Text, phoneBox.Text);
                _employeeslist.Add(employee);
                FilesManager.WriteEmployees(_employeeslist, "employees.txt");
                InitializeTable();
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }
    }
}