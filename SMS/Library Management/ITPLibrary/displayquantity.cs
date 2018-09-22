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
    public partial class displayquantity : MetroFramework.Forms.MetroForm
    {

        SqlConnection Con = DBAccess.GetConnection();
        public displayquantity()
        {
            InitializeComponent();
        }

        String BID;

        SqlDataReader dr;


        private void displayquantity_Load(object sender, EventArgs e)
        {
            displaylist();
        }

        void displaylist()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookID,Title,Quantity, COUNT(BookID) as 'OriginalQuanitity' from Register_Books_BkNo group by BookID,Title ,Quantity ", Con);
            DataTable dt = new DataTable();
     
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Register_Books_BkNo");
            metroGrid1.DataSource = ds.Tables["Register_Books_BkNo"].DefaultView;
            cmd.ExecuteNonQuery();
            metroGrid1.Columns[2].HeaderText = "Available Quantity";

            Con.Close();

          

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
                  /*  Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO DisplayQuantity( bookId,type,quantity) VALUES (@1,@2,@3)SELECT SCOPE_IDENTITY();", Con);              
                    cmd.Parameters.AddWithValue("@1", accessionNumtxt.Text);
                    cmd.Parameters.AddWithValue("@2", date.Text);
                    cmd.Parameters.AddWithValue("@3", author.Text);
                    
                    cmd.ExecuteNonQuery();
            */
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  if (e.RowIndex < 0 || e.ColumnIndex != metroGrid1.Columns["StatusRow"].Index)
                return;
            else
            {
                BID = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }*/
        }


    }
}
