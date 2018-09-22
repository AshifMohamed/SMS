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
    class eventsinfo
    {

        SqlConnection con = DBAccess.GetConnection();
       
        public void createEve(string pename, string pdes, string pvenue, string pmainorg, string pstdate, string pendate, string psttime, string pentime)
        {


            try
            {
                con.Open();

                SqlCommand Cmd = new SqlCommand("INSERT INTO EventDe (Ename, EDescription, Venue, MainOrganizer, StartDate, StartTime, EndDate, EndTime ) VALUES (@2, @3, @4, @5, @6, @7, @8, @9)", con);

                //Cmd.Parameters.AddWithValue("@1", peid);
                Cmd.Parameters.AddWithValue("@2", pename);
                Cmd.Parameters.AddWithValue("@3", pdes);
                Cmd.Parameters.AddWithValue("@4", pvenue);
                Cmd.Parameters.AddWithValue("@5", pmainorg);
                Cmd.Parameters.AddWithValue("@6", pstdate);
                Cmd.Parameters.AddWithValue("@7", psttime);
                Cmd.Parameters.AddWithValue("@8", pendate);
                Cmd.Parameters.AddWithValue("@9", pentime);



                Cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Event Added");

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
