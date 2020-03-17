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
    public partial class spex2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public spex2()
        {
            InitializeComponent();
        }

        private void spex2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void txtempno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Extractdata", con);
            adp.SelectCommand.CommandType= CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            SqlParameter s = new SqlParameter("@Status", SqlDbType.NVarChar, 15);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = null;
            try
            {
                R = ds.Tables["E"].Rows[0];
                txtename.Text = R[1].ToString();
                txtjob.Text = R[2].ToString();
                txtmgr.Text = R[3].ToString();
                dtphiredate.Text = R[4].ToString();
                txtsal.Text = R[5].ToString();
                txtcomm.Text = R[6].ToString();
                cmbdeptno.Text = R[7].ToString();
                
            }
            catch(NullReferenceException E)
            {
                clear();
                MessageBox.Show("empno doesnt exist"); 
            }


        }
        private void clear()
        {
            txtename.Text = " ";
            txtjob.Text = " ";
            txtmgr.Text = " ";
            dtphiredate.Text = "";
            txtsal.Text = " ";
            txtcomm.Text = " ";
            cmbdeptno.Text = " ";
            txtincr.Text = " ";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updatedata", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incrPer", txtincr.Text);
            SqlParameter p = new SqlParameter("@Status", SqlDbType.NVarChar, 15);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }
    }
}
