using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
        }
        
        
        private List<Client> _clientsList = new List<Client>();
        private List<Employee> _employeesList = new List<Employee>();
        private List<Property> _propertiesList = new List<Property>();
        private List<History> _historyList = new List<History>();
        
        public void reload()
        {
            _clientsList = FilesManager.ReadClients("clients.txt");
            _employeesList = FilesManager.ReadEmployees("employees.txt");
            _historyList = FilesManager.ReadHistory("history.txt");
            _propertiesList = FilesManager.ReadProperty(_clientsList,_employeesList,"property.txt");
            InitializeTable(_propertiesList);
            InitializeEmployeesCombobox();
            InitializeClientsCombobox();
        }
        
        private void InitializeTable(List<Property> properties)
        {
            DataGridViewComboBoxColumn clientCmb = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn empCmb = new DataGridViewComboBoxColumn();
            empCmb.HeaderText = "Працівник";
            clientCmb.HeaderText = "Клієнт";
            int i = 0;
            object[] emps = new object[_employeesList.Count];
            object[] names = new object[_clientsList.Count];
            foreach (var emp in _employeesList)
            {
                emps[i] = $"{emp.Id}. {emp.Fname} {emp.Sname} ({emp.Phone})";
                i++;
            }
            i = 0;
            foreach (var client in _clientsList)
            {
                names[i] = $"{client.Id}. {client.Fname} {client.Sname} ({client.Phone})";
                i++;
            }
            
            empCmb.Items.AddRange(emps);
            clientCmb.Items.AddRange(names);
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add(clientCmb);     
            dataGridView1.Columns.Add(empCmb);
            dataGridView1.Columns.Add("type", "Тип");
            dataGridView1.Columns.Add("details", "Деталі");
            dataGridView1.Columns.Add("asvalue", "Оц. Вартість");
            dataGridView1.Columns.Add("price", "Ціна");
            dataGridView1.Columns.Add("dateOfOffer", "Дата здачі");
            dataGridView1.Columns.Add("termin", "Термін(дні)");
            
            
            dataGridView1.Rows.Clear();
            if (_propertiesList.Count() > 0)
            {
                foreach (var property in properties)
                {
                    dataGridView1.Rows.Add(property.Id, $"{property.Client.Id}. {property.Client.Fname} {property.Client.Sname} ({property.Client.Phone})", $"{property.Emp.Id}. {property.Emp.Fname} {property.Emp.Sname} ({property.Emp.Phone})",property.Type, property.Detail, property.AsValue, property.Price, property.DateOfOffer.ToShortDateString(),property.TermOfCont);
                }
            }
        }
        
        private void InitializeClientsCombobox()
        {
            object[] names = new object[_clientsList.Count];
            int i = 0;
            foreach (var client in _clientsList)
            {
                names[i] = $"{client.Id}. {client.Fname} {client.Sname} ({client.Phone})";
                i++;
            }
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(names);
            
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(names);
            
            comboBox9.Items.Clear();
            comboBox9.Items.AddRange(names);
        }
        private void InitializeEmployeesCombobox()
        {
            object[] names = new object[_employeesList.Count];
            int i = 0;
            foreach (var employee in _employeesList)
            {
                names[i] = $"{employee.Id}. {employee.Fname} {employee.Sname} ({employee.Phone})";
                i++;
            }
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(names);
            
            comboBox7.Items.Clear();
            comboBox7.Items.AddRange(names);
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "Виберіть" && comboBox3.Text != "Виберіть" && comboBox1.Text != "Виберіть" && textBox1.Text!="")
            {
                int lastId;
                if (_propertiesList.Count() > 0)
                {
                    lastId = _propertiesList.Last().Id;
                }
                else
                {
                    lastId = 0;
                }
                var clients = _clientsList.First(client =>
                    client.Id == Convert.ToInt32(comboBox2.Text.Split('.')[0]));
                var employee = _employeesList.First(em =>
                    em.Id == Convert.ToInt32(comboBox3.Text.Split('.')[0]));
                
                Property prop = new Property(lastId+1, clients, employee, comboBox1.Text,textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToDateTime(Convert.ToString(dateTimePicker1.Value.ToString().Split(' ')[0])),Convert.ToInt32(numericUpDown3.Value));
                _propertiesList.Add(prop);
                FilesManager.WriteProperty(_propertiesList, "property.txt");
                InitializeTable(_propertiesList);
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                dataGridView1.Rows.Clear();
                switch (comboBox4.Text)
                {
                    case "Клієнт":
                        foreach (var prop in _propertiesList) {
                            if ($"{prop.Client.Fname} {prop.Client.Sname} {prop.Client.Phone}".Contains(searchBox.Text)) 
                                dataGridView1.Rows.Add(prop.Id, $"{prop.Client.Id}. {prop.Client.Fname} {prop.Client.Sname} ({prop.Client.Phone})", $"{prop.Emp.Id}. {prop.Emp.Fname} {prop.Emp.Sname} ({prop.Emp.Phone})",prop.Type, prop.Detail, prop.AsValue, prop.Price, prop.DateOfOffer.ToShortDateString(),prop.TermOfCont);
                        }
                        break;
                    case "Працівник":
                        foreach (var prop in _propertiesList) {
                            if ($"{prop.Emp.Fname} {prop.Emp.Sname} {prop.Emp.Phone}".Contains(searchBox.Text)) 
                                dataGridView1.Rows.Add(prop.Id, $"{prop.Client.Id}. {prop.Client.Fname} {prop.Client.Sname} ({prop.Client.Phone})", $"{prop.Emp.Id}. {prop.Emp.Fname} {prop.Emp.Sname} ({prop.Emp.Phone})",prop.Type, prop.Detail, prop.AsValue, prop.Price, prop.DateOfOffer.ToShortDateString(),prop.TermOfCont);
                        }
                        break;
                    case "Опис":
                        foreach (var prop in _propertiesList) {
                            if (prop.Detail.Contains(searchBox.Text)) 
                                dataGridView1.Rows.Add(prop.Id, $"{prop.Client.Id}. {prop.Client.Fname} {prop.Client.Sname} ({prop.Client.Phone})", $"{prop.Emp.Id}. {prop.Emp.Fname} {prop.Emp.Sname} ({prop.Emp.Phone})",prop.Type, prop.Detail, prop.AsValue, prop.Price, prop.DateOfOffer.ToShortDateString(),prop.TermOfCont);
                        }
                        break;
                    default:
                        InitializeTable(_propertiesList);
                        break;
                }
            }
            else InitializeTable(_propertiesList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Property> sortedProp = _propertiesList;
            switch (comboBox5.Text)
            {
                case "Ціна":
                    sortedProp = sortedProp.OrderBy(c => c.Price).ToList();
                    InitializeTable(sortedProp);
                    break;
                case "Оціночна вартість":
                    sortedProp = sortedProp.OrderBy(c => c.AsValue).ToList();
                    InitializeTable(sortedProp);
                    break;
                case "Дата здачі":
                    sortedProp = sortedProp.OrderBy(c => c.DateOfOffer).ToList();
                    InitializeTable(sortedProp);
                    break;
                case "Термін":
                    sortedProp = sortedProp.OrderBy(c => c.TermOfCont).ToList();
                    InitializeTable(sortedProp);
                    break;
                default:
                    reload();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addedProp = _propertiesList.Where(em => em.Id == numericUpDown1.Value).ToList();
            if (addedProp.Count!=0)
            {
                if (comboBox6.Text != "Виберіть" && comboBox7.Text != "Виберіть" && comboBox8.Text != "Виберіть" && textBox2.Text!="")
                {
                    int index = _propertiesList.FindLastIndex(em => em.Id == numericUpDown8.Value);
                    
                    var clients = _clientsList.First(client =>
                        client.Id == Convert.ToInt32(comboBox6.Text.Split('.')[0]));
                    var employee = _employeesList.First(em =>
                        em.Id == Convert.ToInt32(comboBox7.Text.Split('.')[0]));

                    if (index != -1)
                    {
                        _propertiesList[index] = new Property(_propertiesList[index].Id, clients, employee, comboBox8.Text,textBox2.Text, Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value), Convert.ToDateTime(Convert.ToString(dateTimePicker2.Value.ToString().Split(' ')[0])),Convert.ToInt32(numericUpDown6.Value));

                    }
                    
                    FilesManager.WriteProperty(_propertiesList, "property.txt");
                    InitializeTable(_propertiesList);
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
                MessageBox.Show(@"Майно з таким ідентифікатором не існує");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addedProp = _propertiesList.Where(prop => prop.Id == numericUpDown7.Value).ToList();
            if (addedProp.Count != 0)
            {
                if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _propertiesList.RemoveAll(prop => prop.Id == numericUpDown7.Value);
                    FilesManager.WriteProperty(_propertiesList, "property.txt");
                    reload();
                }
            }
            else
            {
                MessageBox.Show(@"Майно з таким ідентифікатором не існує");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}