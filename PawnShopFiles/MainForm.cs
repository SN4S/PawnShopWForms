using System;
using System.Linq;
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
                            "Ctrl + P - Таблиця майна\n","Інструкція");
        }

        private void майноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void працівникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void історіяОпераційToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void інструкціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.PerformClick();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Система керування базою даних ломбарду \n" +
                            "v.0.9\n" +
                            "Developed with ❤️ by Ratsoi Oleksandr\n" +
                            "2024\n","Про програму");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            проПрограмуToolStripMenuItem.PerformClick();
        }
    }
}