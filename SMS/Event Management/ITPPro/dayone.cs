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
    class dayone
    {
        SqlConnection con = DBAccess.GetConnection();

        public void Dayo(string ptimep, string pdesc, string ppersonp, string presponsp, string pteamp, string peid)
        {

            con.Open();
            try
            {


                SqlCommand Cmd = new SqlCommand("INSERT INTO Dayone (Time , Description, PersonInAction, Responsible, TeamLeader, eid) VALUES (@1, @2, @3, @4, @5,@6)", con);

                Cmd.Parameters.AddWithValue("@1", ptimep);
                Cmd.Parameters.AddWithValue("@2", pdesc);
                Cmd.Parameters.AddWithValue("@3", ppersonp);
                Cmd.Parameters.AddWithValue("@4", presponsp);
                Cmd.Parameters.AddWithValue("@5", pteamp);

                Cmd.Parameters.AddWithValue("@6", peid);




                Cmd.ExecuteNonQuery();


              
                MessageBox.Show("Item Added");

            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
