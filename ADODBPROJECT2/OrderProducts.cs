using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADODBPROJECT2
{
    public partial class OrderProducts : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public OrderProducts()
        {
            InitializeComponent();
        }

        private void OrderProducts_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for displaying orderid 
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds,"c");
            txtord.Text =(int.Parse(ds.Tables["c"].Rows[0][0].ToString())+1).ToString();
            //code for displaying salesman id in drop down
            adp = new SqlDataAdapter("select Salesmanid,SalesManName from Salesmandetails", con);
            adp.Fill(ds, "s");
            cbbsalesid.DataSource = ds.Tables["s"];
            cbbsalesid.DisplayMember = "SalesManName";
            cbbsalesid.ValueMember = "Salesmanid";
            //code for displaying customer id in drop down
            adp = new SqlDataAdapter("select CustomerID,Customername from Customerdetails", con);
            adp.Fill(ds, "D");
            cmbcustid.DataSource = ds.Tables["D"];
            cmbcustid.DisplayMember = "Customername";
            cmbcustid.ValueMember = "CustomerID";
            panel1.Visible = true;

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_OrderProducts", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid", int.Parse(txtord.Text));
            adp.SelectCommand.Parameters.AddWithValue("@orddesc",txtorddesc.Text );
            adp.SelectCommand.Parameters.AddWithValue("@orddate",DateTime.Parse(dtporddate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@disc", int.Parse(txtdisc.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custid", cmbcustid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid", cbbsalesid.SelectedValue);
            
            DataTable Mytable = new DataTable();
            Mytable.Columns.Add("OrderID", typeof(string));
            Mytable.Columns.Add("ProductID", typeof(string));
            Mytable.Columns.Add("Qty", typeof(Int32));
            MessageBox.Show(dgvOrdpro.Rows.Count.ToString());//no. of records in grid(default 1 row in grid) 
            for(int i= 0; i < dgvOrdpro.Rows.Count-1;i++)
            {
                Mytable.Rows.Add(txtord.Text,dgvOrdpro.Rows[i].Cells[0].Value.ToString(),dgvOrdpro.Rows[i].Cells[2].Value.ToString());
            }
            SqlParameter p = new SqlParameter("@ord_pro", Mytable);//sending table to database
            p.SqlDbType= SqlDbType.Structured;//structure is used to send table
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show("Order Placed");
            panel1.Visible = false;
        }

        private void dgvOrdpro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOrdpro.CurrentCell.ColumnIndex.Equals(0))//for first column in grid
            {
                adp = new SqlDataAdapter("select ProductID from Productdetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "PID");
                //to populate combo box values in each row first column
                foreach(DataGridViewRow row in dgvOrdpro.Rows)//each row in data grid view
                {
                    //to convert dgv cell to combobox cell 
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource=ds.Tables["PID"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "ProductID";
                }

            }
        }
        private void dgvOrdpro_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdpro.CurrentRow.Cells[0].Value!=null)
            {
                if (!dgvOrdpro.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select * from Productdetails where ProductID=@P", con);
                    adp.SelectCommand.Parameters.AddWithValue("@P", dgvOrdpro.CurrentRow.Cells[0].Value);//current row 0th column value is picked
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "P");
                    dgvOrdpro.CurrentRow.Cells[1].Value = ds.Tables["P"].Rows[0][1];
                    dgvOrdpro.CurrentRow.Cells[3].Value = ds.Tables["P"].Rows[0][2];

                }
            }
        }

        private void dgvOrdpro_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdpro.CurrentRow.Cells[2].Value != null)
            {
                int q = int.Parse(dgvOrdpro.CurrentRow.Cells[2].Value.ToString());
                int p = int.Parse(dgvOrdpro.CurrentRow.Cells[3].Value.ToString());
                dgvOrdpro.CurrentRow.Cells[4].Value = q * p;

            }
        }
    }
}
