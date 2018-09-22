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
namespace _23
{
    public partial class Discipline : Form
    {
        SqlConnection conn = DBAccess.GetConnection();
        public Discipline()
        {
            InitializeComponent();
        }
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text != "" & metroTextBox2.Text != "" & metroDateTime1.Text != "" & metroComboBox1.Text != "" & metroTextBox3.Text != "" & richTextBox1.Text != "")
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO  discipline (stud_regno,name,date_of_incident,grade,teacher_in_charge,description) VALUES (@1,@2,@3,@4,@5,@6);", conn);


                    cmd.Parameters.AddWithValue("@1", metroTextBox1.Text);
                    cmd.Parameters.AddWithValue("@2", metroTextBox2.Text);
                    cmd.Parameters.AddWithValue("@3", metroDateTime1.Text);
                    cmd.Parameters.AddWithValue("@4", metroComboBox1.Text);
                    cmd.Parameters.AddWithValue("@5", metroTextBox3.Text);
                    cmd.Parameters.AddWithValue("@6", richTextBox1.Text);


                    cmd.ExecuteNonQuery();

                    conn.Close();


                    MessageBox.Show("The discipline entry was successfully added.");
                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show("This Student has been registered already.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(
                    "mameershahib@gmail.com", "ameer497191"); 

                MailMessage msg = new MailMessage();

                msg.To.Add(metroTextBox4.Text);
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Subject = metroTextBox5.Text;
                msg.Body = richTextBox2.Text;


                client.Send(msg);
                MessageBox.Show("Message succesfully sent to parent");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string a = metroTextBox1.Text;
            if (studentValidate.IsAllLettersOrDigits(a))
            {
                errorProvider1.Clear();
                button1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(metroTextBox1, "can contain only letters and digits");
                button1.Enabled = false;
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            string n = metroTextBox2.Text;
            if (studentValidate.isNumber(n))
            {
                errorProvider1.SetError(metroTextBox2, "can contain only letters");
                button1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;


            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            string n = metroTextBox3.Text;
            if (studentValidate.isNumber(n))
            {
                errorProvider1.SetError(metroTextBox3, "can contain only letters");
                button1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;


            }
        }

        private void Discipline_Load(object sender, EventArgs e)
        {

            metroComboBox1.Items.Add("4");
            metroComboBox1.Items.Add("5");
            metroComboBox1.Items.Add("6");
            metroComboBox1.Items.Add("7");
            metroComboBox1.Items.Add("8");
            metroComboBox1.Items.Add("9");
            metroComboBox1.Items.Add("10");
            metroComboBox1.Items.Add("11");
            metroComboBox1.Items.Add("12");

        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            showStudentDetail();
        }

        public void showStudentDetail()
        {

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  stud_regis where AdmissionNo = @1", conn);
                cmd.Parameters.AddWithValue("@1", metroTextBox1.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        metroTextBox2.Text = dr["fname"].ToString();

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
            }

        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            string emai = metroTextBox4.Text;
            if (studentValidate.EmailIsValid(emai))
            {
                errorProvider1.Clear();
                button2.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(metroTextBox4, "invalid email address");
                button2.Enabled = false;
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
