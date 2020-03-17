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
    public partial class sp_cursorex2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public sp_cursorex2()
        {
            InitializeComponent();
        }
        private void sp_cursorex2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorex2", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            ds = new DataSet();
            adp.Fill(ds,"E");
            dgvdata.DataSource = ds.Tables["E"];
        }
    }
}
