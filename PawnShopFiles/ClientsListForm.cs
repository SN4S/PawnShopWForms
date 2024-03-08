using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class ClientsListForm : Form
    {
        public ClientsListForm()
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
            InitializeTable(_clientsList);
        }
        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void InitializeTable(List<Client> clients)
        {
            clientsTable.Columns.Clear();
            clientsTable.Columns.Add("id", "ID");
            clientsTable.Columns.Add("firstname","Ім'я");     
            clientsTable.Columns.Add("surname","Прізвище");
            clientsTable.Columns.Add("phone", "Телефон");
            clientsTable.Columns.Add("address", "Адреса");
            
            clientsTable.Rows.Clear();
            if (clients.Count() >0)
            {
                foreach (var client in clients)
                {
                    clientsTable.Rows.Add(client.Id, client.Fname, client.Sname, client.Phone, client.Address);
                }
            }
        }
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var addedClients = _clientsList.Where(client => client.Phone == phoneBox.Text).ToList();
            int lastId;
            if (_clientsList.Count() > 0)
            {
                lastId = _clientsList.Last().Id;
            }
            else
            {
                lastId = 0;
            }
            if (addedClients.Count != 0)
            {
                MessageBox.Show(@"Клієнт з таким номером телефону вже існує","Помилка");
                return;
            }
            if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length == 18 && addressBox.Text != "")
            {
                Client clients = new Client(lastId+1, fnameBox.Text, snameBox.Text, phoneBox.Text, addressBox.Text);
                _clientsList.Add(clients);
                FilesManager.WriteClients(_clientsList, "clients.txt");
                InitializeTable(_clientsList);
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var deletedClient = _clientsList
                    .Where(client => client.Id == Convert.ToInt32(clientsTable.CurrentRow.Cells[0].Value)).ToList();

                _propertiesList.RemoveAll(rent => rent.Client == deletedClient[0]);
                clientsTable.Rows.RemoveAt(clientsTable.CurrentRow.Index);
                FilesManager.WriteProperty(_propertiesList, "property.txt");
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
                clientsTable.ReadOnly = true;
                
                addPanel.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                EditSwitchButton.Text = "Увімкнути редагування";
                InitializeTable(_clientsList);
            }
            else
            {
                InitializeTable(_clientsList);
                deleteButton.Visible = true;
                clientsTable.ReadOnly = false;
                addPanel.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                clientsTable.Columns[0].ReadOnly = true;
                EditSwitchButton.Text = "Скасувати редагування";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Client clients;
            _clientsList.Clear();
            for (int i = 0; i < clientsTable.Rows.Count; i++)
            {
                if(String.IsNullOrWhiteSpace(clientsTable.Rows[i].Cells[1].FormattedValue as String)||String.IsNullOrWhiteSpace(clientsTable.Rows[i].Cells[2].FormattedValue as String)||String.IsNullOrWhiteSpace(clientsTable.Rows[i].Cells[3].FormattedValue as String)){
                    MessageBox.Show(@"Заповніть всі поля!");
                    return;
                }else
                {
                    clients = new Client(Convert.ToInt32(clientsTable.Rows[i].Cells["Id"].Value),
                        clientsTable.Rows[i].Cells["firstname"].Value.ToString(),
                        clientsTable.Rows[i].Cells["surname"].Value.ToString(),
                        clientsTable.Rows[i].Cells["phone"].Value.ToString(),
                        clientsTable.Rows[i].Cells["address"].Value.ToString());
                    _clientsList.Add(clients);
                }
            }

            FilesManager.WriteClients(_clientsList, "clients.txt");
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
            List<Client> sortedClients = _clientsList;
            switch (comboBox1.Text)
            {
                case "-":
                    reload();
                    break;
                case "Ім'я":
                    sortedClients = sortedClients.OrderBy(c => c.Fname).ToList();
                    InitializeTable(sortedClients);
                    break;
                case "Прізвище":
                    sortedClients = sortedClients.OrderBy(c => c.Sname).ToList();
                    InitializeTable(sortedClients);
                    break;
                case "Номер телефону":
                    sortedClients = sortedClients.OrderBy(c => c.Phone).ToList();
                    InitializeTable(sortedClients);
                    break;
                case "Адреса":
                    sortedClients = sortedClients.OrderBy(c => c.Address).ToList();
                    InitializeTable(sortedClients);
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
                clientsTable.Rows.Clear();
                foreach (var client in _clientsList)
                {
                    if(client.Phone.Contains(maskedTextBox1.Text))clientsTable.Rows.Add(client.Id,client.Fname,client.Sname,client.Phone,client.Address);
                }
            }
            else reload();
        }

        private void EditClick(object sender, EventArgs e)
        {
            var addedClients = _clientsList.Where(client => client.Id == numericUpDown1.Value).ToList();
            if (addedClients.Count!=0)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox2.Text.Length == 18 &&
                    textBox3.Text != "")
                {
                    int index = _clientsList.FindLastIndex(c => c.Id == numericUpDown1.Value);
                    if (index != -1)
                    {
                        _clientsList[index] = new Client(_clientsList[index].Id, textBox1.Text, textBox2.Text,
                            maskedTextBox2.Text, textBox3.Text);
                    }
                    
                    FilesManager.WriteClients(_clientsList, "clients.txt");
                    InitializeTable(_clientsList);
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
                MessageBox.Show(@"Клієнт з таким ідентифікатором ее існує","Помилка");
            }
            
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            var addedClients = _clientsList.Where(client => client.Id == numericUpDown2.Value).ToList();
            if (addedClients.Count != 0)
            {
                if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deletedClient = _clientsList
                        .Where(client => client.Id == Convert.ToInt32(numericUpDown2.Value)).ToList();

                    _clientsList.RemoveAll(c => c == deletedClient[0]);
                    _propertiesList.RemoveAll(rent => rent.Client == deletedClient[0]);
                    FilesManager.WriteProperty(_propertiesList, "property.txt");
                    FilesManager.WriteClients(_clientsList, "clients.txt");
                    PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                    if (form != null) form.reload();
                    reload();
                }
            }
            else
            {
                MessageBox.Show(@"Клієнт з таким ідентифікатором не існує","Помилка");
            }
        }
    }
}