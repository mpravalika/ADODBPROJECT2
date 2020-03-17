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
    public partial class Functionex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Functionex1()
        {
            InitializeComponent();
        }

        private void Functionex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select Empno,Ename, dbo.fn_Date(@hr) from EMPDATA where HIREDATE=@hr", con);
            adp.SelectCommand.Parameters.AddWithValue("@hr", DateTime.Parse(txthiredate.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dgvdata.DataSource = ds.Tables["E"];

        }
    }
}
