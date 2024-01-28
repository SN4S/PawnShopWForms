using System.ComponentModel;

namespace PawnShopFiles
{
    partial class EmployeesListForm
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(625, 363);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeButton.TabIndex = 19;
            this.AddEmployeeButton.Text = "button1";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(625, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(625, 222);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(625, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // snameBox
            // 
            this.snameBox.Location = new System.Drawing.Point(625, 151);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(100, 20);
            this.snameBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(625, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(625, 77);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 20);
            this.fnameBox.TabIndex = 11;
            // 
            // employeesTable
            // 
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Location = new System.Drawing.Point(76, 30);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.Size = new System.Drawing.Size(523, 390);
            this.employeesTable.TabIndex = 10;
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.snameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.employeesTable);
            this.Name = "EmployeesListForm";
            this.Text = "EmployeesListForm";
            this.Load += new System.EventHandler(this.EmployeesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.DataGridView employeesTable;

        #endregion
    }
}