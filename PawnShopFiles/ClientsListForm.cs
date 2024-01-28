using System;
using System.Collections.Generic;
using System.Linq;
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

        public void reload()
        {
            _clientsList = FilesManager.ReadClients("clients.txt");
            InitializeTable();
        }
        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void InitializeTable()
        {
            clientsTable.Columns.Clear();
            clientsTable.Columns.Add("id", "ID");
            clientsTable.Columns.Add("firstname","Ім'я");     
            clientsTable.Columns.Add("surname","Прізвище");
            clientsTable.Columns.Add("phone", "Телефон");
            clientsTable.Columns.Add("address", "Адреса");
            
            clientsTable.Rows.Clear();
            if (_clientsList.Count() >0)
            {
                foreach (var client in _clientsList)
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
                MessageBox.Show(@"Клієнт з таким номером телефону вже існує");
                return;
            }

            if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length < 14)
            {
                Client clients = new Client(lastId+1, snameBox.Text, snameBox.Text, phoneBox.Text, addressBox.Text);
                _clientsList.Add(clients);
                FilesManager.WriteClients(_clientsList, "clients.txt");
                InitializeTable();
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }

        
    }
}