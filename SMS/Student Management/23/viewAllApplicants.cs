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
    public partial class viewAllApplicants : Form
    {
        SqlConnection conn = DBAccess.GetConnection();
        public viewAllApplicants()
        {
            InitializeComponent();
        }

        private void viewAllApplicants_Load(object sender, EventArgs e)
        {
            displaylist();
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select applicant_id,applicant_name,admission_grade,applicant_contact,place_id,applicant_email from applicant", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = item[0].ToString();
                metroGrid1.Rows[n].Cells[1].Value = item[1].ToString();
                metroGrid1.Rows[n].Cells[2].Value = item[2].ToString();
                metroGrid1.Rows[n].Cells[3].Value = item[3].ToString();
                metroGrid1.Rows[n].Cells[4].Value = item[4].ToString();
                metroGrid1.Rows[n].Cells[5].Value = item[5].ToString();

            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
