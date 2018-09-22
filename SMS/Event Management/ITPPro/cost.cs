using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ITPPro
{
    class cost
    {
            SqlConnection con = DBAccess.GetConnection();
         public void CreateCost(string pfname, string pdes, string pnuni, string punic, string ptot, string peid)
         {

             con.Open();
             try
             {
                

                 SqlCommand Cmd = new SqlCommand("INSERT INTO Cost (FacName , Descp, Nouni, unico, tot, eid) VALUES (@1, @2, @3, @4, @5,@6)", con);

                 Cmd.Parameters.AddWithValue("@1", pfname);
                 Cmd.Parameters.AddWithValue("@2", pdes);
                 Cmd.Parameters.AddWithValue("@3", pnuni);
                 Cmd.Parameters.AddWithValue("@4", punic);
                 Cmd.Parameters.AddWithValue("@5", ptot);
                 Cmd.Parameters.AddWithValue("@6", peid);
             
             


                 

                 Cmd.ExecuteNonQuery();
                

                 finace d = new finace();
                 d.disp();
                 MessageBox.Show("Event Added");

             }
                 


             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
             con.Close();
         }

        
       
    }
    
}
