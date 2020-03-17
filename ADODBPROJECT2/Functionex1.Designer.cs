namespace ADODBPROJECT2
{
    partial class Functionex1
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
            this.txthiredate = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txthiredate
            // 
            this.txthiredate.Location = new System.Drawing.Point(170, 81);
            this.txthiredate.Name = "txthiredate";
            this.txthiredate.Size = new System.Drawing.Size(163, 20);
            this.txthiredate.TabIndex = 0;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(467, 70);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(146, 41);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(135, 179);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(519, 163);
            this.dgvdata.TabIndex = 2;
            // 
            // Functionex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txthiredate);
            this.Name = "Functionex1";
            this.Text = "Functionex1";
            this.Load += new System.EventHandler(this.Functionex1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthiredate;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView dgvdata;
    }
}