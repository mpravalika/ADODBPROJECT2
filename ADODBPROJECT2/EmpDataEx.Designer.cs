namespace ADODBPROJECT2
{
    partial class EmpDataEx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvemp
            // 
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee});
            this.dgvemp.Location = new System.Drawing.Point(50, 27);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.Size = new System.Drawing.Size(536, 207);
            this.dgvemp.TabIndex = 0;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellContentClick);
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpDataEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvemp);
            this.Name = "EmpDataEx";
            this.Text = "EmpDataEx";
            this.Load += new System.EventHandler(this.EmpDataEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Employee;
        private System.Windows.Forms.Button button1;
    }
}