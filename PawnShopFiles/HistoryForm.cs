using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace PawnShopFiles
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        private List<History> _histrory = new List<History>();
        
        public void reload()
        {
            _histrory = FilesManager.ReadHistory("history.txt");
            InitializeTable(_histrory);
        }
        
        private void InitializeTable(List<History> history)
        {
            historyTable.Columns.Clear();
            historyTable.Columns.Add("id", "ID");
            historyTable.Columns.Add("type_of_operation","Тип операції");     
            historyTable.Columns.Add("client","Клієнт");
            historyTable.Columns.Add("employee", "Працівник");
            historyTable.Columns.Add("property_info", "Майно");
            historyTable.Columns.Add("asert_value", "Оціночна вартість");
            historyTable.Columns.Add("price", "Ціна");
            historyTable.Columns.Add("dateOfOper", "Дата операції");
            
            historyTable.Rows.Clear();
            if (history.Count() >0)
            {
                foreach (var hs in history)
                {
                    historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                }
            }
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void operationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sortedHistory = _histrory;
            switch (opTypeBox.Text)
            {
                case "Усі":
                    reload();
                    break;
                case "Продаж":
                    InitializeTable(sortedHistory.Where(h => h.TypeOfOperation == OperType.Sell).ToList());
                    break;
                case "Покупка":
                    InitializeTable(sortedHistory.Where(h => h.TypeOfOperation == OperType.Buy).ToList());
                    break;
                case "Повернення":
                    InitializeTable(sortedHistory.Where(h => h.TypeOfOperation == OperType.Return).ToList());
                    break;
                default:
                    reload();
                    break;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                historyTable.Rows.Clear();
                switch (comboBox1.Text)
                {
                    case "Майно":
                        foreach (var hs in _histrory) {
                            if (hs.PawnInfo.Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    case "Клієнт":
                        foreach (var hs in _histrory) {
                            if (hs.ClientInfo.Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    case "Працівник":
                        foreach (var hs in _histrory) {
                            if (hs.EmpInfo.Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    case "Оціночна вартість":
                        foreach (var hs in _histrory) {
                            if (hs.AsValue.ToString().Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    case "Ціна":
                        foreach (var hs in _histrory) {
                            if (hs.Price.ToString().Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    case "Дата операції":
                        foreach (var hs in _histrory) {
                            if (hs.DateOfOperation.ToString().Contains(textBox1.Text)) 
                                historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price,hs.DateOfOperation.ToShortDateString());
                        }
                        break;
                    default:
                        reload();
                        break;
                }
            }
            else reload();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<History> sortedHs = _histrory;
            switch (comboBox2.Text)
            {
                case "Ціна":
                    sortedHs = sortedHs.OrderBy(c => c.Price).ToList();
                    InitializeTable(sortedHs);
                    break;
                case "Оціночна вартість":
                    sortedHs = sortedHs.OrderBy(c => c.AsValue).ToList();
                    InitializeTable(sortedHs);
                    break;
                case "Датою":
                    sortedHs = sortedHs.OrderBy(c => c.DateOfOperation).ToList();
                    InitializeTable(sortedHs);
                    break;
                default:
                    reload();
                    break;
            }
        }

        private void editSwitch_Click(object sender, EventArgs e)
        {
            if (editSwitch.Text == "Скасувати редагування")
            {
                deleteButton.Visible = false;
                clearButton.Visible = false;
                panel3.Visible = false;
                editSwitch.Text = "Увімкнути редагування";
                reload();
            }
            else
            {
                reload();
                deleteButton.Visible = true;
                clearButton.Visible = true;
                panel3.Visible = true;
                editSwitch.Text = "Скасувати редагування";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var deletedHist = _histrory
                    .Where(hs => hs.Id == Convert.ToInt32(historyTable.CurrentRow.Cells[0].Value)).ToList();
                _histrory.RemoveAll(hs => hs == deletedHist[0]);
                historyTable.Rows.RemoveAt(historyTable.CurrentRow.Index);
                FilesManager.WriteHistory(_histrory, "history.txt");
                reload();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені?", "Ця дія не зворотня", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _histrory = new List<History>();
                FilesManager.WriteHistory(_histrory, "history.txt");
                reload();
            }
        }
    }
}