namespace ADODBPROJECT2
{
    partial class OrderProducts
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtord = new System.Windows.Forms.TextBox();
            this.txtorddesc = new System.Windows.Forms.TextBox();
            this.dtporddate = new System.Windows.Forms.DateTimePicker();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.cbbsalesid = new System.Windows.Forms.ComboBox();
            this.dgvOrdpro = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdpro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordreid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "orderdesc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "orderdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "customerid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salesmanid";
            // 
            // txtord
            // 
            this.txtord.Enabled = false;
            this.txtord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtord.Location = new System.Drawing.Point(137, 8);
            this.txtord.Name = "txtord";
            this.txtord.Size = new System.Drawing.Size(96, 23);
            this.txtord.TabIndex = 6;
            // 
            // txtorddesc
            // 
            this.txtorddesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorddesc.Location = new System.Drawing.Point(137, 56);
            this.txtorddesc.Name = "txtorddesc";
            this.txtorddesc.Size = new System.Drawing.Size(109, 23);
            this.txtorddesc.TabIndex = 7;
            // 
            // dtporddate
            // 
            this.dtporddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtporddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtporddate.Location = new System.Drawing.Point(137, 109);
            this.dtporddate.Name = "dtporddate";
            this.dtporddate.Size = new System.Drawing.Size(115, 23);
            this.dtporddate.TabIndex = 8;
            // 
            // txtdisc
            // 
            this.txtdisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisc.Location = new System.Drawing.Point(562, 8);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(111, 23);
            this.txtdisc.TabIndex = 9;
            // 
            // cmbcustid
            // 
            this.cmbcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(562, 59);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(102, 24);
            this.cmbcustid.TabIndex = 10;
            // 
            // cbbsalesid
            // 
            this.cbbsalesid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsalesid.FormattingEnabled = true;
            this.cbbsalesid.Location = new System.Drawing.Point(562, 109);
            this.cbbsalesid.Name = "cbbsalesid";
            this.cbbsalesid.Size = new System.Drawing.Size(107, 24);
            this.cbbsalesid.TabIndex = 11;
            // 
            // dgvOrdpro
            // 
            this.dgvOrdpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdpro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductDesc,
            this.Qty,
            this.price,
            this.Totalcost});
            this.dgvOrdpro.Location = new System.Drawing.Point(94, 159);
            this.dgvOrdpro.Name = "dgvOrdpro";
            this.dgvOrdpro.Size = new System.Drawing.Size(543, 179);
            this.dgvOrdpro.TabIndex = 12;
            this.dgvOrdpro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdpro_CellClick);
            //this.dgvOrdpro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdpro_CellContentClick);
            //this.dgvOrdpro.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdpro_CellLeave);
            this.dgvOrdpro.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdpro_RowLeave);
            this.dgvOrdpro.SelectionChanged += new System.EventHandler(this.dgvOrdpro_SelectionChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(294, 360);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(113, 37);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.dgvOrdpro);
            this.panel1.Controls.Add(this.cbbsalesid);
            this.panel1.Controls.Add(this.cmbcustid);
            this.panel1.Controls.Add(this.txtdisc);
            this.panel1.Controls.Add(this.dtporddate);
            this.panel1.Controls.Add(this.txtorddesc);
            this.panel1.Controls.Add(this.txtord);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 427);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductDesc
            // 
            this.ProductDesc.HeaderText = " Description";
            this.ProductDesc.Name = "ProductDesc";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // price
            // 
            this.price.HeaderText = "Unit price";
            this.price.Name = "price";
            // 
            // Totalcost
            // 
            this.Totalcost.HeaderText = "Total Cost";
            this.Totalcost.Name = "Totalcost";
            // 
            // OrderProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "OrderProducts";
            this.Text = "OrderProducts";
            this.Load += new System.EventHandler(this.OrderProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdpro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtord;
        private System.Windows.Forms.TextBox txtorddesc;
        private System.Windows.Forms.DateTimePicker dtporddate;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.ComboBox cmbcustid;
        private System.Windows.Forms.ComboBox cbbsalesid;
        private System.Windows.Forms.DataGridView dgvOrdpro;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalcost;
    }
}