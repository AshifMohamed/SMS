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
using WindowsFormsApplication4;

namespace ITPLibrary
{
    public partial class RegisterStudent : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = DBAccess.GetConnection();
        public RegisterStudent()
        {
            InitializeComponent();
        }
        SqlDataReader dr;

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            displaylist();
         
        }

        public void showStudentDetail()
        {

            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  stud_regis where AdmissionNo = @1", Con);
                cmd.Parameters.AddWithValue("@1", admisNum.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        admisNum.Text = dr["AdmissionNo"].ToString();
                        fname.Text = dr["fname"].ToString();
                        gender.Text = dr["gender"].ToString();
                        tphone.Text = dr["contact"].ToString();
                        email.Text = dr["email"].ToString();


                    }

                }

                // dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }




        }

        private void admisNum_Enter(object sender, EventArgs e)
        {
            showStudentDetail();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (admisNum.Text != "" & fname.Text != "" & gender.Text != "" & tphone.Text != "" & email.Text != "" & dtpjoin.Text != "" & dtpexpiry.Text != "")
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Register_Student (AdmissionNumber, FullName,Gender,  TelephoneNumber,Email,JoiningDate,ExpiryDate) VALUES (@1,@2,@3,@4,@5,@6,@7);", Con);
                    //  DateTime enteredDate = DateTime.Parse(dtpdob.Text);
                    cmd.Parameters.AddWithValue("@1", admisNum.Text);
                    cmd.Parameters.AddWithValue("@2", fname.Text);
                    cmd.Parameters.AddWithValue("@3", gender.Text);
                    // cmd.Parameters.AddWithValue("@4", enteredDate);
                    //  cmd.Parameters.AddWithValue("@5", address.Text);
                    cmd.Parameters.AddWithValue("@4", tphone.Text);
                    cmd.Parameters.AddWithValue("@5", email.Text);
                    cmd.Parameters.AddWithValue("@6", dtpjoin.Text);
                    cmd.Parameters.AddWithValue("@7", dtpexpiry.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    displaylist();
                    reset();




                    MessageBox.Show("New Student has been added to the Library.");

                }
                else
                    MessageBox.Show("one or more field is empty");

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Cannot Register. Already a member ");
                Con.Close();
            }
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Register_Student", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvregStudent.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvregStudent.Rows.Add();
                dgvregStudent.Rows[n].Cells[0].Value = item[0].ToString();
                dgvregStudent.Rows[n].Cells[1].Value = item[1].ToString();
                dgvregStudent.Rows[n].Cells[2].Value = item[2].ToString();
                dgvregStudent.Rows[n].Cells[3].Value = item[3].ToString();
                dgvregStudent.Rows[n].Cells[4].Value = item[4].ToString();
                dgvregStudent.Rows[n].Cells[5].Value = item[5].ToString();
                dgvregStudent.Rows[n].Cells[6].Value = item[6].ToString();
                //    dgvregStudent.Rows[n].Cells[7].Value = item[7].ToString();
                //  dgvregStudent.Rows[n].Cells[8].Value = item[8].ToString();

            }

        }


        public void reset()
        {
            admisNum.Text = "";
            fname.Text = "";
            gender.SelectedIndex = -1;
            //         address.Text = "";
            tphone.Text = "";
            email.Text = "";

        }

        private void deleteregstud_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be Erased. do you want to proceed? ", "Delete Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from Register_student where AdmissionNumber=@1", Con);
                    cmd.Parameters.AddWithValue("@1", admisNum.Text);
                    Con.Open();

                    int a = cmd.ExecuteNonQuery();
                    displaylist();
                    reset();

                    if (a > 0)
                    {
                        MessageBox.Show("Data Deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void dgvregStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void admisNum_KeyDown(object sender, KeyEventArgs e)
        {
            showStudentDetail();
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            string fnam = fname.Text;
            if (BookRegValidation.isNumber(fnam))
            {
                errorProvider1.SetError(fname, "can contain only letters");
                RegStd.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                RegStd.Enabled = true;


            }
        }

        private void EmailBt_Click(object sender, EventArgs e)
        {
            Email em = new Email();
            em.Show();


        }



        /*public void checkExpirydate();
        {
            
        }*/




        private void dgvregStudent_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /* foreach (DataGridViewRow row in dgvregStudent.Rows) 
             if (Convert.ToInt32(row.Cells["borrow_date"].Value) < Convert.ToInt32(row.Cells["return_date"].Value)) 
              {
                  row.DefaultCellStyle.BackColor = Color.Red; 
              }*/
        }

        private void dgvregStudent_MouseClick(object sender, MouseEventArgs e)
        {
            admisNum.Text = dgvregStudent.SelectedRows[0].Cells[0].Value.ToString();
            fname.Text = dgvregStudent.SelectedRows[0].Cells[1].Value.ToString();
            gender.Text = dgvregStudent.SelectedRows[0].Cells[2].Value.ToString();
            // address.Text = dgvregStudent.SelectedRows[0].Cells[3].Value.ToString();
            tphone.Text = dgvregStudent.SelectedRows[0].Cells[3].Value.ToString();
            email.Text = dgvregStudent.SelectedRows[0].Cells[4].Value.ToString();


            if (admisNum.Text == "" & fname.Text == "" & gender.Text == "" & tphone.Text == "" & email.Text == "")
            {
                MessageBox.Show("One ore more field is empty.");

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            admisNum.Text = "";
            fname.Text = "";
            gender.SelectedIndex = -1;
            tphone.Text = "";
            email.Text = "";
            DateTime dtpjoin = DateTime.Today;
            DateTime dtpexpiry = DateTime.Today;
        }

        private void admisNum_TextChanged(object sender, EventArgs e)
        {
            string str = admisNum.Text;
            string let = new string(str.Take(2).ToArray());
         //   string result = new string(str.Take(5).ToArray());   
        //    string let = str.Substring(0,2);
         //   string result = str.Substring(2,5);

            if (BookRegValidation.isNumber(let) )//|| BookRegValidation.isNumber(result) )
            {
                errorProvider1.SetError(admisNum, "Enter a Valid Admission Number starts with WS");
                RegStd.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                RegStd.Enabled = true;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
