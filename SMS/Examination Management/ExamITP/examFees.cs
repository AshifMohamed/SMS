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
using System.Net;
using System.Net.Mail;
using ExamITP.Properties;
using WindowsFormsApplication4;

namespace ExamITP
{
    public partial class examFees : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        
        public examFees()
        {
            InitializeComponent();
        }

        public void organize()
        {
            metroGrid1.Columns[0].HeaderText = "Admission No";
            metroGrid1.Columns[1].HeaderText = "First Name";
            metroGrid1.Columns[2].HeaderText = "Last Name";
            metroGrid1.Columns[3].HeaderText = "Grade";
            metroGrid1.Columns[4].HeaderText = "Address";
            metroGrid1.Columns[5].HeaderText = "Contact";
            metroGrid1.Columns[6].HeaderText = "E-mail";
            metroGrid1.Columns[7].HeaderText = "Exam Fee";
            metroGrid1.Columns[8].HeaderText = "Late Payement";
            metroGrid1.Columns[9].HeaderText = "Payement";
            metroGrid1.Columns[10].HeaderText = "Late Fee";
            metroGrid1.Columns[11].HeaderText = "Total Fee";
        }
        public void refreshI()
        {

            string query1 = "select * from exFees1 order by AdmissionNo";
            
            SqlCommand cmd1 = new SqlCommand(query1, con);
            
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            
            DataTable dt1 = new DataTable();
            
            da1.Fill(dt1);
            
            metroGrid1.DataSource = dt1;

            metroGrid1.Columns[1].HeaderText = "First Name";
            
        
        }

        public void refresh()
        {
            string query = "insert into exFees1(AdmissionNo,Fname,surname,admissionGrade,address,contact,email) select stud_regis.AdmissionNo,stud_regis.Fname,stud_regis.surname,stud_regis.admissionGrade,stud_regis.address,stud_regis.contact,stud_regis.email from stud_regis  WHERE NOT EXISTS(select AdmissionNo from exFees1 where stud_regis.AdmissionNo=exFees1.AdmissionNo) ;";
            string query1 = "select * from exFees1 order by AdmissionNo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            da.Fill(dt);
            da1.Fill(dt1);
            metroGrid1.DataSource = dt;
            metroGrid1.DataSource = dt1;
            
           
        
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddFees a1 = new AddFees(this);
            if (metroGrid1.CurrentRow != null)
            {
                a1.metroLabel10.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                a1.metroLabel11.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                a1.metroLabel12.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                a1.metroLabel13.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                a1.metroLabel14.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                a1.metroComboBox1.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
                a1.metroButton2.Enabled = false;
                a1.Show();
            }
            else
            {
                MessageBox.Show("Nothing to edit");
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            refresh();
            organize();
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string searchValue = metroTextBox1.Text;

            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Enter correct Admission No ");
            }
        }

        private void examFees_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT * FROM exFees1 ORDER BY AdmissionNo;";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            metroGrid1.DataSource = data;
            organize();
            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedRows.Count > 0)
            {
                int selectedIndex = metroGrid1.SelectedRows[0].Index;

                
                string AdmissionNo = metroGrid1[0, selectedIndex].Value.ToString();
                string sql = "DELETE FROM exFees1 WHERE AdmissionNo = @AdmissionNo";

                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = con;
                deleteRecord.CommandType = CommandType.Text;
                deleteRecord.CommandText = sql;

                SqlParameter RowParameter = new SqlParameter();
                RowParameter.ParameterName = "@AdmissionNo";
                RowParameter.SqlDbType = SqlDbType.VarChar;
                RowParameter.IsNullable = false;
                RowParameter.Value = AdmissionNo;

                deleteRecord.Parameters.Add(RowParameter);

                deleteRecord.Connection.Open();

                deleteRecord.ExecuteNonQuery();

                deleteRecord.Connection.Close();

                refresh();
                organize();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if(metroGrid1.CurrentRow.Cells[9].Value.ToString() == "Paid")
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else if (metroGrid1.CurrentRow.Cells[9].Value.ToString() != "Paid")
            {
                MessageBox.Show("Student didn't pay.");
            }
            else
            {

            }
            /*ReceiptEF a1 = new ReceiptEF();
            if (metroGrid1.CurrentRow != null)
            {
                a1.metroLabel10.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                a1.metroLabel11.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                a1.metroLabel12.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                a1.metroLabel13.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                a1.metroLabel14.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                a1.metroLabel7.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString(); 
                a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
                a1.metroLabel18.Text = DateTime.Now.ToString("yyyy-MM-dd");
                a1.metroLabel20.Text = DateTime.Now.ToString("HH:mm");
                a1.Show();
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }*/


        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (metroGrid1.CurrentRow != null)
            {
                if (metroGrid1.CurrentRow.Cells[9].Value.ToString() == "Paid")
                {
                    metroButton6.Enabled = true;
                }
                else if (metroGrid1.CurrentRow.Cells[9].Value.ToString() != "Paid")
                {
                    metroButton6.Enabled = false;
                }
                else
                {

                }
            }*/
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells[9].Value.ToString() != "Paid")
            {
                mailEF a = new mailEF();
                if (metroGrid1.CurrentRow != null)
                {
                    a.metroLabel5.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                    a.Show();
                }
            }
            else
            {
                MessageBox.Show("Student has paid the Examination Fee.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.logo;
            e.Graphics.DrawImage(image, 30, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Admission No: " + metroGrid1.CurrentRow.Cells[0].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("First Name: " + metroGrid1.CurrentRow.Cells[1].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Last Name: " + metroGrid1.CurrentRow.Cells[2].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Grade: " + metroGrid1.CurrentRow.Cells[3].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            e.Graphics.DrawString("Late Payement", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            e.Graphics.DrawString("Examination Fees", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(270, 290));
            e.Graphics.DrawString("Late Fee", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, 290));
            e.Graphics.DrawString("Total Payement", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(660, 290));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 303));

            int ypos = 330;

            
            e.Graphics.DrawString(metroGrid1.CurrentRow.Cells[8].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, ypos ));
            e.Graphics.DrawString(metroGrid1.CurrentRow.Cells[7].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(270, ypos ));
            e.Graphics.DrawString(metroGrid1.CurrentRow.Cells[10].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, ypos ));
            e.Graphics.DrawString(metroGrid1.CurrentRow.Cells[11].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(660, ypos ));


          
            ypos = ypos + 30;

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

            e.Graphics.DrawString("_________________", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, ypos+60));
            e.Graphics.DrawString("Principal Signature", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, ypos + 90));
            

        }
    }
}
