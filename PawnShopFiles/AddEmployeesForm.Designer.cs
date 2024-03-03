using System.ComponentModel;

namespace PawnShopFiles
{
    partial class AddEmployeesForm
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.MaskedTextBox();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.label16);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.fnameBox);
            this.addPanel.Controls.Add(this.snameBox);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.AddClientButton);
            this.addPanel.Controls.Add(this.phoneBox);
            this.addPanel.Location = new System.Drawing.Point(12, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(125, 225);
            this.addPanel.TabIndex = 31;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я";
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(3, 74);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(112, 20);
            this.fnameBox.TabIndex = 1;
            // 
            // snameBox
            // 
            this.snameBox.Location = new System.Drawing.Point(3, 123);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(112, 20);
            this.snameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефону";
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(4, 193);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(112, 23);
            this.AddClientButton.TabIndex = 9;
            this.AddClientButton.Text = "Додати";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(4, 167);
            this.phoneBox.Mask = "+38 (999) 000-0000";
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(112, 20);
            this.phoneBox.TabIndex = 13;
            // 
            // AddEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 252);
            this.Controls.Add(this.addPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(164, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(164, 291);
            this.Name = "AddEmployeesForm";
            this.Text = "Додати працівника";
            this.Load += new System.EventHandler(this.AddEmployeesForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.MaskedTextBox phoneBox;

        #endregion
    }
}