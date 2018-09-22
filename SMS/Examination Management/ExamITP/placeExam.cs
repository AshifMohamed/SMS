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
    public partial class placeExam : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        placeExamTable pe1;

        public placeExam(placeExamTable pe2)
        {
            InitializeComponent();
            pe1 = pe2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.placeExam_FormClosing);
        }


        private void validateMarks(String textBox1, String textBox2)
        {
            int value1, value2;

            bool isConverted1 = Int32.TryParse(textBox1.Trim(), out value1);
            bool isConverted2 = Int32.TryParse(textBox2.Trim(), out value2);


            if (value1 < 0 || value1 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox6.Text = String.Empty;

            }
            else if (value2 < 0 || value2 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox9.Text = String.Empty;
            }
            else
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            

            try
            {
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                this.validateMarks(metroTextBox8.Text.ToString(), metroTextBox7.Text.ToString());
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox10.Text == "" || metroComboBox1.Text == "" || metroComboBox5.Text == "" || metroComboBox3.Text == "" || metroTextBox5.Text == "" || metroTextBox4.Text == "" || dateTimePicker1.Text == "" || metroTextBox9.Text == "" || metroTextBox6.Text == "" || metroTextBox8.Text == "" || metroTextBox7.Text == "")
                {
                    MessageBox.Show("Fill the empty fields");
                }
                
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into placeExam(Fname,Mname,Lname,Gender,Age,DOB,Religion,Nationality,Address,LandNo,MobNo,email,Grade,Interview,Written) values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroComboBox1.Text + "','" + metroComboBox5.Text + "','" + theDate + "','" + metroComboBox3.Text + "','" + metroTextBox10.Text + "','" + metroTextBox5.Text + "','" + metroTextBox4.Text + "','" + metroTextBox9.Text + "','" + metroTextBox6.Text + "','" + metroComboBox4.Text + "','" + metroTextBox8.Text + "','" + metroTextBox7.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Placement Exam Details are entered");
                    this.Close();
                    placeExamTable a = new placeExamTable();
                    a.Show();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                this.validateMarks(metroTextBox8.Text.ToString(), metroTextBox7.Text.ToString());
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox10.Text == "" || metroComboBox1.Text == "" || metroComboBox5.Text == "" || theDate == "" || metroComboBox3.Text == "" || metroTextBox5.Text == "" || metroTextBox4.Text == "" || metroTextBox9.Text == "" || metroTextBox6.Text == "" || metroTextBox8.Text == "" || metroTextBox7.Text == "")
                {
                    MessageBox.Show("Fill the empty fields");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update placeExam set Fname='" + metroTextBox1.Text + "',Mname='" + metroTextBox2.Text + "',Lname='" + metroTextBox3.Text + "',Gender='" + metroComboBox1.Text + "',Age='" + metroComboBox5.Text + "',DOB='" + theDate + "',Religion='" + metroComboBox3.Text + "',Nationality='" + metroTextBox10.Text + "',Address='" + metroTextBox5.Text + "',LandNo='" + metroTextBox4.Text + "',MobNo='" + metroTextBox9.Text + "',email='" + metroTextBox6.Text + "',Grade='" + metroComboBox4.Text + "',Interview='" + metroTextBox8.Text + "',Written='" + metroTextBox7.Text + "' where placeID='" + metroLabel21.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Placement Exam Details are updated");
                    this.Close();
                    placeExamTable a = new placeExamTable();
                    a.Show();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            placeExamTable a = new placeExamTable();
            this.Hide();
            a.Show();
        }

        private void placeExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            pe1.refreshPE();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string fname = metroTextBox1.Text;

            if (ValidateExam.isLetter(fname))
            {
                errorProvider1.SetError(metroTextBox1, "Can contain only letters");
                
            }
            else
            {
                errorProvider1.Clear();
                
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            string mname = metroTextBox2.Text;

            if (ValidateExam.isLetter(mname))
            {
                errorProvider2.SetError(metroTextBox2, "Can contain only letters");
                
            }
            else
            {
                errorProvider2.Clear();
                
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            string lname = metroTextBox3.Text;

            if (ValidateExam.isLetter(lname))
            {
                errorProvider3.SetError(metroTextBox3, "Can contain only letters");
                
            }
            else
            {
                errorProvider3.Clear();
                
            }
        }

        private void metroTextBox10_TextChanged(object sender, EventArgs e)
        {
            string nationality = metroTextBox10.Text;

            if (ValidateExam.isLetter(nationality))
            {
                errorProvider4.SetError(metroTextBox10, "Can contain only letters");
                
            }
            else
            {
                errorProvider4.Clear();
                
            }
        }

        private void metroTextBox8_TextChanged(object sender, EventArgs e)
        {
            string m1 = metroTextBox8.Text;

            if (ValidateExam.isNumber(m1))
            {
                errorProvider5.SetError(metroTextBox8, "can contain only numbers");
                
            }
            else
            {
                errorProvider5.Clear();
                
            }
        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            string m2 = metroTextBox7.Text;

            if (ValidateExam.isNumber(m2))
            {
                errorProvider6.SetError(metroTextBox7, "can contain only numbers");
                
            }
            else
            {
                errorProvider6.Clear();
                
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void placeExam_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            string m2 = metroTextBox6.Text;

            if (ValidateExam.EmailIsValid(m2))
            {
                
                errorProvider7.Clear();
            }
            else
            {
                errorProvider7.SetError(metroTextBox6, "Enter correct E-mail");

            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            string con1 = metroTextBox4.Text;
            int length = Convert.ToInt32(metroTextBox4.Text.Length);
            if((ValidateExam.isNumber(con1))||(length != 10))
            {
                errorProvider8.SetError(metroTextBox4, "Enter numbers with 10 digits");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void metroTextBox9_TextChanged(object sender, EventArgs e)
        {
            string con1 = metroTextBox9.Text;
            int length = Convert.ToInt32(metroTextBox9.Text.Length);
            if ((ValidateExam.isNumber(con1)) || (length != 10))
            {
                errorProvider9.SetError(metroTextBox9, "Enter numbers with 10 digits");
            }
            else
            {
                errorProvider9.Clear();
            }
        }
    }
}
