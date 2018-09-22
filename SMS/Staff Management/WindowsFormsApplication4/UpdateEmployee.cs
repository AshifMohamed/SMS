using WindowsFormsApplication4;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    class UpdateEmployee
    {
        SqlConnection conn = DBAccess.GetConnection();
        public void UpdateEmployees(string pid,String pFname, String pLname, DateTime pdob, String pvalue,String pnic, String pmaritial, String prel, String pMob, String pph, String pmail, String ptype, String pcadd, String ppadd, String pQual, DateTime pjdate, String psal)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Update RegEmployee set FirstName=@1, LastName=@2,DOB=@3, Gender=@4,NIC=@16, MartialStatus=@5, Religion=@6, Mobile=@7, Phone=@8, Email=@9,EmployeeType=@10,CurrentAddress=@11,PermanantAddress=@12,Qualifications=@13,JoinDate=@14,Salary=@15 where ID = '" + pid+"'", conn);



                Cmd.Parameters.AddWithValue("@1", pFname);
                Cmd.Parameters.AddWithValue("@2", pLname);
                Cmd.Parameters.AddWithValue("@3", pdob);
                Cmd.Parameters.AddWithValue("@4", pvalue);
                Cmd.Parameters.AddWithValue("@5", pmaritial);
                Cmd.Parameters.AddWithValue("@6", prel);
                Cmd.Parameters.AddWithValue("@7", pMob);
                Cmd.Parameters.AddWithValue("@8", pph);
                Cmd.Parameters.AddWithValue("@9", pmail);
                Cmd.Parameters.AddWithValue("@10", ptype);
                Cmd.Parameters.AddWithValue("@11", pcadd);
                Cmd.Parameters.AddWithValue("@12", ppadd);
                Cmd.Parameters.AddWithValue("@13", pQual);
                Cmd.Parameters.AddWithValue("@14", pjdate);
                Cmd.Parameters.AddWithValue("@15", psal);
                Cmd.Parameters.AddWithValue("@16", pnic);

                //connection.OpenConnection();
                Cmd.ExecuteNonQuery();
                conn.Close();
              
                MessageBox.Show("Employee is Updated");
                  

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }  
    }
}
