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
using MetroFramework.Forms;
namespace School
{
    public partial class inex : MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQG2200;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=1234");

        public inex()
        {
            InitializeComponent();
        }

        private void inex_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT SUM(total) FROM examFees;", con);
            cmd1.ExecuteNonQuery();
            metroLabel13.Text = cmd1.ExecuteScalar().ToString();
            //SqlCommand cmd2 = new SqlCommand("SELECT SUM(fees_tobe_paid) FROM semester_fees", con);
            //cmd2.ExecuteNonQuery();
            //metroLabel33.Text = cmd2.ExecuteScalar().ToString();
            //SqlCommand cmd3 = new SqlCommand("SELECT SUM(paid_amt) FROM donation_fee", con);
            //cmd3.ExecuteNonQuery();
            //metroLabel12.Text = cmd3.ExecuteScalar().ToString();
            //SqlCommand cmd4 = new SqlCommand("SELECT SUM(fine_amt) FROM semester_fees", con);
            //cmd4.ExecuteNonQuery();
            //metroLabel33.Text = cmd4.ExecuteScalar().ToString();
            //SqlCommand cmd5 = new SqlCommand("SELECT SUM(payment_amount) FROM semester_fees", con);
            //cmd5.ExecuteNonQuery();
            //metroLabel35.Text = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd6 = new SqlCommand("SELECT SUM(amount) FROM inex WHERE num = 1", con);
            cmd6.ExecuteNonQuery();
            metroLabel37.Text = cmd6.ExecuteScalar().ToString();
            SqlCommand cmd7 = new SqlCommand("SELECT SUM(amount) FROM inex WHERE num = 2", con);
            cmd7.ExecuteNonQuery();
            metroLabel41.Text = cmd7.ExecuteScalar().ToString();


//            int ameer = (int)cmd1.ExecuteScalar();
//            int b = (int)cmd2.ExecuteScalar();
//            int c = (int)cmd3.ExecuteScalar();
//            int d = (int)cmd4.ExecuteScalar();
//            int h = (int)cmd5.ExecuteScalar();
//            int f = (int)cmd6.ExecuteScalar();
//            int g = (int)cmd7.ExecuteScalar();
////            int h = (int)cmd1.ExecuteScalar();

//            MessageBox.Show(ameer.ToString());
//            metroLabel3.Text = DateTime.Now.ToString();

        }

        internal static inex InstanceForm()
        {
            throw new NotImplementedException();
        }
    }
}
