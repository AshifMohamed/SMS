using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ITPPro
{
    class sponserinfo
    {

        SqlConnection con = DBAccess.GetConnection();

        public void addsponser(string psname, string ptype, string paddress, string pcat, string pdesc, string pcon, string pemail, string pamount, string peid)
        {


            try
            {
                con.Open();

                SqlCommand Cmd = new SqlCommand("INSERT INTO Sponser (SponserName, Type, Address, Category, Description, Contact, Email, Amount,eid ) VALUES (@2, @3, @4, @5, @6, @7, @8, @9,@10)", con);

                //Cmd.Parameters.AddWithValue("@1", peid);
                Cmd.Parameters.AddWithValue("@2", psname);
                Cmd.Parameters.AddWithValue("@3", ptype);
                Cmd.Parameters.AddWithValue("@4", paddress);
                Cmd.Parameters.AddWithValue("@5", pcat);
                Cmd.Parameters.AddWithValue("@6", pdesc);
                Cmd.Parameters.AddWithValue("@7", pcon);
                Cmd.Parameters.AddWithValue("@8", pemail);
                Cmd.Parameters.AddWithValue("@9", pamount);
                Cmd.Parameters.AddWithValue("@10", peid);




                Cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Sponser Details Added");

            }

            catch (Exception ex)
            {
                //if (ex.HResult == -2146232060)
                //  MessageBox.Show("EventID already exist!!!");
                //else
                MessageBox.Show(ex.Message);
            }


        }

      
    }
}
