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
    public partial class applicantForm : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public applicantForm()
        {
            InitializeComponent();
        }

        SqlDataReader dr;

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtappname.Text != "" & txtadmissiongrade.Text != "" & txtappcontact.Text != "" & txtplaceid.Text != "" & txtappemail.Text != "")
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO  applicant (applicant_name,admission_grade,applicant_contact,place_id,applicant_email) VALUES (@2,@3,@4,@5,@6);", conn);

                    
                    cmd.Parameters.AddWithValue("@2", txtappname.Text);
                    cmd.Parameters.AddWithValue("@3", txtadmissiongrade.Text);
                    cmd.Parameters.AddWithValue("@4", txtappcontact.Text);
                    cmd.Parameters.AddWithValue("@5", txtplaceid.Text);
                    cmd.Parameters.AddWithValue("@6", txtappemail.Text);



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();


                    MessageBox.Show("The applicant entry was successfully added.");
                }
                else
                {
                    MessageBox.Show("One or more fields are empty");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }

        }

        void reset()
        {
           
            txtappname.Text = "";
            txtadmissiongrade.SelectedIndex = -1;
            txtappcontact.Text = "";
            txtplaceid.Text = "";
            txtappemail.Text = "";


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            
        }

        private void applicantForm_Load(object sender, EventArgs e)
        {
            txtadmissiongrade.Items.Add("1");
            txtadmissiongrade.Items.Add("2");
            txtadmissiongrade.Items.Add("3");
            txtadmissiongrade.Items.Add("4");
            txtadmissiongrade.Items.Add("5");
            txtadmissiongrade.Items.Add("6");
            txtadmissiongrade.Items.Add("7");
            txtadmissiongrade.Items.Add("8");
            txtadmissiongrade.Items.Add("9");
            txtadmissiongrade.Items.Add("10");
            txtadmissiongrade.Items.Add("11");
            txtadmissiongrade.Items.Add("12");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE applicant SET applicant_name=@2,admission_grade=@3,applicant_contact=@4,place_id=@5,applicant_email=@6 WHERE applicant_id= @25", conn);
               
                cmd.Parameters.AddWithValue("@2", txtappname.Text);
                cmd.Parameters.AddWithValue("@3", txtadmissiongrade.Text);
                cmd.Parameters.AddWithValue("@4", txtappcontact.Text);
                cmd.Parameters.AddWithValue("@5", txtplaceid.Text);
                cmd.Parameters.AddWithValue("@6", txtappemail.Text);
                cmd.Parameters.AddWithValue("@25", metroTextBox1.Text);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Applicant Information Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                reset();
            }
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            viewAllApplicants dora = new viewAllApplicants();
            dora.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT applicant_id,applicant_name,admission_grade,applicant_contact,place_id,applicant_email FROM  applicant where applicant_id = @1", conn);
                cmd.Parameters.AddWithValue("@1", metroTextBox1.Text);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {

                        metroTextBox1.Text = dr["applicant_id"].ToString();
                        txtappname.Text = dr["applicant_name"].ToString();
                         txtadmissiongrade.Text= dr["admission_grade"].ToString();
                        txtappcontact.Text = dr["applicant_contact"].ToString();
                        txtplaceid.Text= dr["place_id"].ToString();
                        txtappemail.Text = dr["applicant_email"].ToString();
                        


                    }




                }

                dr.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                // reset();
            }       

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Applicant entry will be deleted. Do you want to proceed?", "Delete Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("delete from applicant where applicant_id=@a", conn);
                    cmd.Parameters.AddWithValue("@a", metroTextBox1.Text);
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    reset();
                    if (a > 0)
                    {
                        MessageBox.Show("Applicant Entry Deleted");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                reset();
            }
        }

        private void txtappname_TextChanged(object sender, EventArgs e)
        {
            string appnam = txtappname.Text;
            if (studentValidate.isNumber(appnam))
            {
                errorProvider1.SetError(txtappname, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtappcontact_TextChanged(object sender, EventArgs e)
        {
            string cont = txtappcontact.Text;
            int length = Convert.ToInt32(txtappcontact.Text.Length);
            if ((studentValidate.isLetter(cont)) || (length != 10))
            {
                errorProvider1.SetError(txtappcontact, "can contain only 10 digits");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string sear = metroTextBox1.Text;
            if (studentValidate.IsAllLettersOrDigits(sear))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(metroTextBox1, "can contain only letters and digits");
                metroTile1.Enabled = false;
            }
        }

        private void txtappemail_TextChanged(object sender, EventArgs e)
        {
            string emai = txtappemail.Text;
            if (studentValidate.EmailIsValid(emai))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtappemail, "invalid email address");
                metroTile1.Enabled = false;
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


       
  
     

    }
}
