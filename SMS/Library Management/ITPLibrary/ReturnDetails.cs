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
using ITPLibrary.Properties;
using WindowsFormsApplication4;

namespace ITPLibrary
{
    public partial class ReturnDetails : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = DBAccess.GetConnection();
        string bkid;
        int quan;
        public ReturnDetails()
        {
            InitializeComponent();
        }

        string bid;

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // DataTable dt = new DataTable();
            if (e.RowIndex < 0)
                return;
            else
            {
                DateTime RetuDate = Convert.ToDateTime(ReturnGrid.Rows[e.RowIndex].Cells["RetDate"].Value);
                DateTime CurDate = Convert.ToDateTime(ReturnGrid.Rows[e.RowIndex].Cells["curDate"].Value);

                TimeSpan dif = CurDate - RetuDate;

                int days = dif.Days;
                if (days <= 0)
                {
                    MessageBox.Show("No fine to be calculated");
                    ReturnGrid.Rows[e.RowIndex].Cells["fine"].Value = "0";
                }
                else 
                {
                   if (ReturnGrid.Rows[e.RowIndex].Cells["Bk2AccessNum"].Value.ToString() == string.Empty)
                    {
                        MessageBox.Show(ReturnGrid.Rows[e.RowIndex].Cells["Bk2AccessNum"].Value.ToString());
                        int amnt = 20 * days;
                        ReturnGrid.Rows[e.RowIndex].Cells["fine"].Value = amnt.ToString();
                    }
                    else
                    {
                        int amnt = 2* 20 * days;
                        ReturnGrid.Rows[e.RowIndex].Cells["fine"].Value = amnt.ToString();
                    }
                }

            }

            increaseCount(bid);

            
            
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            displaylist();   
        }

        void displaylist()
        {
            String EIA = metroTextBox1.Text;

            SqlDataAdapter sda = new SqlDataAdapter("Select EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber,Book1Name, Bk2AccessionNumber,Book2Name,Amount from Issue_books where EmpIndexAdmissioNum='"+EIA+"' ", Con);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReturnGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = ReturnGrid.Rows.Add();
                ReturnGrid.Rows[n].Cells[0].Value = item[0].ToString();
                ReturnGrid.Rows[n].Cells[1].Value = item[3].ToString();
                ReturnGrid.Rows[n].Cells[2].Value = item[4].ToString();
                ReturnGrid.Rows[n].Cells[3].Value = item[5].ToString();
                ReturnGrid.Rows[n].Cells[4].Value = item[6].ToString();              
                ReturnGrid.Rows[n].Cells[5].Value = item[1].ToString();
                ReturnGrid.Rows[n].Cells[6].Value = item[2].ToString();
                ReturnGrid.Rows[n].Cells[7].Value = DateTime.Today.ToString("dd/MM/yyyy");

               
            }
           /* Con.Open();
            SqlCommand cmd = new SqlCommand("Select EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber,Book1Name, Bk2AccessionNumber,Book2Name,Amount from Issue_books where EmpIndexAdmissioNum=@1 ", Con);

            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@1", metroTextBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Register_Books_BkNo");
            ReturnGrid.DataSource = ds.Tables["Register_Books_BkNo"].DefaultView;
            cmd.ExecuteNonQuery();
            ReturnGrid.Columns[2].HeaderText = "Available Quantity";*/

            
            
            
            Con.Close();


        }

        private void ReturnGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void ReturnDetails_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            displaylist();
        }

        private void ReturnGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber,Book1Name, Bk2AccessionNumber,Book2Name,Amount from Issue_books ", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReturnGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = ReturnGrid.Rows.Add();
                ReturnGrid.Rows[n].Cells[0].Value = item[0].ToString();
                ReturnGrid.Rows[n].Cells[1].Value = item[3].ToString();
                ReturnGrid.Rows[n].Cells[2].Value = item[4].ToString();
                ReturnGrid.Rows[n].Cells[3].Value = item[5].ToString();
                ReturnGrid.Rows[n].Cells[4].Value = item[6].ToString();
                ReturnGrid.Rows[n].Cells[5].Value = item[1].ToString();
                ReturnGrid.Rows[n].Cells[6].Value = item[2].ToString();
                ReturnGrid.Rows[n].Cells[7].Value = DateTime.Today.ToString("dd/MM/yyyy");


            }
        }


        public void increaseCount(String ID)
        {
            Con.Open();

            String BID = ID;
            SqlCommand cmd = new SqlCommand("update  Register_Books_BkNo set Quantity=Quantity +"+1+" where BookID='"+BID+"'", Con);
            MessageBox.Show(bkid);

            //cmd.Parameters.AddWithValue("@2", quan = quan + 1);
            //cmd.Parameters.AddWithValue("@3", bkid);

            cmd.ExecuteNonQuery();

            Con.Close();
        }

        private void ReturnGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != ReturnGrid.Columns[9].Index)
                return;
            else
            {
                bid = ReturnGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Image image = Resources.Wisdom;
                e.Graphics.DrawImage(image, 30, 0, image.Width, image.Height);


                e.Graphics.DrawString("    Wisdom International College Beruwala,SriLanka", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(8, 120));
                e.Graphics.DrawString("                                   Library Fine Receipt                        ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(17, 190));
                e.Graphics.DrawString("Date  : " + DateTime.Now, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 240));

                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 260));

                e.Graphics.DrawString("Student Addmission No:", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 290));
                e.Graphics.DrawString("Issued Date :", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 330));
                e.Graphics.DrawString("Returned Date :", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 370));
                e.Graphics.DrawString("Fine Amount :", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 410));


                int ypos = 330;


                e.Graphics.DrawString(ReturnGrid.CurrentRow.Cells[0].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 290));
                e.Graphics.DrawString(ReturnGrid.CurrentRow.Cells[5].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 330));
                e.Graphics.DrawString(ReturnGrid.CurrentRow.Cells[6].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 370));
                e.Graphics.DrawString(ReturnGrid.CurrentRow.Cells[8].Value.ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 410));


                e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(27, 440));
                e.Graphics.DrawString("........................................", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 550));
                e.Graphics.DrawString("Librarian's Signature", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 580));
            }

            catch (Exception)
            {
                MessageBox.Show("Please Select a Row to Print");
            }


        }
            
            
        }
    }

