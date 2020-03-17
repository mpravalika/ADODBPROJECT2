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
    public partial class FormEx : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        string pid;
        public FormEx(string pid)
        {
            this.pid = pid;
            InitializeComponent();
        }
        private void FormEx_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            adp = new SqlDataAdapter("select * from Productdetails where ProductID=@pid", con);
            adp.SelectCommand.Parameters.AddWithValue("@pid",pid);
            DataSet ds = new DataSet();
            adp.Fill(ds,"P");
            label1.Text = ds.Tables[0].Rows[0][0].ToString();
            label2.Text = ds.Tables[0].Rows[0][1].ToString();
            label3.Text = ds.Tables[0].Rows[0][2].ToString();
        }
    }
}
