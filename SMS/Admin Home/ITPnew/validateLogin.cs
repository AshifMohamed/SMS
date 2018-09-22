using Bookshop_Management;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4;
namespace ITPnew
{
    class validateLogin
    {
        SqlConnection conn = DBAccess.GetConnection();
        public Boolean isLogin(string user, string pass)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from Login where Username=@username and Password=@password", conn);
                Cmd.Parameters.AddWithValue("@username", user);
                Cmd.Parameters.AddWithValue("@password", pass);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    //  metroLabel15.Text = dr["ID"].ToString();
                    String Username = dr["Username"].ToString();
                    String Password = dr["Password"].ToString();
                    String Role = dr["Role"].ToString();

                    conn.Close();
                    if (Role == "Bookshop")
                    {

                        Home st = new Home();
                      //  st.getLoginDetails(Username, Role);

                        st.Show();

                        return true;
                    }
                    if (Role == "Library")
                    {

                        ITPLibrary.LibraryHome st = new ITPLibrary.LibraryHome();
                        //  st.getLoginDetails(Username, Role);

                        st.Show();

                        return true;
                    }

                    if (Role == "Staff")
                    {

                         StaffMain st = new StaffMain();
                         st.getLoginDetails(Username, Role);
                            
                         st.Show();

                        return true;
                    }
                    else if (Role == "Admin")
                    {


                        adhome st = new adhome();
                    //    st.getLoginDetails(Username, Role);

                        st.Show();

                        return true;
                    }
                    return true;

                }

                else
                {
                    MessageBox.Show("Invalid Login Credentials , Please try Again Later");
                    return false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
