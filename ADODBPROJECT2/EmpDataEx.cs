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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ADODBPROJECT2
{
    public partial class EmpDataEx : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public EmpDataEx()
        {
            InitializeComponent();
        }
        private void EmpDataEx_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            adp = new SqlDataAdapter("select * from EMPDATA ", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Emp");
            dgvemp.DataSource = ds.Tables["Emp"];
        }
        private void dgvemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dgvemp.Rows.Count - 1; i++)
            //{
              //  bool isChecked = (bool)dgvemp.Rows[i].Cells[0].Value;
                //if (isChecked == true)
                //{
                //    eid = dgvemp.CurrentRow.Cells[1].Value.ToString();
                //}
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test.pdf", FileMode.Create));
            doc.Open();//Open Document to write
            Paragraph paragraph = new Paragraph("data Exported From DataGridview!");
            DataTable Emp = new DataTable();
            Emp.Columns.Add("empno", typeof(Int32));
            Emp.Columns.Add("ename", typeof(string));
            Emp.Columns.Add("job", typeof(string));
            Emp.Columns.Add("mgr", typeof(Int32));
            Emp.Columns.Add("hiredate", typeof(DateTime));
            Emp.Columns.Add("sal", typeof(Int32));
            Emp.Columns.Add("comm", typeof(Int32));
            Emp.Columns.Add("deptno", typeof(Int32));
            for (int i = 0; i < dgvemp.Rows.Count - 1; i++)
            {
                if (dgvemp.Rows[i].Cells[0].Value != null)
                {
                bool isChecked = (bool)dgvemp.Rows[i].Cells[0].Value;
                if (isChecked == true)
                {
                    DataRow r = Emp.NewRow();
                    r["empno"] = dgvemp.Rows[i].Cells[1].Value.ToString();
                    r["ename"] = dgvemp.Rows[i].Cells[2].Value.ToString();
                    r["job"] = dgvemp.Rows[i].Cells[3].Value.ToString();
                    r["mgr"] = dgvemp.Rows[i].Cells[4].Value.ToString();
                    r["hiredate"] = dgvemp.Rows[i].Cells[5].Value.ToString();
                    r["sal"] = dgvemp.Rows[i].Cells[6].Value.ToString();
                    r["comm"] = dgvemp.Rows[i].Cells[7].Value.ToString();
                    r["deptno"] = dgvemp.Rows[i].Cells[8].Value.ToString();
                    Emp.Rows.Add(r);
                }
                }
            }
            PdfPTable table = new PdfPTable(Emp.Columns.Count);
            //foreach (DataGridViewColumn column in dgvemp.Columns)
            //{
              //  PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
              //cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 180, 200);
              //  table.AddCell(cell);
            //}
            for(int j=1;j<=Emp.Columns.Count;j++)
            {
                table.AddCell(dgvemp.Columns[j].HeaderText);
            }
            for (int i = 0; i < Emp.Rows.Count; i++)
            {
                for (int j = 0; j < Emp.Columns.Count; j++)
                {
                    table.AddCell(Emp.Rows[i][j].ToString());

                }
            }
            doc.Add(table);
            doc.Close();
        }
    }
}
