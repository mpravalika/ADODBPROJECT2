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
    public partial class TriggerEx : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        
        public TriggerEx()
        {
            InitializeComponent();
        }

        private void TriggerEx_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //adp = new SqlDataAdapter("sp_DeleteEmp", con);
            adp = new SqlDataAdapter("sp_empdata", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtempno.Text));
            SqlParameter s = new SqlParameter("@Status", SqlDbType.NVarChar, 15);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());
        }
    }
}
