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
    public partial class Functionex : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public Functionex()
        {
            InitializeComponent();
        }

        private void Functionex_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adp = new SqlDataAdapter("select * from dbo.fn_first(@dno)", con);
            //adp = new SqlDataAdapter("Select * from dbo.fn_second()", con);
            adp = new SqlDataAdapter("sp_gross", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adp.SelectCommand.Parameters.AddWithValue("@dno",int.Parse(txtdeptno.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dgvdata.DataSource = ds.Tables["E"];

        }
    }
}
