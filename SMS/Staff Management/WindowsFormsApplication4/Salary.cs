using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Salary : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        public Salary()
        {
            InitializeComponent();
        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        public void FillSlip(string id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from RegEmployee where ID='" + id+"'", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    metroLabel25.Text = id;
                    metroLabel4.Text = dr["FirstName"].ToString();
                    metroLabel5.Text = dr["LastName"].ToString();
                    metroLabel7.Text = dr["Salary"].ToString();
                 
                }
                conn.Close();
             //  DateTime mon= DateTime.Today;
               metroLabel3.Text = DateTime.Now.ToString("MMMM yyyy");
                int sal=Convert.ToInt32(metroLabel7.Text);
                double etf = Convert.ToDouble(sal * 0.08);
                metroLabel13.Text = etf.ToString();
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string sal = metroTextBox1.Text;
            if (ValidateEmployee.isNumber(sal))
           {
               errorProvider1.SetError(metroTextBox1, "can contain only numbers");
              // metroButton1.Enabled = false;
               
           }
           else
           {
               errorProvider1.Clear();
              // metroButton1.Enabled = true;
               calcGross();
               
           }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            string ded = metroTextBox2.Text;
            if (ValidateEmployee.isNumber(ded))
            {
                errorProvider1.SetError(metroTextBox2, "can contain only numbers");
               // metroButton1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
               // metroButton1.Enabled = true;
                calcDeduction();
                calcNetPay();

            }
        }

        public void calcGross()
        {
         if(! String.IsNullOrEmpty(metroTextBox1.Text))
            { 
           int sal=Convert.ToInt32( metroLabel7.Text);
           Double all = Convert.ToDouble(metroTextBox1.Text);
           double gross = sal + all;
           metroLabel11.Text = gross.ToString();
            }
        }

        public void calcDeduction()
        {
            if (!String.IsNullOrEmpty(metroTextBox2.Text))
            {
                Double epf = Convert.ToDouble(metroLabel13.Text);
                Double ded = Convert.ToDouble(metroTextBox2.Text);
                double totalDed = epf + ded;
                metroLabel17.Text = totalDed.ToString();
            }
           
        }

        public void calcNetPay()
        {
            if (!String.IsNullOrEmpty(metroTextBox2.Text))
            {
                Double gross = Convert.ToDouble(metroLabel11.Text);
                Double totDed = Convert.ToDouble(metroLabel17.Text);
                double net = gross - totDed;
                metroLabel19.Text = net.ToString();
                calcContribution();
                metroButton1.Enabled = true;
                metroButton2.Enabled = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            addSalary();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Salary Slip For the Month Of", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 25));
            e.Graphics.DrawString(metroLabel3.Text.Trim(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(560, 25));

            e.Graphics.DrawString("Name", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString(metroLabel4.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(500, 50));
            e.Graphics.DrawString(metroLabel5.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(560, 50));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 75));

            e.Graphics.DrawString("Basic Salary", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString(metroLabel7.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 100));

            e.Graphics.DrawString("Allowances", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 125));
            e.Graphics.DrawString(metroTextBox1.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 125));

            e.Graphics.DrawString("Gross Salary", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString(metroLabel11.Text.Trim(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(560, 150));

            e.Graphics.DrawString("EPF Deduction", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 175));
            e.Graphics.DrawString(metroLabel13.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 175));

            e.Graphics.DrawString("Other Deduction", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString(metroTextBox2.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 200));

            e.Graphics.DrawString("Total Deduction", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 225));
            e.Graphics.DrawString(metroLabel17.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 225));

            e.Graphics.DrawString("Net Pay", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 275));
            e.Graphics.DrawString(metroLabel19.Text.Trim(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(560, 275));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 75));


            e.Graphics.DrawString("Wisdom International is Contributing", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(30, 325));

            e.Graphics.DrawString("E.P.F CONTRIBUTION 12%   :", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(30, 355));
            e.Graphics.DrawString(metroLabel23.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(560, 355));

            e.Graphics.DrawString("E.T.F CONTRIBUTION 3%   :", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(30, 385));
            e.Graphics.DrawString(metroLabel24.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(560, 385));

            e.Graphics.DrawString("SIGNATURE OF THE EMPLOYEE   :           ................................", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(30, 415));
        }
        public void calcContribution()
        {
            double EPFCon = Convert.ToDouble(metroLabel19.Text)*0.12;
            double ETFCon = Convert.ToDouble(metroLabel19.Text)*0.03;
            metroLabel23.Text = EPFCon.ToString();
            metroLabel24.Text = ETFCon.ToString();
        }

        public void addSalary()
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("INSERT INTO Salary (Month, ID,Salary,EPFDeduction,NetPay,EPFcontribution, ETFcontribution) VALUES (@1, @2, @3, @4, @5, @6, @7)", conn);


                Cmd.Parameters.AddWithValue("@1", DateTime.Today.Month);
                Cmd.Parameters.AddWithValue("@2", metroLabel25.Text);
                Cmd.Parameters.AddWithValue("@3", metroLabel7.Text);
                Cmd.Parameters.AddWithValue("@4", metroLabel13.Text);
                Cmd.Parameters.AddWithValue("@5", metroLabel19.Text);
                Cmd.Parameters.AddWithValue("@6", metroLabel23.Text);
                Cmd.Parameters.AddWithValue("@7", metroLabel24.Text);
                


                Cmd.ExecuteNonQuery();
                
                conn.Close();

                MessageBox.Show("Salary Record Added Successfully");
              
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Salary Record  already Added");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}