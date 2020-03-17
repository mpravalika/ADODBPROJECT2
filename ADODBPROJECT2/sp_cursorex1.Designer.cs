namespace ADODBPROJECT2
{
    partial class sp_cursorex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.txtupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deptno";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptno.Location = new System.Drawing.Point(359, 67);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(122, 29);
            this.txtdeptno.TabIndex = 1;
            // 
            // txtupdate
            // 
            this.txtupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupdate.Location = new System.Drawing.Point(185, 190);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(137, 52);
            this.txtupdate.TabIndex = 2;
            this.txtupdate.Text = "button1";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.txtupdate_Click);
            // 
            // sp_cursorex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.label1);
            this.Name = "sp_cursorex1";
            this.Text = "sp_cursorex1";
            this.Load += new System.EventHandler(this.sp_cursorex1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Button txtupdate;
    }
}