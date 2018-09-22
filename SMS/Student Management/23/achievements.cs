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
    public partial class achievements : MetroFramework.Forms.MetroForm
    {

        SqlConnection conn = DBAccess.GetConnection();
        public achievements()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        private void achievements_Load(object sender, EventArgs e)
        {
            metroComboBox2.Items.Add("1");
            metroComboBox2.Items.Add("2");
            metroComboBox2.Items.Add("3");
            metroComboBox3.Items.Add("2016/2017");
            metroComboBox3.Items.Add("2017/2018");
            metroComboBox3.Items.Add("2018/2019");
            metroComboBox3.Items.Add("2019/2020");
            metroComboBox1.Items.Add("1");
            metroComboBox1.Items.Add("2");
            metroComboBox1.Items.Add("3");
            metroComboBox1.Items.Add("4");
            metroComboBox1.Items.Add("5");
            metroComboBox1.Items.Add("6");
            metroComboBox1.Items.Add("7");
            metroComboBox1.Items.Add("8");
            metroComboBox1.Items.Add("9");
            metroComboBox1.Items.Add("10");
            metroComboBox1.Items.Add("11");
            metroComboBox1.Items.Add("12");
            metroComboBox4.Items.Add("Sports");
            metroComboBox4.Items.Add("Studies");
            metroComboBox4.Items.Add("Extra Curricular");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text != "" & metroTextBox2.Text != "" & metroComboBox1.Text != "" & metroComboBox2.Text != "" & metroComboBox3.Text != "" & metroComboBox4.Text != "" & richTextBox1.Text != "")
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO  achievements (stud_regnum,name,grade,semester,academicyear,achievefield,achievedescription) VALUES (@2,@3,@4,@5,@6,@7,@8,);", conn);


                    cmd.Parameters.AddWithValue("@2", metroTextBox1.Text);
                    cmd.Parameters.AddWithValue("@3", metroTextBox2.Text);
                    cmd.Parameters.AddWithValue("@4", metroComboBox1.Text);
                    cmd.Parameters.AddWithValue("@5", metroComboBox2.Text);
                    cmd.Parameters.AddWithValue("@6", metroComboBox3.Text);
                    cmd.Parameters.AddWithValue("@7", metroComboBox4.Text);
                    cmd.Parameters.AddWithValue("@8", richTextBox1.Text);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    reset();
                    MessageBox.Show("The student's achievement was successfully added entry was successfully added.");
                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show("invalid details.");
                reset();
            }


        }


        public void reset()
        {
            metroTextBox1.Text="";
            metroTextBox2.Text="";
            metroComboBox1.SelectedIndex=-1;
            metroComboBox2.SelectedIndex=-1;
            metroComboBox3.SelectedIndex=-1;
            metroComboBox4.SelectedIndex=-1;
            richTextBox1.Text = "";



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

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            showStudentDetail();
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            viewallachievements dora = new viewallachievements();
            dora.Show();
        }
    }
}

