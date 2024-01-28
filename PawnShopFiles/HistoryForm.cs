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
        private List<Histrory> _histrory = new List<Histrory>();

        public void reload()
        {
            _histrory = FilesManager.ReadHistory("history.txt");
            InitializeTable();
        }
        
        private void InitializeTable()
        {
            historyTable.Columns.Clear();
            historyTable.Columns.Add("id", "ID");
            historyTable.Columns.Add("type_of_operation","Тип операції");     
            historyTable.Columns.Add("client","Клієнт");
            historyTable.Columns.Add("employee", "Працівник");
            historyTable.Columns.Add("property_info", "Майно");
            historyTable.Columns.Add("asert_value", "Оціночна вартість");
            historyTable.Columns.Add("price", "Ціна");
            
            historyTable.Rows.Clear();
            if (_histrory.Count() >0)
            {
                foreach (var hs in _histrory)
                {
                    historyTable.Rows.Add(hs.Id, hs.TypeOfOperation, hs.ClientInfo, hs.EmpInfo, hs.PawnInfo, hs.AsValue, hs.Price);
                }
            }
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}