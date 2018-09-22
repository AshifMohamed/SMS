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
using WindowsFormsApplication4;

namespace _23
{
    public partial class shipa : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public shipa()
        {
            InitializeComponent();
        }

        private void shipa_Load(object sender, EventArgs e)
        {
            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "SELECT Payment_num,date_of_payment,reg_num,academic_year,semes_grade,semes,fees_tobe_paid,payment_amount,balance,fine_amt FROM semester_fees WHERE balance > 0";

            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "semester_fees");
            CrystalReport1 cs = new CrystalReport1();
            cs.SetDataSource(ds.Tables["semester_fees"]);
            crystalReportViewer1.ReportSource = cs;
            crystalReportViewer1.Show();
            conn.Close();
        }
    }
}
