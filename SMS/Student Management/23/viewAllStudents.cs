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
using Excel = Microsoft.Office.Interop.Excel;
using WindowsFormsApplication4;

namespace _23
{
    public partial class viewAllStudents : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public viewAllStudents()
        {
            InitializeComponent();
        }

       

        private void viewAllStudents_Load(object sender, EventArgs e)
        {

            displaylist();
        }


        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select AdmissionNo,dateOfReg,fname, dob, admissionGrade, gender, contact,email from stud_regis", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            viewstudents.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = viewstudents.Rows.Add();
                viewstudents.Rows[n].Cells[0].Value = item[0].ToString();
                viewstudents.Rows[n].Cells[1].Value = item[1].ToString();
                viewstudents.Rows[n].Cells[2].Value = item[2].ToString();
                viewstudents.Rows[n].Cells[3].Value = item[3].ToString();
                viewstudents.Rows[n].Cells[4].Value = item[4].ToString();
                viewstudents.Rows[n].Cells[5].Value = item[5].ToString();
                viewstudents.Rows[n].Cells[6].Value = item[6].ToString();
                viewstudents.Rows[n].Cells[7].Value = item[7].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
     

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
        }
           

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void viewstudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void viewstudents_MouseClick(object sender, MouseEventArgs e)
        {
          
        
        }

        private void viewstudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

    }
}
