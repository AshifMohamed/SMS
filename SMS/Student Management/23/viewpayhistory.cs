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
    public partial class viewpayhistory : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public viewpayhistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Payment_num,date_of_payment,reg_num,academic_year,semes_grade,semes,fees_tobe_paid,payment_amount,balance,fine_amt FROM semester_fees WHERE reg_num=@1 ORDER BY date_of_payment ", conn);
                cmd.Parameters.AddWithValue("@1", txtreg.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "semester_fees");
                metroGrid1.DataSource = ds.Tables["semester_fees"].DefaultView;

                cmd.ExecuteNonQuery();


                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void viewpayhistory_Load(object sender, EventArgs e)
        {

        }
    }
}
