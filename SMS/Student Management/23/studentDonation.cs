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
    public partial class studentDonation : Form
    {
        public studentDonation()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBAccess.GetConnection();

      
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {

                if ( txtapplicantid.Text != "" & txtapplicantname.Text != "" & txtdateofpayment.Text != "" & txtadmissiongrade.Text != ""  &
                     txtdonationamt.Text != "" & txtpaidamount.Text != "")
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO donation_fee (applicant_id,applicant_name,payment_date,grade_,donation_amt,paid_amt) VALUES (@2,@3,@4,@5,@7,@8);", conn);

                  
                    cmd.Parameters.AddWithValue("@2", txtapplicantid.Text);
                    cmd.Parameters.AddWithValue("@3", txtapplicantname.Text);
                    cmd.Parameters.AddWithValue("@4", txtdateofpayment.Text);
                    cmd.Parameters.AddWithValue("@5", txtadmissiongrade.Text);
                 
                    cmd.Parameters.AddWithValue("@7", txtdonationamt.Text);
                    cmd.Parameters.AddWithValue("@8", txtpaidamount.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();


                    MessageBox.Show("Donation entry successfully added.");
                }
                else
                {
                    MessageBox.Show("One or more field is empty");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
               
        }

        private void studentDonation_Load(object sender, EventArgs e)
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

        void reset()
        {

             txtapplicantid.Text="";
             txtapplicantname.Text="";
             txtdateofpayment.Text="";
            txtadmissiongrade.SelectedIndex=-1;

            txtdonationamt.Text="";
            txtpaidamount.Text = "";
            
        }

        private void txtapplicantid_TextChanged(object sender, EventArgs e)
        {
            string app = txtapplicantid.Text;
            if (studentValidate.IsAllLettersOrDigits(app))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtapplicantid, "can contain only letters and digits");
                metroTile1.Enabled = false;
            }
        }

        private void txtapplicantname_TextChanged(object sender, EventArgs e)
        {
            string appname = txtapplicantname.Text;
            if (studentValidate.isNumber(appname))
            {
                errorProvider1.SetError(txtapplicantname, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtadmissiongrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtadmissiongrade.SelectedItem == "1")
                txtdonationamt.Text = "100,000";
            else if (txtadmissiongrade.SelectedItem == "2")
                txtdonationamt.Text = "120,000";
            else if (txtadmissiongrade.SelectedItem == "3")
                txtdonationamt.Text = "130,000";
            else if (txtadmissiongrade.SelectedItem == "4")
                txtdonationamt.Text = "140,000";
            else if (txtadmissiongrade.SelectedItem == "5")
                txtdonationamt.Text = "150,000";
            else if (txtadmissiongrade.SelectedItem == "6")
                txtdonationamt.Text = "160,000";
            else if (txtadmissiongrade.SelectedItem == "7")
                txtdonationamt.Text = "170,000";
            else if (txtadmissiongrade.SelectedItem == "8")
                txtdonationamt.Text = "180,000";
            else if (txtadmissiongrade.SelectedItem == "9")
                txtdonationamt.Text = "190,000";
            else if (txtadmissiongrade.SelectedItem == "10")
                txtdonationamt.Text = "200,000";
            else if (txtadmissiongrade.SelectedItem == "11")
                txtdonationamt.Text = "210,000";
            else if (txtadmissiongrade.SelectedItem == "12")
                txtdonationamt.Text = "220,000";
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            string pay = txtpaidamount.Text;

            if ((studentValidate.isLetter(pay)))
            {
                errorProvider1.SetError(txtpaidamount, "can contain only digits");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            allDonationPayments dora = new allDonationPayments();
            dora.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("    Wisdom International College Beruwala,SriLanka", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(8, 120));
            e.Graphics.DrawString("                             Donation Fees Receipt", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(17, 190));
            e.Graphics.DrawString("Date  : " + DateTime.Now, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 240));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 260));

            e.Graphics.DrawString("Applicant ID :" + txtapplicantid.Text.Trim(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            e.Graphics.DrawString("Applicant Name :" + txtapplicantname.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Admission Grade :" + txtadmissiongrade.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString("Recieved Amount :" + txtpaidamount.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 410));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 440));

            e.Graphics.DrawString("........................................", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 550));
            e.Graphics.DrawString("Accountant's Signature", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 580));
        }
    }
}
