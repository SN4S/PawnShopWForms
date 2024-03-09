using System.ComponentModel;

namespace PawnShopFiles
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.opTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttton2 = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editSwitch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteButtton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTable
            // 
            this.historyTable.AllowUserToAddRows = false;
            this.historyTable.AllowUserToDeleteRows = false;
            this.historyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.historyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.historyTable.Location = new System.Drawing.Point(12, 120);
            this.historyTable.Name = "historyTable";
            this.historyTable.ReadOnly = true;
            this.historyTable.Size = new System.Drawing.Size(713, 426);
            this.historyTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 103);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 60);
            this.label5.TabIndex = 16;
            this.label5.Text = "Історія операцій";
            // 
            // opTypeBox
            // 
            this.opTypeBox.FormattingEnabled = true;
            this.opTypeBox.Items.AddRange(new object[] { "Усі", "Продаж", "Покупка", "Повернення" });
            this.opTypeBox.Location = new System.Drawing.Point(731, 148);
            this.opTypeBox.Name = "opTypeBox";
            this.opTypeBox.Size = new System.Drawing.Size(121, 21);
            this.opTypeBox.TabIndex = 2;
            this.opTypeBox.Text = "Усі";
            this.opTypeBox.SelectedIndexChanged += new System.EventHandler(this.operationTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(741, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип операцій";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(731, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пошук за";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Майно", "Клієнт", "Працівник", "Оціночна вартість", "Ціна", "Дата операції" });
            this.comboBox1.Location = new System.Drawing.Point(731, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Майно";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(731, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(731, 272);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buttton2
            // 
            this.buttton2.Location = new System.Drawing.Point(731, 301);
            this.buttton2.Name = "buttton2";
            this.buttton2.Size = new System.Drawing.Size(121, 23);
            this.buttton2.TabIndex = 8;
            this.buttton2.Text = "Скинути";
            this.buttton2.UseVisualStyleBackColor = true;
            this.buttton2.Click += new System.EventHandler(this.reset_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(731, 400);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 23);
            this.sortButton.TabIndex = 11;
            this.sortButton.Text = "Сортувати";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] { "Оціночна вартість", "Ціна", "Датою" });
            this.comboBox2.Location = new System.Drawing.Point(731, 373);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Датою";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(731, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сортувати за";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Скинути";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reset_Click);
            // 
            // editSwitch
            // 
            this.editSwitch.Location = new System.Drawing.Point(12, 552);
            this.editSwitch.Name = "editSwitch";
            this.editSwitch.Size = new System.Drawing.Size(132, 44);
            this.editSwitch.TabIndex = 13;
            this.editSwitch.Text = "Увімкнути редагування";
            this.editSwitch.UseVisualStyleBackColor = true;
            this.editSwitch.Click += new System.EventHandler(this.editSwitch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.deleteButtton);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Location = new System.Drawing.Point(731, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 140);
            this.panel3.TabIndex = 24;
            this.panel3.Visible = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Видалення";
            // 
            // deleteButtton
            // 
            this.deleteButtton.Location = new System.Drawing.Point(3, 101);
            this.deleteButtton.Name = "deleteButtton";
            this.deleteButtton.Size = new System.Drawing.Size(120, 23);
            this.deleteButtton.TabIndex = 27;
            this.deleteButtton.Text = "Видалити";
            this.deleteButtton.UseVisualStyleBackColor = true;
            this.deleteButtton.Click += new System.EventHandler(this.deleteButtton_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Введіть ID";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(3, 69);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(150, 552);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 44);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Видалити вибраний запис";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(268, 552);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 44);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Очистити історію";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 603);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.editSwitch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttton2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opTypeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyTable);
            this.Name = "HistoryForm";
            this.Text = "Історія операцій";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button deleteButtton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.Button editSwitch;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button buttton2;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ComboBox opTypeBox;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.DataGridView historyTable;

        #endregion
    }
}