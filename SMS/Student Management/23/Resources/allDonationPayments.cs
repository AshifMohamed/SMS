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

namespace _23.Resources
{
    public partial class allDonationPayments : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B8EKFRK\DIV12;Initial Catalog=wisdom;Integrated Security=True");
        public allDonationPayments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT pay_num,applicant_id,applicant_name,payment_date,grade_donation_amt,paid_amt FROM semester_fees WHERE reg_num=@1 ORDER BY date_of_payment ", conn);
                cmd.Parameters.AddWithValue("@1", metroTextBox1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "donation_fee");
                metroGrid1.DataSource = ds.Tables["donation_fee"].DefaultView;

                cmd.ExecuteNonQuery();


                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
