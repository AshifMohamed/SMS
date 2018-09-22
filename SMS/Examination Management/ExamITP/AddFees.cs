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
    public partial class AddFees : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();

        examFees e1;

        public AddFees(examFees e2)
        {
            InitializeComponent();
            e1 = e2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFees_FormClosing);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "")
            {
                MessageBox.Show("Fill the empty fields");
            }
            else
            {
                this.metroButton2.Enabled = true;
                if (metroLabel13.Text.ToString() == "1" || metroLabel13.Text.ToString() == "2" || metroLabel13.Text.ToString() == "3" || metroLabel13.Text.ToString() == "4" || metroLabel13.Text.ToString() == "5")
                {
                    float examFees = 3000;
                    float latePaye;
                    float tot;
                    string payement = "Paid";

                    metroLabel14.Text = examFees.ToString();
                    metroLabel15.Text = payement.ToString();

                    if (metroComboBox1.SelectedItem.ToString() == "Yes")
                    {
                        latePaye = 500;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }
                    else
                    {
                        latePaye = 0;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }

                }
                else if (metroLabel13.Text.ToString() == "6" || metroLabel13.Text.ToString() == "7" || metroLabel13.Text.ToString() == "8" || metroLabel13.Text.ToString() == "9")
                {
                    float examFees = 3500;
                    float latePaye;
                    float tot;
                    string payement = "Paid";

                    metroLabel14.Text = examFees.ToString();
                    metroLabel15.Text = payement.ToString();

                    if (metroComboBox1.SelectedItem.ToString() == "Yes")
                    {
                        latePaye = 500;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }
                    else
                    {
                        latePaye = 0;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }

                }
                else if (metroLabel13.Text.ToString() == "10" || metroLabel13.Text.ToString() == "11")
                {
                    float examFees = 4000;
                    float latePaye;
                    float tot;
                    string payement = "Paid";

                    metroLabel14.Text = examFees.ToString();
                    metroLabel15.Text = payement.ToString();

                    if (metroComboBox1.SelectedItem.ToString() == "Yes")
                    {
                        latePaye = 1000;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }
                    else
                    {
                        latePaye = 0;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }

                }
                else if (metroLabel13.Text.ToString() == "12" || metroLabel13.Text.ToString() == "13")
                {
                    float examFees = 4500;
                    float latePaye;
                    float tot;
                    string payement = "Paid";

                    metroLabel14.Text = examFees.ToString();
                    metroLabel15.Text = payement.ToString();

                    if (metroComboBox1.SelectedItem.ToString() == "Yes")
                    {
                        latePaye = 1500;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }
                    else
                    {
                        latePaye = 0;
                        metroLabel16.Text = latePaye.ToString();
                        tot = examFees + latePaye;
                        metroLabel17.Text = tot.ToString();
                    }

                }

                else
                {

                }
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            examFees a = new examFees();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " update exFees1 set AdmissionNo='" + metroLabel10.Text + "',Fname='" + metroLabel11.Text + "', surname='" + metroLabel12.Text + "', admissionGrade='" + metroLabel13.Text + "',examFees='" + metroLabel14.Text + "', latePay='" + metroComboBox1.Text + "', pay='" + metroLabel15.Text + "', latePaye='" + metroLabel16.Text + "', total='" + metroLabel17.Text + "' where AdmissionNo='" + metroLabel10.Text + "' ";
            cmd.ExecuteNonQuery();            
            conn.Close();            
            MessageBox.Show("Examination Fees Payment Entered");
            this.Close();
            //a.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            examFees a = new examFees();
            this.Hide();
            a.Show();
        }

        private void AddFees_FormClosing(object sender, FormClosingEventArgs e)
        {
            e1.refreshI();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
