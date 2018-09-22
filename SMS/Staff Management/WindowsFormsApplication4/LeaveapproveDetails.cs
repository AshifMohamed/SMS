using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication4
{
    public partial class LeaveapproveDetails : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        String start;
           
        public LeaveapproveDetails()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LeaveapproveDetails_Load(object sender, EventArgs e)
        {
          /* try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from EmpLeaveRequest ", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                  metroLabel11.Text = dr["ID"].ToString();
                  metroLabel12.Text = dr["FirstName"].ToString();
                  String start = dr["LeaveStartDate"].ToString();
                  metroLabel13.Text = DateTime.Parse(start).ToShortDateString();
                  String end = dr["LeaveEndDate"].ToString();
                  metroLabel14.Text = DateTime.Parse(end).ToShortDateString();
                  metroLabel18.Text = dr["NoOfDays"].ToString();
                  metroLabel19.Text = dr["AvailableBalanceBefore"].ToString();
                  metroLabel15.Text = dr["AvailableBalanceAfter"].ToString();
                  String apply = dr["ApplyDate"].ToString();
                  metroLabel16.Text = DateTime.Parse(apply).ToShortDateString();
                 metroComboBox1.Text = dr["Status"].ToString();
                }

                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            metroComboBox1.SelectedIndex = 0;
        }

        public void ViewLeave(int id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from EmpLeaveRequest where RequestID=" + id + "", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    metroLabel11.Text = dr["ID"].ToString();
                    metroLabel12.Text = dr["FirstName"].ToString();
                    start = dr["LeaveStartDate"].ToString();
                    metroLabel13.Text = DateTime.Parse(start).ToShortDateString();
                    String end = dr["LeaveEndDate"].ToString();
                    metroLabel14.Text = DateTime.Parse(end).ToShortDateString();
                    metroLabel18.Text = dr["NoOfDays"].ToString();
                    metroLabel19.Text = dr["AvailableBalanceBefore"].ToString();
                    metroLabel15.Text = dr["AvailableBalanceAfter"].ToString();
                    String apply = dr["ApplyDate"].ToString();
                    metroLabel16.Text = DateTime.Parse(apply).ToShortDateString();
                    metroComboBox1.Text = dr["Status"].ToString();
                
                   
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                if(metroComboBox1.SelectedItem.ToString() =="Approve")
                {

                    DateTime dt = Convert.ToDateTime(start);
                   // DateTime dt = DateTime.Today;//= DateTime.Parse(start);
                  //  metroLabel13.Text = DateTime.Parse(start).ToShortDateString();
                    int j=Convert.ToInt32(metroLabel18.Text.Trim());
                  
                    for(int i=0;i<j;i++)
                    {
                        SqlCommand Cmd1 = new SqlCommand("INSERT INTO ApprovedLeave (ID, LeaveDate) VALUES (@1, @2)", conn);

                        Cmd1.Parameters.AddWithValue("@1", metroLabel11.Text);
                        Cmd1.Parameters.AddWithValue("@2", dt.AddDays(i));

                        Cmd1.ExecuteNonQuery();
                    }
                }

                SqlCommand Cmd = new SqlCommand("delete from  EmpLeaveRequest  where ID = @id", conn);
               // SqlCommand Cmd = new SqlCommand("Update EmpLeaveRequest set Status=@status  where ID = @id" , conn);


                Cmd.Parameters.AddWithValue("@id", metroLabel11.Text);
        
                Cmd.ExecuteNonQuery();
                conn.Close();

                sendmail();
                metroPanel3.Visible = true;
             //   DialogResult = DialogResult.OK;
               
                
               // this.Hide();
               
              
               
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public void sendmail()
        {
            try
            {
                string id = metroLabel11.Text;
              
                string status = metroComboBox1.SelectedItem.ToString();
                conn.Open();
                SqlCommand Cmd = new SqlCommand("select Email from RegEmployee where ID=@id", conn);

                Cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    metroTextBox1.Text = dr["Email"].ToString();

                }
             
                conn.Close();

                String message = "Your Leave Request has been " + status;
                richTextBox1.Text = message;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(
                    "mameershahib@gmail.com", "ameer497191"); //enter your gmail id and password

                MailMessage msg = new MailMessage();
                msg.To.Add(metroTextBox1.Text);
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Subject = metroTextBox1.Text;
                msg.Body = richTextBox1.Text;

                client.Send(msg);
                MessageBox.Show("Email has been sent to the Staff");
                DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}