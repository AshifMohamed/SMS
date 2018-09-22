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
    public partial class allsemesPayments : MetroFramework.Forms.MetroForm
    {


        SqlConnection conn = DBAccess.GetConnection();
        public allsemesPayments()
        {
            InitializeComponent();
        }



        private void allsemesPayments_Load(object sender, EventArgs e)
        {
            displaylist();
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Payment_num,date_of_payment,reg_num,academic_year,semes_grade,semes,fees_tobe_paid,payment_amount,balance,fine_amt from semester_fees ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            allsemes.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = allsemes.Rows.Add();
                allsemes.Rows[n].Cells[0].Value = item[0].ToString();
                allsemes.Rows[n].Cells[1].Value = item[1].ToString();
                allsemes.Rows[n].Cells[2].Value = item[2].ToString();
                allsemes.Rows[n].Cells[3].Value = item[3].ToString();
                allsemes.Rows[n].Cells[4].Value = item[4].ToString();
                allsemes.Rows[n].Cells[5].Value = item[5].ToString();
                allsemes.Rows[n].Cells[6].Value = item[6].ToString();
                allsemes.Rows[n].Cells[7].Value = item[7].ToString();
                allsemes.Rows[n].Cells[8].Value = item[8].ToString();
                allsemes.Rows[n].Cells[9].Value = item[9].ToString();
               
            }

        }

        private void allsemes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
