using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShopFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsListForm form = Application.OpenForms.OfType<ClientsListForm>().FirstOrDefault();
            if (form != null) form.Focus();
            else
            {
                Form form1 = new ClientsListForm(); 
                form1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeesListForm form = Application.OpenForms.OfType<EmployeesListForm>().FirstOrDefault();
            if (form != null) form.Focus();
            else
            {
                Form form1 = new EmployeesListForm(); 
                form1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HistoryForm form = Application.OpenForms.OfType<HistoryForm>().FirstOrDefault();
            if (form != null) form.Focus();
            else
            {
                Form form1 = new HistoryForm(); 
                form1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PropertyForm form = Application.OpenForms.OfType<PropertyForm>().FirstOrDefault();
            if (form != null) form.Focus();
            else
            {
                Form form1 = new PropertyForm(); 
                form1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дана програма створена для керування базою ломбарду. \nВ ній є 4 структури - Клієнти, Працівники, Товари і Історія операцій. \nДля керування кожною з них є окремі форми. \nНа всіх формах є додавання, видалення, редагування, сортування та пошук.\n \n Комбінації клавіш: \n F1 - Допомога \n" +
                            "Esc - Вихід\n" +
                            "Ctrl + C - Таблиця клієнтів\n" +
                            "Ctrl + E - Таблиця працівників\n" +
                            "Ctrl + H - Таблиця історії\n" +
                            "Ctrl + P - Таблиця майна\n");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1) button5.PerformClick();
            if(e.KeyCode == Keys.Escape) Close();
            if (e.Control && e.KeyCode == Keys.C)
            {
                button1.PerformClick();
            }else if (e.Control && e.KeyCode == Keys.E)
            {
                button2.PerformClick();
            }else if (e.Control && e.KeyCode == Keys.H)
            {
                button3.PerformClick();
            }else if (e.Control && e.KeyCode == Keys.P)
            {
                button4.PerformClick();
            }else{}
        }
    }
}