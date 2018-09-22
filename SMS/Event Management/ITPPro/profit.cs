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
    class profit
    {
        SqlConnection con = DBAccess.GetConnection();

        public void Createprofit(string psname, string pdesi, string pnunii, string punici, string ptoti, string peid)
        {


            try
            {
                con.Open();

                SqlCommand Cmd = new SqlCommand("INSERT INTO Profit (scrname , descp, nouni, unico, tot,eid) VALUES (@1, @2, @3, @4, @5,@6)", con);

                Cmd.Parameters.AddWithValue("@1", psname);
                Cmd.Parameters.AddWithValue("@2", pdesi);
                Cmd.Parameters.AddWithValue("@3", pnunii);
                Cmd.Parameters.AddWithValue("@4", punici);
                Cmd.Parameters.AddWithValue("@5", ptoti);
                Cmd.Parameters.AddWithValue("@6", peid);

                

                Cmd.ExecuteNonQuery();
                con.Close();

                finace c = new finace();
                c.profdis();
                MessageBox.Show("Event Added");

            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
