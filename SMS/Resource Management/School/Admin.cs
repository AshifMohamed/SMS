using MetroFramework.Forms;
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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using MetroFramework.Forms;
using WindowsFormsApplication4;

namespace School
{
    public partial class Admin : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
          
            display3();
            display();
            metroLabel20.Text = DateTime.Now.ToString();



        }

        
        public void display()
        {
            string query1 = "select * from suppliers";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            metroGrid2.DataSource = dt1;
        }

        public void display3()
        {
            string query1 = "select * from admin_req";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            metroGrid3.DataSource = dt1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "")
            {
                MessageBox.Show(" Please enter a value into all boxes");
            }

            else
            {
                {
                    try
                    {

                        string com = metroTextBox1.Text;
                        string name = metroTextBox2.Text;
                        string type = metroComboBox1.SelectedItem.ToString();
                        string email = metroTextBox3.Text;
                        int cont = Convert.ToInt32(this.metroTextBox4.Text);
                        int fax = Convert.ToInt32(this.metroTextBox5.Text);
                        string web = metroTextBox6.Text;

                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("insert INTO suppliers ( com_name, name, type, email, contact_number, fax, web_address ) VALUES('" + com + "','" + name + "','" + type + "','" + email + "','" + cont + "','" + fax + "','" + web + "')", con);
                        cmd1.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data was addes successfully", "Success");
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                reset();

            }


        }
        void reset()
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = ""; metroTextBox3.Text = ""; metroTextBox4.Text = ""; metroTextBox5.Text = ""; metroComboBox1.SelectedIndex = -1;
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
        

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                //change properties of the workbook
                ExcelApp.Columns.ColumnWidth = 20;
                //sorting headre part in excel 


                for (int i = 1; i < metroGrid2.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = metroGrid2.Columns[i - 1].HeaderText;

                }
                // sorting each row and colums valu to excel sheet
                for (int i = 0; i < metroGrid2.Rows.Count; i++)
                {
                    for (int j = 0; j < metroGrid2.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = metroGrid2.Rows[i].Cells[j].Value.ToString();


                    }

                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
                MessageBox.Show("Exported Succesfully");


            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            //string name = metroTextBox4.Text;

            //if (Class1.isNumber(name))
            //{
            //    errorProvider1.SetError(metroTextBox4, "can contain only letter.");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //print f = new print();
            //f.Show();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(
                    "mameershahib@gmail.com", "ameer497191"); //enter your gmail id and password

                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Subject = textBox2.Text;
                msg.Body = textBox4.Text;

                client.Send(msg);
                MessageBox.Show("Message sent to the suppliers");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
