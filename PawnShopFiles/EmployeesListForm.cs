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

        private List<Client> _clientsList = new List<Client>();
        private List<Employee> _employeesList = new List<Employee>();
        private List<Property> _propertiesList = new List<Property>();

        public void reload()
        {
            _clientsList = FilesManager.ReadClients("clients.txt");
            _employeesList = FilesManager.ReadEmployees("employees.txt");
            _propertiesList = FilesManager.ReadProperty(_clientsList,_employeesList,"property.txt");
            InitializeTable(_employeesList);
        }

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void InitializeTable(List<Employee> employees)
        {
            employeesTable.Columns.Clear();
            employeesTable.Columns.Add("id", "ID");
            employeesTable.Columns.Add("firstname", "Ім'я");
            employeesTable.Columns.Add("surname", "Прізвище");
            employeesTable.Columns.Add("phone", "Телефон");

            employeesTable.Rows.Clear();
            if (employees.Count() > 0)
            {
                foreach (var employee in employees)
                {
                    employeesTable.Rows.Add(employee.Id, employee.Fname, employee.Sname, employee.Phone);
                }
            }
        }

    private void AddEmployeeButton_Click(object sender, EventArgs e)
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
                MessageBox.Show(@"Працівник з таким номером телефону вже існує","Помилка");
                return;
            }

            if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length == 18)
            {
                Employee employee = new Employee(lastId+1, fnameBox.Text, snameBox.Text, phoneBox.Text);
                _employeesList.Add(employee);
                FilesManager.WriteEmployees(_employeesList, "employees.txt");
                InitializeTable(_employeesList);
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }
    private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var deletedEmployee = _employeesList
                    .Where(em => em.Id == Convert.ToInt32(employeesTable.CurrentRow.Cells[0].Value)).ToList();

                _propertiesList.RemoveAll(prop => prop.Emp == deletedEmployee[0]);
                FilesManager.WriteProperty(_propertiesList, "property.txt");
                employeesTable.Rows.RemoveAt(employeesTable.CurrentRow.Index);
                saveButton.Visible = true;
                saveButton.PerformClick();
                saveButton.Visible = false;
                PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                if (form != null) form.reload();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EditSwitchButton.Text == "Скасувати редагування")
            {
                saveButton.Visible = false;
                deleteButton.Visible = false;
                employeesTable.ReadOnly = true;
                
                addPanel.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                EditSwitchButton.Text = "Увімкнути редагування";
                InitializeTable(_employeesList);
            }
            else
            {
                InitializeTable(_employeesList);
                deleteButton.Visible = true;
                employeesTable.ReadOnly = false;
                addPanel.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                employeesTable.Columns[0].ReadOnly = true;
                EditSwitchButton.Text = "Скасувати редагування";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee employee;
            _employeesList.Clear();
            for (int i = 0; i < employeesTable.Rows.Count; i++)
            {
                if(String.IsNullOrWhiteSpace(employeesTable.Rows[i].Cells[1].FormattedValue as String)||String.IsNullOrWhiteSpace(employeesTable.Rows[i].Cells[2].FormattedValue as String)||String.IsNullOrWhiteSpace(employeesTable.Rows[i].Cells[3].FormattedValue as String)){
                    MessageBox.Show(@"Заповніть всі поля!");
                    return;
                }else
                {
                    employee = new Employee(Convert.ToInt32(employeesTable.Rows[i].Cells["Id"].Value),
                        employeesTable.Rows[i].Cells["firstname"].Value.ToString(),
                        employeesTable.Rows[i].Cells["surname"].Value.ToString(),
                        employeesTable.Rows[i].Cells["phone"].Value.ToString());
                    _employeesList.Add(employee);
                }
            }

            FilesManager.WriteEmployees(_employeesList, "employees.txt");
            saveButton.Visible = false;
            PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
            if (form != null) form.reload();
        }

        private void clientsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            saveButton.Visible = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<Employee> sortedEmployees = _employeesList;
            switch (comboBox1.Text)
            {
                case "-":
                    reload();
                    break;
                case "Ім'я":
                    sortedEmployees = sortedEmployees.OrderBy(c => c.Fname).ToList();
                    InitializeTable(sortedEmployees);
                    break;
                case "Прізвище":
                    sortedEmployees = sortedEmployees.OrderBy(c => c.Sname).ToList();
                    InitializeTable(sortedEmployees);
                    break;
                case "Номер телефону":
                    sortedEmployees = sortedEmployees.OrderBy(c => c.Phone).ToList();
                    InitializeTable(sortedEmployees);
                    break;
                default:
                    reload();
                    break;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "+38 (   )    -")
            {
                employeesTable.Rows.Clear();
                foreach (var employee in _employeesList)
                {
                    if(employee.Phone.Contains(maskedTextBox1.Text))employeesTable.Rows.Add(employee.Id,employee.Fname,employee.Sname,employee.Phone);
                }
            }
            else reload();
        }

        private void EditClick(object sender, EventArgs e)
        {
            var addedEmployees = _employeesList.Where(em => em.Id == numericUpDown1.Value).ToList();
            if (addedEmployees.Count!=0)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox2.Text.Length == 18 )
                {
                    int index = _employeesList.FindLastIndex(em => em.Id == numericUpDown1.Value);
                    if (index != -1)
                    {
                        _employeesList[index] = new Employee(_employeesList[index].Id, textBox1.Text, textBox2.Text,
                            maskedTextBox2.Text);
                    }
                    
                    FilesManager.WriteEmployees(_employeesList, "employees.txt");
                    InitializeTable(_employeesList);
                    PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                    if (form != null) form.reload();
                }
                else
                {
                    MessageBox.Show(@"Заповніть всі поля");
                }
            }
            else
            {
                MessageBox.Show(@"Працівник з таким ідентифікатором ее існує","Помилка");
            }
            
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            var addedEmp = _employeesList.Where(client => client.Id == numericUpDown2.Value).ToList();
            if (addedEmp.Count != 0)
            {
                if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deletedEmp = _employeesList
                        .Where(em => em.Id == Convert.ToInt32(numericUpDown2.Value)).ToList();

                    _employeesList.RemoveAll(em => em == deletedEmp[0]);
                    _propertiesList.RemoveAll(prop => prop.Emp == deletedEmp[0]);
                    FilesManager.WriteProperty(_propertiesList, "property.txt");
                    FilesManager.WriteEmployees(_employeesList, "employees.txt");
                    PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                    if (form != null) form.reload();
                    reload();
                }
            }
            else
            {
                MessageBox.Show(@"Клієнт з таким ідентифікатором ее існує","Помилка");
            }
        }
    }
}