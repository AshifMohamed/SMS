using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace WindowsFormsApplication4
{
  public   class AddEmployee
    {

      SqlConnection conn = DBAccess.GetConnection();
           

        public  void addEmp(String pFname,String pLname,DateTime pdob,String pvalue,String pnic,String pmaritial,String prel,String pMob,String pph,String pmail,String ptype,String pcadd,String ppadd,String pQual,DateTime pjdate,String psal)
            
           {   
            try
            {
               
                conn.Open();
          
                SqlCommand Cmd = new SqlCommand( "INSERT INTO RegEmployee (FirstName, LastName,DOB, Gender,NIC, MartialStatus, Religion, Mobile, Phone, Email,EmployeeType,CurrentAddress,PermanantAddress,Qualifications,JoinDate,Salary) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11,@12, @13, @14, @15,@16)SELECT SCOPE_IDENTITY()",conn);
             
                                          
                Cmd.Parameters.AddWithValue("@1", pFname);
                Cmd.Parameters.AddWithValue("@2", pLname);
                Cmd.Parameters.AddWithValue("@3", pdob);
                Cmd.Parameters.AddWithValue("@4", pvalue);
                Cmd.Parameters.AddWithValue("@5", pnic);
                Cmd.Parameters.AddWithValue("@6", pmaritial);
                Cmd.Parameters.AddWithValue("@7", prel);
                Cmd.Parameters.AddWithValue("@8", pMob);
                Cmd.Parameters.AddWithValue("@9", pph);
                Cmd.Parameters.AddWithValue("@10", pmail);
                Cmd.Parameters.AddWithValue("@11", ptype);
                Cmd.Parameters.AddWithValue("@12", pcadd);
                Cmd.Parameters.AddWithValue("@13", ppadd);
                Cmd.Parameters.AddWithValue("@14", pQual);
                Cmd.Parameters.AddWithValue("@15", pjdate);
                Cmd.Parameters.AddWithValue("@16",psal );
              
              
               // int id=Convert.ToInt32(Cmd.ExecuteNonQuery());
                int id = Convert.ToInt32(Cmd.ExecuteScalar());
                String user = "WE000" + id.ToString();
                SqlCommand Cmd1 = new SqlCommand("INSERT INTO Login (Username, Password,Role ) VALUES(@17,@17,@18);", conn);
                Cmd1.Parameters.AddWithValue("@17", user);
                Cmd1.Parameters.AddWithValue("@18", "Staff");
                Cmd1.ExecuteNonQuery();

                SqlCommand Cmd2 = new SqlCommand("INSERT INTO EmpLeave (ID, LeaveBalance ) VALUES(@19,@20);", conn);
                Cmd2.Parameters.AddWithValue("@19", user);
                Cmd2.Parameters.AddWithValue("@20", 40);
                Cmd2.ExecuteNonQuery();
                conn.Close();

               // MetroFramework.MetroMessageBox.Show(this,"Please Fill All the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("New Employee Added Successfully");
               // RegisterEmployee rg = new RegisterEmployee();
              //  rg.clear();

            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("NIC already exists");
                }
            }

            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

           
        }  


            
            
       /*    public  void addEmp(String pfuname,String pFname,String pLname,String pdob,String pvalue,String pmaritial,String prel,String pMob,String pph,String pmail,String pblood,String pcadd,String ppadd,String ppqual,String pEqual,String ptype,String pjdate,String psal)
            
           {   
            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlCommand newCmd = conn.CreateCommand();

                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;



                newCmd.CommandText = "INSERT INTO RegEmployee (FullName, FirstName, LastName,DOB, Gender, MartialStatus, Religion, Mobile, Phone, Email,BloodGroup,CurrentAddress,PermanantAddress,ProfessionalQualifications,EducationalQualifications,EmployeeType,JoinDate,BasicSalary) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11,@12, @13, @14, @15, @16, @17, @18)";
                //cmd.CommandType = CommandType.Text;(FullName, FirstName, LastName, @1, @2, @3, //default
       //          <add name="ConString" connectionString=" Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Ashif\ITp_prototype\ITp_project\ITp_project\ITP.mdf;Initial Catalog=ITp;Integrated Security=True;Connect Timeout=30"
  //  providerName="System.Data.SqlClient"/>

                newCmd.Parameters.AddWithValue("@1", pfuname);
                newCmd.Parameters.AddWithValue("@2", pFname);
                newCmd.Parameters.AddWithValue("@3", pLname);
                newCmd.Parameters.AddWithValue("@4", pdob);
                newCmd.Parameters.AddWithValue("@5", pvalue);
                newCmd.Parameters.AddWithValue("@6", pmaritial);
                newCmd.Parameters.AddWithValue("@7", prel);
                newCmd.Parameters.AddWithValue("@8", pMob);
                newCmd.Parameters.AddWithValue("@9", pph);
                newCmd.Parameters.AddWithValue("@10", pmail);
                newCmd.Parameters.AddWithValue("@11", pblood);
                newCmd.Parameters.AddWithValue("@12", pcadd);
                newCmd.Parameters.AddWithValue("@13", ppadd);
                newCmd.Parameters.AddWithValue("@14", ppqual);
                newCmd.Parameters.AddWithValue("@15", pEqual);
                newCmd.Parameters.AddWithValue("@16",ptype);
                newCmd.Parameters.AddWithValue("@17", pjdate);
                newCmd.Parameters.AddWithValue("@18",psal );
   
                //connection.OpenConnection();
                newCmd.ExecuteNonQuery();
               

                MessageBox.Show("New buyer added to the database");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }*/
    }
}
