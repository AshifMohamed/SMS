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
    public partial class allDonationPayments : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public allDonationPayments()
        {
            InitializeComponent();
        }

        private void allDonationPayments_Load(object sender, EventArgs e)
        {
            displaylist();
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select pay_num,applicant_id,applicant_name,payment_date,grade_,donation_amt,paid_amt from donation_fee", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            alldonations.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = alldonations.Rows.Add();
                alldonations.Rows[n].Cells[0].Value = item[0].ToString();
                alldonations.Rows[n].Cells[1].Value = item[1].ToString();
                alldonations.Rows[n].Cells[2].Value = item[2].ToString();
                alldonations.Rows[n].Cells[3].Value = item[3].ToString();
                alldonations.Rows[n].Cells[4].Value = item[4].ToString();
                alldonations.Rows[n].Cells[5].Value = item[5].ToString();
                alldonations.Rows[n].Cells[6].Value = item[6].ToString();

            }

        }

        private void alldonations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
