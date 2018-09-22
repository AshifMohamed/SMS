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
    public partial class AddMarksG10 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        examProcess ep1;

        public AddMarksG10(examProcess ep2)
        {
            InitializeComponent();
            ep1 = ep2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMarksG10_FormClosing);
        }

        private void validateMarks(String textBox1, String textBox2, String textBox3, String textBox4, String textBox5)
        {
            int value1, value2, value3, value4, value5;

            bool isConverted1 = Int32.TryParse(textBox1.Trim(), out value1);
            bool isConverted2 = Int32.TryParse(textBox2.Trim(), out value2);
            bool isConverted3 = Int32.TryParse(textBox3.Trim(), out value3);
            bool isConverted4 = Int32.TryParse(textBox4.Trim(), out value4);
            bool isConverted5 = Int32.TryParse(textBox5.Trim(), out value5);

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
            else
            {

            }
        }

        public void PassValue(string strValue1, string strValue2)
        {
            
            metroLabel6.Text = strValue1;
            metroLabel7.Text = strValue2;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.validateMarks(metroTextBox1.Text.ToString(), metroTextBox2.Text.ToString(), metroTextBox3.Text.ToString(), metroTextBox4.Text.ToString(), metroTextBox5.Text.ToString());
                if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "" || metroTextBox5.Text == "")
                {
                    MessageBox.Show("Fill the empty fields");
                }
                {
                    int a1 = Convert.ToInt32(metroTextBox1.Text);
                    int a2 = Convert.ToInt32(metroTextBox2.Text);
                    int a3 = Convert.ToInt32(metroTextBox3.Text);
                    int a4 = Convert.ToInt32(metroTextBox4.Text);
                    int a5 = Convert.ToInt32(metroTextBox5.Text);



                    float final = a1 + a2 + a3 + a4 + a5;
                    float average = final / 5;
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
                cmd.CommandText = "update LonGTerm1 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', OLopt1='" + metroTextBox3.Text + "', OLopt2='" + metroTextBox4.Text + "', OLopt3='" + metroTextBox5.Text + "', Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
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
                cmd.CommandText = "update LonGTerm2 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', OLopt1='" + metroTextBox3.Text + "', OLopt2='" + metroTextBox4.Text + "', OLopt3='" + metroTextBox5.Text + "', Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
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
                cmd.CommandText = "update LonGTerm3 set Term='" + metroLabel7.Text + "', English='" + metroTextBox1.Text + "', Mathematics='" + metroTextBox2.Text + "', OLopt1='" + metroTextBox3.Text + "', OLopt2='" + metroTextBox4.Text + "', OLopt3='" + metroTextBox5.Text + "', Total='" + metroLabel17.Text + "', Average='" + metroLabel18.Text + "' where AdmissionNo='" + metroLabel15.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Marks are entered");
                this.Close();
            }
            else
            {

            }
        }

        private void AddMarksG10_FormClosing(object sender, FormClosingEventArgs e)
        {
            ep1.refreshExProcess();
        }

        private void AddMarksG10_Load(object sender, EventArgs e)
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
            string m2 = metroTextBox2.Text;

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
            string m4 = metroTextBox1.Text;

            if (ValidateExam.isNumber(m4))
            {
                errorProvider4.SetError(metroTextBox4, "can contain only numbers");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroButton1.Enabled = true;

            }
        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string m5 = metroTextBox5.Text;

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
    }
}
