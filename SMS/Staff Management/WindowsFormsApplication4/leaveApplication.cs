using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class leaveApplication : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        String Username;
        public leaveApplication()
        {
            InitializeComponent();
          //  metroDateTime2.Value = DateTime.Today.AddDays(1).Date;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

      

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
           //int days = 0;
          ///  calcNoOfDays();
         //   FillRemainder();
          /*  if(metroDateTime2.Enabled == false)
            {
                metroDateTime2.Enabled = true;
                calcNoOfDays();
            }
            else
            {
                metroDateTime2.Enabled = false;
                metroLabel8.Text = "Half Day";
            }*/
               
        }

        private void leaveApplication_Load(object sender, EventArgs e)
        {
          //  metroLabel8.Text = "Half Day";

            DateTime dt = DateTime.Now.AddDays(1);
            metroDateTime1.Value = DateTime.Today.AddDays(1);
            metroDateTime2.Value = DateTime.Today.AddDays(1);
          //  MessageBox.Show(dt.ToShortDateString());
               // this.metroButton1.Enabled = false;
                metroLabel8.Text = "1";
           
               // FillDetails(Username);
               // FillRemainder();
          
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = metroDateTime1.Value;
            DateTime endDate = metroDateTime2.Value;

            if (ValidateEmployee.isInvalidEndDate(endDate.Date,startDate.Date))
            {
                errorProvider1.SetError(metroDateTime2, "Invalid Date");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroButton1.Enabled = true;

            }
            calcNoOfDays();
            FillRemainder();
        }

        public void FillDetails(String Username)
        {
           
            string empId=FillEmpID(Username);
            FillAvailableLeave(empId);
            FillRemainder();
        }
        public string FillEmpID(String user)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select ID,FirstName from RegEmployee where ID= @user"  , conn);
                Cmd.Parameters.AddWithValue("@user", user);
                string id;
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["ID"].ToString();
                   metroLabel12.Text = id.ToString();
                    metroLabel11.Text = dr["FirstName"].ToString();
                    conn.Close();
                    return id;
                }
                else
                {
                    conn.Close();
                    return "-1";
                }
                
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "-1";
            }
        }

        public void FillAvailableLeave(string id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select LeaveBalance from EmpLeave where ID='" + id+"'", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {

                    metroLabel9.Text = dr["LeaveBalance"].ToString();

                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void calcNoOfDays()
        {
            DateTime start = metroDateTime1.Value.Date;
            DateTime end = metroDateTime2.Value.Date;
           
            int day=(end - start).Days;
            
                if (start == end)
                {
                    
                    day = 1;
             
                }
                else
                {
                   // day = tspan.Days + 2;
                    day = (end - start).Days+1;
                }
            
            

            metroLabel8.Text = day.ToString();
        }

        public void FillRemainder()
        {
            int available = Convert.ToInt32(metroLabel9.Text);
            int noOfDays = Convert.ToInt32(metroLabel8.Text);
            metroLabel10.Text = (available - noOfDays).ToString();
            metroButton1.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("INSERT INTO EmpLeaveRequest (ID,FirstName, LeaveStartDate,LeaveEndDate,NoOfDays,AvailableBalanceBefore,AvailableBalanceAfter,ApplyDate,Status) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9)" , conn);

                Cmd.Parameters.AddWithValue("@1", metroLabel12.Text);
                Cmd.Parameters.AddWithValue("@2", metroLabel11.Text);
                Cmd.Parameters.AddWithValue("@3", metroDateTime1.Value);
                Cmd.Parameters.AddWithValue("@4", metroDateTime2.Value);
                Cmd.Parameters.AddWithValue("@5", metroLabel8.Text);
                Cmd.Parameters.AddWithValue("@6", metroLabel9.Text);
                Cmd.Parameters.AddWithValue("@7", metroLabel10.Text);
                Cmd.Parameters.AddWithValue("@8", DateTime.Today);
                Cmd.Parameters.AddWithValue("@9", "Pending");
        
                //connection.OpenConnection();
                Cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Leave Request has been sent");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = metroDateTime1.Value;
            DateTime endDate = metroDateTime2.Value;
            if (ValidateEmployee.isInvalidStartDate(startDate.Date))
            {
                errorProvider1.SetError(metroDateTime1, "Invalid Date");
                metroButton1.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.Clear();
                metroButton1.Enabled = true;
              
            }
            if (ValidateEmployee.isInvalidEndDate(endDate.Date, startDate.Date))
            {
                errorProvider1.SetError(metroDateTime2, "Invalid Date");
                metroButton1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroButton1.Enabled = true;

            }
        }

        public void getUser(String user )
        {
           // metroLabel12.Text = username;
            Username = user;
            MessageBox.Show(Username);
        }

    }
}