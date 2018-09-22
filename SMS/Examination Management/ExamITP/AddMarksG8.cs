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
    public partial class AddMarksG8 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        examProcess ep1;

        public AddMarksG8(examProcess ep2)
        {
            InitializeComponent();
            ep1 = ep2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMarksG8_FormClosing);
        }

        private void validateMarks(String textBox1, String textBox2, String textBox3, String textBox4, String textBox5, String textBox6, String textBox7, String textBox8)
        {
            int value1, value2, value3, value4, value5, value6, value7, value8;

            bool isConverted1 = Int32.TryParse(textBox1.Trim(), out value1);
            bool isConverted2 = Int32.TryParse(textBox2.Trim(), out value2);
            bool isConverted3 = Int32.TryParse(textBox3.Trim(), out value3);
            bool isConverted4 = Int32.TryParse(textBox4.Trim(), out value4);
            bool isConverted5 = Int32.TryParse(textBox5.Trim(), out value5);
            bool isConverted6 = Int32.TryParse(textBox6.Trim(), out value6);
            bool isConverted7 = Int32.TryParse(textBox7.Trim(), out value7);
            bool isConverted8 = Int32.TryParse(textBox8.Trim(), out value8);

            if (value1 < 0 || value1 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox1.Text = String.Empty;

            }
            else if (value2 < 0 || value2 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox2.Text = String.Empty;
            }
            else if (value3 < 0 || value3 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox3.Text = String.Empty;
            }
            else if (value4 < 0 || value4 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox4.Text = String.Empty;
            }
            else if (value5 < 0 || value5 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox5.Text = String.Empty;
            }
            else if (value6 < 0 || value6 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox6.Text = String.Empty;
            }
            else if (value7 < 0 || value7 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox7.Text = String.Empty;
            }
            else if (value8 < 0 || value8 > 100)
            {
                MessageBox.Show("Please enter value from 0-100");
                metroTextBox8.Text = String.Empty;
            }
            else
            {

            }
        }

        public void PassValue(string strValue1, string strValue2)
        {
            
            metroLabel6.Text = strValue1;
            metroLabel7.Text = strValue2;
        }

        private void AddMarksG8_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.validateMarks(metroTextBox1.Text.ToString(), metroTextBox2.Text.ToString(), metroTextBox3.Text.ToString(), metroTextBox4.Text.ToString(), metroTextBox5.Text.ToString(), metroTextBox6.Text.ToString(), metroTextBox7.Text.ToString(), metroTextBox8.Text.ToString());
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "" || metroTextBox5.Text == "" || metroTextBox6.Text == "")
                {
                    MessageBox.Show("Fill the empty fields");
                }
                else
                {
                    int a1 = Convert.ToInt32(metroTextBox1.Text);
                    int a2 = Convert.ToInt32(metroTextBox2.Text);
                    int a3 = Convert.ToInt32(metroTextBox3.Text);
                    int a4 = Convert.ToInt32(metroTextBox4.Text);
                    int a5 = Convert.ToInt32(metroTextBox5.Text);
                    int a6 = Convert.ToInt32(metroTextBox6.Text);
                    int a7 = Convert.ToInt32(metroTextBox7.Text);
                    int a8 = Convert.ToInt32(metroTextBox8.Text);


                    float final = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8;
                    float average = final / 8;
                    metroLabel17.Text = final.ToString();
                    metroLabel18.Text = average.ToString();
                    metroButton2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroLabel7.Text.ToString() == "Term1")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update LonGTerm1 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', Science='" + metroTextBox3.Text + "', ICT='" + metroTextBox4.Text + "', History='" + metroTextBox5.Text + "', Englit='" + metroTextBox6.Text + "',Commerce='" + metroTextBox7.Text + "',Language='" + metroTextBox8.Text + "',Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Marks are entered");
                this.Close();
            }
            else if (metroLabel7.Text.ToString() == "Term2")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update LonGTerm2 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', Science='" + metroTextBox3.Text + "', ICT='" + metroTextBox4.Text + "', History='" + metroTextBox5.Text + "', Englit='" + metroTextBox6.Text + "',Commerce='" + metroTextBox7.Text + "',Language='" + metroTextBox8.Text + "',Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Marks are entered");
                this.Close();
            }
            else if (metroLabel7.Text.ToString() == "Term3")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update LonGTerm3 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', Science='" + metroTextBox3.Text + "', ICT='" + metroTextBox4.Text + "', History='" + metroTextBox5.Text + "', Englit='" + metroTextBox6.Text + "',Commerce='" + metroTextBox7.Text + "',Language='" + metroTextBox8.Text + "',Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Marks are entered");
                this.Close();
            }
            else
            {

            }
        }

        private void AddMarksG8_FormClosing(object sender, FormClosingEventArgs e)
        {
            ep1.refreshExProcess();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string m1 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m1))
            {
                errorProvider1.SetError(metroTextBox1, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            string m2 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m2))
            {
                errorProvider2.SetError(metroTextBox2, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider2.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            string m3 = metroTextBox3.Text;

            if (ValidateExam.isNumber(m3))
            {
                errorProvider3.SetError(metroTextBox3, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider3.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            string m4 = metroTextBox4.Text;

            if (ValidateExam.isNumber(m4))
            {
                errorProvider4.SetError(metroTextBox4, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider4.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string m5 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m5))
            {
                errorProvider5.SetError(metroTextBox5, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider5.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            string m6 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m6))
            {
                errorProvider6.SetError(metroTextBox6, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider6.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            string m7 = metroTextBox7.Text;

            if (ValidateExam.isNumber(m7))
            {
                errorProvider7.SetError(metroTextBox7, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider7.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox8_TextChanged(object sender, EventArgs e)
        {
            string m8 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m8))
            {
                errorProvider8.SetError(metroTextBox8, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider8.Clear();
                metroButton1.Enabled = true;

            }
        }
    }
}
