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
    public partial class sp_cursorex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public sp_cursorex1()
        {
            InitializeComponent();
        }

        private void sp_cursorex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void txtupdate_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_CURSORex", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
                SqlParameter s = new SqlParameter("@Status", SqlDbType.NVarChar, 15);
                s.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(s);
                ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show(s.Value.ToString());
            }
            catch(FormatException  E)
            {
                MessageBox.Show("enetr valid deptno");
            }
        }
    }
}
