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

namespace ITPLibrary
{
    public partial class RegisterBook : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = DBAccess.GetConnection();
        string bknum = "bk";
        public RegisterBook()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBook_Load(object sender, EventArgs e)
        {
            displaylist();
        //    calculateTotalBooks();

           
        }

        private void btregbk_Click(object sender, EventArgs e)
        {
            try
            {
                if ( date.Text != "" & author.Text != "" & title.Text != "" & typecmb.Text != "" &  QtyTxt.Text!="" & pubname.Text != "" & pubdate.Text != "")
                {
                    Con.Open();
                    int qty = Convert.ToInt32(QtyTxt.Text);

                    SqlCommand cmd = new SqlCommand("INSERT INTO Register_Books ( Date,Author, Title, Type, PublisherName,PublishedDate) VALUES (@2,@3,@4,@5,@6,@7)SELECT SCOPE_IDENTITY();", Con);              
                    // cmd.Parameters.AddWithValue("@1", accessionNumtxt.Text);
                    cmd.Parameters.AddWithValue("@2", date.Text);
                    cmd.Parameters.AddWithValue("@3", author.Text);
                    cmd.Parameters.AddWithValue("@4", title.Text);
                    cmd.Parameters.AddWithValue("@5", typecmb.Text);
                    // cmd.Parameters.AddWithValue("@6", QtyTxt.Text);
                    cmd.Parameters.AddWithValue("@6", pubname.Text);
                    cmd.Parameters.AddWithValue("@7", pubdate.Text);
                    //cmd.ExecuteNonQuery();

                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                  //  MessageBox.Show(id.ToString());
                    string acnum = "ACN000" + id.ToString();

                   
                    bknum = "BK" + id.ToString();
                    

                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Register_Books_BkNo (BookID,AccessionNumber,Date,Author, Title, Type,Quantity, PublisherName,PublishedDate) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9);", Con);

                    cmd1.Parameters.AddWithValue("@1", bknum);
                    cmd1.Parameters.AddWithValue("@2", acnum);
                    cmd1.Parameters.AddWithValue("@3", date.Text);
                    cmd1.Parameters.AddWithValue("@4", author.Text);
                    cmd1.Parameters.AddWithValue("@5", title.Text);
                    cmd1.Parameters.AddWithValue("@6", typecmb.Text);
                    cmd1.Parameters.AddWithValue("@7", qty);
                    cmd1.Parameters.AddWithValue("@8", pubname.Text);
                    cmd1.Parameters.AddWithValue("@9", pubdate.Text);
                    cmd1.ExecuteNonQuery();

                    for(int i=0;i<qty-1;i++)
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Register_Books ( Date,Author, Title, Type, PublisherName,PublishedDate) VALUES (@2,@3,@4,@5,@6,@7);", Con);

                        // cmd.Parameters.AddWithValue("@1", accessionNumtxt.Text);
                        cmd3.Parameters.AddWithValue("@2", date.Text);
                        cmd3.Parameters.AddWithValue("@3", author.Text);
                        cmd3.Parameters.AddWithValue("@4", title.Text);
                        cmd3.Parameters.AddWithValue("@5", typecmb.Text);
                       // cmd.Parameters.AddWithValue("@6", QtyTxt.Text);
                        cmd3.Parameters.AddWithValue("@6", pubname.Text);
                        cmd3.Parameters.AddWithValue("@7", pubdate.Text);
                        //cmd.ExecuteNonQuery();

                         id = Convert.ToInt32(cmd.ExecuteScalar());
                         acnum = "ACN000" + id.ToString();
                        
                        
                        

                        SqlCommand cmd4 = new SqlCommand("INSERT INTO Register_Books_BkNo (BookID,AccessionNumber,Date,Author, Title, Type,Quantity, PublisherName,PublishedDate) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9);", Con);

                        cmd4.Parameters.AddWithValue("@1", bknum);
                        cmd4.Parameters.AddWithValue("@2", acnum);
                        cmd4.Parameters.AddWithValue("@3", date.Text);
                        cmd4.Parameters.AddWithValue("@4", author.Text);
                        cmd4.Parameters.AddWithValue("@5", title.Text);
                        cmd4.Parameters.AddWithValue("@6", typecmb.Text);
                        cmd4.Parameters.AddWithValue("@7", QtyTxt.Text);
                        cmd4.Parameters.AddWithValue("@8", pubname.Text);
                        cmd4.Parameters.AddWithValue("@9", pubdate.Text);
                        cmd4.ExecuteNonQuery();

                    }

                   

                    
                    Con.Close();
                    displaylist();
                  //  calculateTotalBooks();
                    reset();


                    MessageBox.Show("New Book has been added to the database.");

                    

                }
                else
                    MessageBox.Show("one or more field is empty");

            }

            catch (SqlException)
            {

             //   MessageBox.Show("Accession Number is aleady used");
                Con.Close();
            }
            
          
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select BookID,AccessionNumber,Date,Author, Title, Type, PublisherName,PublishedDate from Register_Books_BkNo", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tableRegBk.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = tableRegBk.Rows.Add();
                tableRegBk.Rows[n].Cells[0].Value = item[0].ToString();
                tableRegBk.Rows[n].Cells[1].Value = item[1].ToString();
                tableRegBk.Rows[n].Cells[2].Value = item[2].ToString();
                tableRegBk.Rows[n].Cells[3].Value = item[3].ToString();
                tableRegBk.Rows[n].Cells[4].Value = item[4].ToString();
                tableRegBk.Rows[n].Cells[5].Value = item[5].ToString();
              //  tableRegBk.Rows[n].Cells[6].Value = item[6].ToString();
                tableRegBk.Rows[n].Cells[6].Value = item[6].ToString();
                tableRegBk.Rows[n].Cells[7].Value = item[7].ToString();
            }
            lblCount.Text = "Total Books Count :  " + dt.Rows.Count.ToString();

        /*    SqlDataAdapter sda2 = new SqlDataAdapter("select sum(Quantity) from Register_Books", Con);
            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    BkCount.Text = "Total Books Count :  " + (int)drow[dcol]; 
                }
            }*/

            
          
        }

      /*  public void calculateTotalBooks()
        {
            int sum = 0;
            for (int i = 0; i < tableRegBk.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(tableRegBk.Rows[i].Cells[6].Value);
            }
            BkCount.Text = "Total Books Count :  " + sum.ToString();
        }
        */
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be Erased. do you want to proceed? ", "Delete Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //int dec = -1;
   
                    SqlCommand cmd1 = new SqlCommand("update Register_Books_BkNo set Quantity = Quantity - 1 where BookID=@2 and Quantity > 0", Con);
                    SqlCommand cmd = new SqlCommand("delete from Register_Books_BkNo  where AccessionNumber=@1", Con);
                   
                    cmd.Parameters.AddWithValue("@1", accessionNumtxt.Text);
                    cmd1.Parameters.AddWithValue("@2", BkID.Text);
                    Con.Open();
                    cmd1.ExecuteNonQuery();
                    int a = cmd.ExecuteNonQuery();
                    displaylist();
                   // calculateTotalBooks();
                    reset();

                    if (a > 0)
                    {
                       MessageBox.Show("Data Deleted");
                       
                   }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public void reset()
        {
            BkID.Text = "";
            accessionNumtxt.Text = "";
            author.Text = "";
            title.Text = "";
            typecmb.SelectedIndex = -1;
            pubname.Text = "";
            QtyTxt.Text = "";
        }

        private void tableRegBk_MouseClick(object sender, MouseEventArgs e)
        {
            BkID.Text = tableRegBk.SelectedRows[0].Cells[0].Value.ToString();
            accessionNumtxt.Text = tableRegBk.SelectedRows[0].Cells[1].Value.ToString();
            date.Text = tableRegBk.SelectedRows[0].Cells[2].Value.ToString();
            author.Text = tableRegBk.SelectedRows[0].Cells[3].Value.ToString();
            title.Text = tableRegBk.SelectedRows[0].Cells[4].Value.ToString();
            typecmb.Text = tableRegBk.SelectedRows[0].Cells[5].Value.ToString();
           // QtyTxt.Text = tableRegBk.SelectedRows[0].Cells[6].Value.ToString();
            pubname.Text = tableRegBk.SelectedRows[0].Cells[6].Value.ToString();
            pubdate.Text = tableRegBk.SelectedRows[0].Cells[7].Value.ToString();
           

            if (accessionNumtxt.Text == "" & date.Text == "" & author.Text == "" & title.Text == "" & typecmb.Text == "" & QtyTxt.Text=="" & pubname.Text == "" & pubdate.Text == "")
            {
                MessageBox.Show("One ore more field is empty.");

            }
           
        }

        private void author_TextChanged(object sender, EventArgs e)
        {
             string autho = author.Text;
             if (BookRegValidation.isNumber(autho))
             {
                 errorProvider1.SetError(author, "can contain only letters");
                 btregbk.Enabled = false;

             }
             else
             {
                 errorProvider1.Clear();
                 btregbk.Enabled = true;
             }
        }

        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            string qty = QtyTxt.Text;
            if (BookRegValidation.isLetter(qty))
            {
                errorProvider1.SetError(QtyTxt, "can contain only Numbers");
                btregbk.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                btregbk.Enabled = true;
            }
        }

        private void pubname_TextChanged(object sender, EventArgs e)
        {
            string pubnam = pubname.Text;
            if (BookRegValidation.isNumber(pubnam))
            {
                errorProvider1.SetError(pubname, "can contain only letters");
                btregbk.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                btregbk.Enabled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            accessionNumtxt.Text = "";
            DateTime date = DateTime.Today;
            author.Text = "";
            title.Text = "";
            typecmb.SelectedIndex = -1;
            QtyTxt.Text = "";
            pubname.Text = "";
            DateTime pubdate = DateTime.Today;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            displayquantity dora = new displayquantity();
            dora.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                //this.validateMarks(metroTextBox8.Text.ToString(), metroTextBox7.Text.ToString());
             /*   if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox10.Text == "" || metroComboBox1.Text == "" || metroComboBox5.Text == "" || theDate == "" || metroComboBox3.Text == "" || metroTextBox5.Text == "" || metroTextBox4.Text == "" || metroTextBox9.Text == "" || metroTextBox6.Text == "" || metroTextBox8.Text == "" || metroTextBox7.Text == "")
                {
                    MessageBox.Show("Fill the empty fields");
                }
                else
                {*/
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Register_Books_BkNo set Quantity='" + QtyTxt.Text + "'where BookID ='" + BkID.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("New Book Details are updated");
                   // this.Close();
                   // placeExamTable a = new placeExamTable();
                   // a.Show();
               // }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {

            
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Register_Books_BkNo where Title= @1", Con);
                cmd.Parameters.AddWithValue("@1", metroTextBox1.Text);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {

                        BkID.Text = dr["BookID"].ToString();
                        accessionNumtxt.Text = dr["AccessionNumber"].ToString();
                        date.Text = dr["Date"].ToString();
                        author.Text = dr["Author"].ToString();
                        title.Text = dr["Title"].ToString();
                        typecmb.Text = dr["Type"].ToString();
                        pubname.Text = dr["PublisherName"].ToString();
                        pubdate.Text = dr["PublishedDate"].ToString();
                       
                    }
                
                  }

                dr.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
                // reset();
            }       

                      

        }

    


    }
}
