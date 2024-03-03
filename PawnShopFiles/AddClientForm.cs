using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }
        private List<Client> _clientsList = new List<Client>();
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
            };
            if (snameBox.Text != "" && fnameBox.Text != "" && phoneBox.Text.Length == 18 && addressBox.Text != "")
            {
                Client clients = new Client(lastId+1, fnameBox.Text, snameBox.Text, phoneBox.Text, addressBox.Text);
                _clientsList.Add(clients);
                FilesManager.WriteClients(_clientsList, "clients.txt");
                PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
                if (form != null) form.addNewClientToCombo(clients);
                MessageBox.Show(@"Додано");  
                Close();
                return;
            }
            MessageBox.Show(@"Заповніть всі поля!");
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            _clientsList = FilesManager.ReadClients("clients.txt");
        }
    }
}