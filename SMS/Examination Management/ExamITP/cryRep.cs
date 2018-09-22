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

namespace ExamITP
{
    public partial class cryRep : Form
    {
        SqlConnection con = DBAccess.GetConnection();

        public cryRep()
        {
            InitializeComponent();
        }

        private void cryRep_Load(object sender, EventArgs e)
        {
            
            
                SqlCommand command1 = con.CreateCommand();
                command1.Connection = con;
                command1.CommandType = CommandType.Text;
                command1.CommandText = "SELECT * FROM yearEnd order by admissionGrade";
                SqlDataAdapter da1 = new SqlDataAdapter(command1);

                DataSet ds1 = new DataSet();

                da1.Fill(ds1, "yearEnd");

                CrystalReport1 cs1 = new CrystalReport1();

                cs1.SetDataSource(ds1.Tables["yearEnd"]);

                crystalReportViewer1.ReportSource = cs1;

                crystalReportViewer1.Show();
                con.Close();
            
        }
    }
}
