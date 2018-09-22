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
    public partial class Issue : MetroFramework.Forms.MetroForm
    {
        SqlConnection Con = DBAccess.GetConnection();
        string bkid;
        int quan;
        public Issue()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
      SqlDataReader dr2;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void AccessionNumTxt_Enter(object sender, EventArgs e)
        {
           

        }

        private void AccessionNumTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  Register_Books_BkNo where AccessionNumber= @2", Con);
                    
                cmd.Parameters.AddWithValue("@2", Bk1AccessionNumTxt.Text);
                dr = cmd.ExecuteReader();
                    
                if (dr.HasRows)
                {
                  
                    if (dr.Read())
                    {
                        Bk1AccessionNumTxt.Text = dr["AccessionNumber"].ToString();
                        Bk1NameTxt.Text = dr["Title"].ToString();
                        
                     //   AdmisNumTxt.Text = dr["select "].ToString();
                       
                    }
                    TakenBooksCount1();    
                }
               // dr.Close();
                  

           
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

        private void Bk2AccessionNumTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  Register_Books_BkNo where AccessionNumber= @2", Con);

                cmd.Parameters.AddWithValue("@2", Bk2AccessionNumTxt.Text);
                dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {

                    if (dr.Read())
                    {
                        Bk2AccessionNumTxt.Text = dr["AccessionNumber"].ToString();
                        Bk2NameTxt.Text = dr["Title"].ToString();

                        //   AdmisNumTxt.Text = dr["select "].ToString();

                    }
                    TakenBooksCount2(); 
                }
                // dr.Close();



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

        public void TakenBooksCount1()
        {
            int Count = 0;
            if ((Bk1AccessionNumTxt.Text != null) && (Bk2AccessionNumTxt.Text != null))
            {
                Count = 1;
                TakenBooks.Text = "" + Count;
            }
         /*   else if (Bk1AccessionNumTxt.Text != null && Bk2AccessionNumTxt.Text == null)
            {
                Count = 1;
                AvailCopyTxt.Text = "1" ;
            }*/
            //if (Bk2AccessionNumTxt.Text != null) //&& Bk2AccessionNumTxt.Text != null)
            
        }

        public void TakenBooksCount2()
        {
            int Count = 0;
            if ((Bk1AccessionNumTxt.Text != null) && (Bk2AccessionNumTxt.Text != null))
            {
                Count = 2;
                TakenBooks.Text = "" + Count;
            }
            //TakenBooksCount1();
            /*   else if (Bk1AccessionNumTxt.Text != null && Bk2AccessionNumTxt.Text == null)
               {
                   Count = 1;
                   AvailCopyTxt.Text = "1" ;
               }*/
            //if (Bk2AccessionNumTxt.Text != null) //&& Bk2AccessionNumTxt.Text != null)

        }

        private void IssueBk_Click(object sender, EventArgs e)
        {
            
                    
            try
            {
                if (AdmisNumTxt.Text != "" & IsDatedtp.Text != "" & RetDatedtp.Text != "" & Bk1AccessionNumTxt.Text != "" & Bk1NameTxt.Text != "" & TakenBooks.Text != "")
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("select * from Register_Books_BkNo where AccessionNumber=@a  ", Con);
                    if(Bk2AccessionNumTxt.Text!="")
                 
                    
                  //  MessageBox.Show(Bk1AccessionNumTxt.Text);
                    cmd.Parameters.AddWithValue("@a", Bk1AccessionNumTxt.Text);
                   

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        bkid = dr["BookID"].ToString();
                        quan = Convert.ToInt32(dr["Quantity"]);
                    }

                    dr.Close();
                    Con.Close();
                    ReduceCount();

                   
                    if (Bk2AccessionNumTxt.Text !="")
                    {
                        
                        Con.Open();
                        SqlCommand cmd1 = new SqlCommand("select * from Register_Books_BkNo where AccessionNumber=@a  ", Con);



                        //  MessageBox.Show(Bk1AccessionNumTxt.Text);
                        cmd1.Parameters.AddWithValue("@a", Bk2AccessionNumTxt.Text);


                        SqlDataReader dr1;
                        dr1 = cmd1.ExecuteReader();
                        if (dr1.Read())
                        {
                            bkid = dr1["BookID"].ToString();
                            quan = Convert.ToInt32(dr1["Quantity"]);
                        }

                        dr1.Close();
                        Con.Close();
                        Con.Open();
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO Issue_books ( EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber, Book1Name,Bk2AccessionNumber,Book2Name,Amount) VALUES (@1,@2,@3,@4,@5,@6,@7,@8)", Con);
                        cmd2.Parameters.AddWithValue("@1", AdmisNumTxt.Text);
                        cmd2.Parameters.AddWithValue("@2", IsDatedtp.Text);
                        cmd2.Parameters.AddWithValue("@3", RetDatedtp.Text);
                        cmd2.Parameters.AddWithValue("@4", Bk1AccessionNumTxt.Text);
                        cmd2.Parameters.AddWithValue("@5", Bk1NameTxt.Text);
                        cmd2.Parameters.AddWithValue("@6", Bk2AccessionNumTxt.Text);
                        cmd2.Parameters.AddWithValue("@7", Bk2NameTxt.Text);
                        cmd2.Parameters.AddWithValue("@8", TakenBooks.Text);
                        cmd2.ExecuteNonQuery();
                        Con.Close();  
                        ReduceCount();

                    }
               /*     if (Bk2AccessionNumTxt.Text != "")
                    {
                        MessageBox.Show("fdsf");
                   
                    }*/
                    else {
                        Con.Open();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO Issue_books ( EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber, Book1Name,Amount) VALUES (@1,@2,@3,@4,@5,@8)", Con);
                    cmd3.Parameters.AddWithValue("@1", AdmisNumTxt.Text);
                    cmd3.Parameters.AddWithValue("@2", IsDatedtp.Text);
                    cmd3.Parameters.AddWithValue("@3", RetDatedtp.Text);
                    cmd3.Parameters.AddWithValue("@4", Bk1AccessionNumTxt.Text);
                    cmd3.Parameters.AddWithValue("@5", Bk1NameTxt.Text);
                    
                    cmd3.Parameters.AddWithValue("@8", TakenBooks.Text);
                    cmd3.ExecuteNonQuery();
                    Con.Close();
                    }
                   
                 
                    displaylist();
                    
                //    calculateTotalBooks();
                    reset();


                    MessageBox.Show("New Book has been Issued.");
                   
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
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select EmpIndexAdmissioNum,IssuedDate, ReturnDate, Bk1AccessionNumber,Book1Name, Bk2AccessionNumber,Book2Name,Amount from Issue_books", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            IssueGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = IssueGrid.Rows.Add();
                IssueGrid.Rows[n].Cells[0].Value = item[0].ToString();
               
                IssueGrid.Rows[n].Cells[1].Value = item[1].ToString();
                IssueGrid.Rows[n].Cells[2].Value = item[2].ToString();
                IssueGrid.Rows[n].Cells[3].Value = item[3].ToString();
                IssueGrid.Rows[n].Cells[4].Value = item[4].ToString();
                IssueGrid.Rows[n].Cells[5].Value = item[5].ToString();
                IssueGrid.Rows[n].Cells[6].Value = item[6].ToString();
                IssueGrid.Rows[n].Cells[7].Value = item[7].ToString();
            }
            Con.Close();
       
        }

        public void reset()
        {
            AdmisNumTxt.Text = "";
            IsDatedtp.Text = "";
            RetDatedtp.Text = "";
            Bk1AccessionNumTxt.Text = "";
            Bk1NameTxt.Text = "";
            Bk2AccessionNumTxt.Text = "";
            Bk2NameTxt.Text = "";
            TakenBooks.Text = "";
        }

        private void Issue_Load(object sender, EventArgs e)
        {
            displaylist();
        }

        public void ReduceCount()
        {
          Con.Open();

            SqlCommand cmd = new SqlCommand("update  Register_Books_BkNo set Quantity=@2 where BookID=@3 and Quantity>0", Con);
           

            cmd.Parameters.AddWithValue("@2",quan=quan-1 );
            cmd.Parameters.AddWithValue("@3", bkid);

            cmd.ExecuteNonQuery();

            Con.Close();
            
        }

        private void IssueGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
