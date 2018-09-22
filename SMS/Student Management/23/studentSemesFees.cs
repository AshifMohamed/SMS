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
    public partial class studentSemesFees : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
    
        public studentSemesFees()
        {
            InitializeComponent();
        }


        private void txtfees_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtdateofpay.Text != "" & txtregnum.Text != ""  & txtgrade.Text != ""  &
                     txtsemester.Text != "" & txtfees.Text != "" & txtpayamount.Text != "" & txtbalance.Text != "" & txtacademicyear.Text != "")
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO semester_fees (date_of_payment,reg_num,semes_grade,semes,fees_tobe_paid,payment_amount,balance,fine_amt,academic_year) VALUES (@2,@3,@5,@7,@8,@9,@10,@11,@12);", conn);


                    
                    cmd.Parameters.AddWithValue("@2", txtdateofpay.Text);
                    cmd.Parameters.AddWithValue("@3", txtregnum.Text);
                 
                    cmd.Parameters.AddWithValue("@5", txtgrade.Text);
               
                    cmd.Parameters.AddWithValue("@7", txtsemester.Text);
                    cmd.Parameters.AddWithValue("@8", txtfees.Text);
                    cmd.Parameters.AddWithValue("@9", txtpayamount.Text);
                    cmd.Parameters.AddWithValue("@10", Convert.ToDouble(txtbalance.Text));
                    cmd.Parameters.AddWithValue("@11", txtfineamount.Text);
                    cmd.Parameters.AddWithValue("@12", txtacademicyear.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();

                    MessageBox.Show("Semester Fee entry successfully added.");
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

        private void studentSemesFees_Load(object sender, EventArgs e)
        {
            txtsemester.Items.Add("1");
            txtsemester.Items.Add("2");
            txtsemester.Items.Add("3");
            txtacademicyear.Items.Add("2016/2017");
            txtacademicyear.Items.Add("2017/2018");
            txtacademicyear.Items.Add("2018/2019");
            txtacademicyear.Items.Add("2019/2020");
            txtgrade.Items.Add("1");
            txtgrade.Items.Add("2");
            txtgrade.Items.Add("3");
            txtgrade.Items.Add("4");
            txtgrade.Items.Add("5");
            txtgrade.Items.Add("6");
            txtgrade.Items.Add("7");
            txtgrade.Items.Add("8");
            txtgrade.Items.Add("9");
            txtgrade.Items.Add("10");
            txtgrade.Items.Add("11");
            txtgrade.Items.Add("12");
            
        }



        void reset()
        {


            txtdateofpay.Text="";
            txtregnum.Text="";

            txtgrade.SelectedIndex=-1;

            txtsemester.SelectedIndex=-1;
            txtfees.Text="";
            txtpayamount.Text="";
            txtbalance.Text="";
            txtfineamount.Text="";
            txtacademicyear.SelectedIndex = -1;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtfees.Text) && !string.IsNullOrEmpty(txtpayamount.Text))
                txtbalance.Text = (Convert.ToDouble(txtfees.Text) - Convert.ToDouble(txtpayamount.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime deadline = semesdeadline.Value.Date;
            DateTime currentday = current.Value.Date;

            TimeSpan dif = currentday - deadline;

            int days = dif.Days;
            if (days < 0)
            {
                MessageBox.Show("No fine to be paid");
                delaydays.Text = "0";
                txtfineamount.Text = "0";

            }

            else if ((days > 1) && (days < 10))
            {
                txtfineamount.Text = "Rs 1500";
                delaydays.Text = days.ToString();
            }

            else if ((days > 10) && (days < 25))
            {
                txtfineamount.Text = " Rs 2300";
                delaydays.Text = days.ToString();
            }

            else
            {
                txtfineamount.Text = "Rs 5000";
                delaydays.Text = days.ToString();
            }
        }

        private void txtregnum_TextChanged(object sender, EventArgs e)
        {
            string f = txtregnum.Text;
            if (studentValidate.IsAllLettersOrDigits(f))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtregnum, "can contain only letters and digits");
                metroTile1.Enabled = false;
            }
        }

        private void txtpayamount_TextChanged(object sender, EventArgs e)
        {
            string pay = txtpayamount.Text;
           
            if ((studentValidate.isLetter(pay)) )
            {
                errorProvider1.SetError(txtpayamount, "can contain only digits");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void delaydays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtgrade.SelectedItem == "1")
                txtfees.Text = "19800";
            else if (txtgrade.SelectedItem == "2")
                txtfees.Text = "21560";
            else if (txtgrade.SelectedItem == "3")
                txtfees.Text = "26960";
            else if (txtgrade.SelectedItem == "4")
                txtfees.Text = "29790";
            else if (txtgrade.SelectedItem == "5")
                txtfees.Text = "31560";
            else if (txtgrade.SelectedItem == "6")
                txtfees.Text = "35670";
            else if (txtgrade.SelectedItem == "7")
                txtfees.Text = "38520";
            else if (txtgrade.SelectedItem == "8")
                txtfees.Text = "41250";
            else if (txtgrade.SelectedItem == "9")
                txtfees.Text = "42500";
            else if (txtgrade.SelectedItem == "10")
                txtfees.Text = "43200";
            else if (txtgrade.SelectedItem == "11")
                txtfees.Text = "44020";
            else if (txtgrade.SelectedItem == "12")
                txtfees.Text = "45820";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            allsemesPayments dora = new allsemesPayments();
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
            e.Graphics.DrawString("                             Semester Fees Receipt", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(17, 190));
            e.Graphics.DrawString("Date  : " + DateTime.Now, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 240));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 260));

            e.Graphics.DrawString("Student Registration No :" + txtregnum.Text.Trim(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            e.Graphics.DrawString("Academic Year :" + txtacademicyear.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Grade :" + txtgrade.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString("Semester :" + txtsemester.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString("Recieved Amount :" + txtpayamount.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 480));

            e.Graphics.DrawString("........................................" + txtpayamount.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 550));
            e.Graphics.DrawString("Accountant's Signature", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 580));
        }

    }
}
