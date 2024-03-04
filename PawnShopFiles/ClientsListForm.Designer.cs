using System.ComponentModel;

namespace PawnShopFiles
{
    partial class ClientsListForm
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
            this.clientsTable = new System.Windows.Forms.DataGridView();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.EditSwitchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.MaskedTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteButtton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsTable
            // 
            this.clientsTable.AllowUserToAddRows = false;
            this.clientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTable.Location = new System.Drawing.Point(12, 106);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.ReadOnly = true;
            this.clientsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.clientsTable.Size = new System.Drawing.Size(523, 425);
            this.clientsTable.TabIndex = 0;
            this.clientsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsTable_CellValueChanged);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(3, 74);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(112, 20);
            this.fnameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Прізвище";
            // 
            // snameBox
            // 
            this.snameBox.Location = new System.Drawing.Point(3, 123);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(112, 20);
            this.snameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адреса";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(3, 172);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(112, 20);
            this.addressBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефону";
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(3, 247);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(112, 23);
            this.AddClientButton.TabIndex = 9;
            this.AddClientButton.Text = "Додати";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // EditSwitchButton
            // 
            this.EditSwitchButton.Location = new System.Drawing.Point(12, 537);
            this.EditSwitchButton.Name = "EditSwitchButton";
            this.EditSwitchButton.Size = new System.Drawing.Size(110, 35);
            this.EditSwitchButton.TabIndex = 10;
            this.EditSwitchButton.Text = "Увімкнути редагування";
            this.EditSwitchButton.UseVisualStyleBackColor = true;
            this.EditSwitchButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(128, 537);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Видалити вибраного клієнта";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 89);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 60);
            this.label5.TabIndex = 15;
            this.label5.Text = "Клієнти";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(3, 221);
            this.phoneBox.Mask = "+38 (999) 000-0000";
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(112, 20);
            this.phoneBox.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(429, 537);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 35);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Зберегти зміни";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(559, 427);
            this.maskedTextBox1.Mask = "+38 (999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(559, 453);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(559, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пошук за номером телефону";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "-", "Ім\'я", "Прізвище", "Номер телефону", "Адреса" });
            this.comboBox1.Location = new System.Drawing.Point(559, 515);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "-";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(559, 542);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(112, 23);
            this.sortButton.TabIndex = 19;
            this.sortButton.Text = "Сортувати";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(559, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Виберіть ключ";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.label16);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.fnameBox);
            this.addPanel.Controls.Add(this.snameBox);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.addressBox);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.AddClientButton);
            this.addPanel.Controls.Add(this.phoneBox);
            this.addPanel.Location = new System.Drawing.Point(559, 106);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(125, 276);
            this.addPanel.TabIndex = 21;
            this.addPanel.Visible = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(4, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "Додавання";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Location = new System.Drawing.Point(764, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 309);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(4, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "Редагування";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Введіть ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ім\'я";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Прізвище";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Адреса";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Номер телефону";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 282);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 23);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditClick);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(3, 256);
            this.maskedTextBox2.Mask = "+38 (999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.deleteButtton);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Location = new System.Drawing.Point(765, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 140);
            this.panel3.TabIndex = 23;
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
            this.deleteButtton.Click += new System.EventHandler(this.DeleteClick);
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
            // ClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.EditSwitchButton);
            this.Controls.Add(this.clientsTable);
            this.KeyPreview = true;
            this.Name = "ClientsListForm";
            this.Text = "Клієнти";
            this.Load += new System.EventHandler(this.ClientsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button deleteButtton;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sortButton;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.MaskedTextBox phoneBox;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.Button EditSwitchButton;

        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddClientButton;

        private System.Windows.Forms.DataGridView clientsTable;

        #endregion
    }
}