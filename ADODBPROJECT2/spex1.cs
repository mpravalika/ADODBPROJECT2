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
    public partial class spex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public spex1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-00PPEVI");

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en",txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@g", cbbgender.Text);
            adp.SelectCommand.Parameters.AddWithValue("@db", dtpdob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            SqlParameter R= new SqlParameter("@Result", SqlDbType.NVarChar,100);
            R.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(R.Value.ToString());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updateemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@db", dtpdob.Text);
            SqlParameter R1 = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            R1.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R1);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(R1.Value.ToString());
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_deleteemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
            SqlParameter R2 = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            R2.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R2);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(R2.Value.ToString());
        }
    }
}
