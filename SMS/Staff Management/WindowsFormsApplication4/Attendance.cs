using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
namespace WindowsFormsApplication4
{
    public partial class Attendance : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
           // metro.Columns.Add("ID", 100);
          //  metroListView1.Columns.Add("First Name", 100);
            metroLabel1.Text = DateTime.Today.Date.ToString("yyyy/MM/dd");
            AttendanceFill();
          //  StatusFill();
        }
        
        public void AttendanceFill()
        {
           
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName from RegEmployee ", conn);

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(String));
                dt.Columns.Add("FirstName", typeof(String));
                dt.Columns.Add("Status", typeof(String));
                    
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();

                while (dr.Read())
                {
 
                    {
                        dt.Rows.Add(dr["ID"], dr["FirstName"]);
                    }
                    
                }
                 metroGrid1.DataSource =dt;
                 metroGrid1.Columns[0].DisplayIndex = 3;
                 metroGrid1.Columns[2].HeaderText = "First Name";
            //    Cmd.ExecuteNonQuery();
                 dr.Close();
                conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                conn.Open();
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    string empID = row.Cells["ID"].Value.ToString();
                    DateTime today = DateTime.Today.Date;
                    String pFname = row.Cells["FirstName"].Value.ToString();
                 //   String stat = row.Cells["Status"].Value.ToString();
                    SqlCommand Cmd = new SqlCommand(" select *  from ApprovedLeave where LeaveDate = '"+today+"' AND ID='"+empID+"' ", conn);
                    SqlDataReader dr;
                    dr = Cmd.ExecuteReader();

                   
                    if (dr.Read())
                    {
                        
                        row.Cells[metroGrid1.Columns["Status"].Index].Value = "A";
                      
                        metroGrid2.Rows.Add(empID, pFname);
                    
                        
                        dr.Close();
                    }
                    else
                    {
                        row.Cells[metroGrid1.Columns["Status"].Index].Value = "P";                                          
                        dr.Close();
                    }
                    
                }
              //  metroListView1.View = View.Details;
                conn.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void StatusFill()
        {
            foreach (DataGridViewRow row in  metroGrid1.Rows )
            {
               //  metroGrid1.Rows.Add("P");
            //    DataGridViewCell NewCell = new DataGridViewTextBoxCell();//Create New Cell
             //   NewCell.Value = "P";
             //   DataGridViewRow row = new DataGridViewRow();
                
             //   row.Cells.Add(NewCell);
               
              //  row.Cells["Status"].Value = "P";
                row.Cells[metroGrid1.Columns["Status"].Index].Value = "XYZ";
                
                 
            }
          //  metroGrid1.Rows[1].Cells["Status"].Value = "Pre";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    string empID = row.Cells["ID"].Value.ToString();
                    DateTime today = DateTime.Today.Date;
                    String pFname = row.Cells["FirstName"].Value.ToString();                                                     
                    String stat=row.Cells["Status"].Value.ToString();

                    SqlCommand Cmd3 = new SqlCommand("INSERT INTO EmpAttendance (ID,FirstName,Day,Attendant) VALUES (@1, @2, @3, @4);", conn);


                    Cmd3.Parameters.AddWithValue("@1", empID);
                    Cmd3.Parameters.AddWithValue("@2", pFname);
                    Cmd3.Parameters.AddWithValue("@3", today);
                    Cmd3.Parameters.AddWithValue("@4", stat);


                    Cmd3.ExecuteNonQuery();
                

                    if(stat=="A")
                    {
                        int balance;
                        SqlCommand Cmd1 = new SqlCommand("select leaveBalance from EmpLeave  where ID='" + empID + "'", conn);
                         SqlDataReader dr;
                         dr = Cmd1.ExecuteReader();
                         if (dr.Read())
                         {
                            
                              balance = Convert.ToInt32(dr["leaveBalance"]);
                              dr.Close();  
                              balance=balance-1;
                              SqlCommand Cmd2 = new SqlCommand("UPDATE EmpLeave set leaveBalance=@7 where ID='" + empID + "'", conn);
                              Cmd2.Parameters.AddWithValue("@7", balance );
                              Cmd2.ExecuteNonQuery();
                              MessageBox.Show("hi");
                         }
                                  
                    }       
                     
                }
                MessageBox.Show("Successful");
                
                conn.Close();

            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Attendance Record for today already added");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          // metroListView1.Visible = true;
            metroGrid2.Visible = true;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                if (e.ColumnIndex == metroGrid1.Columns["Change"].Index)
                {
                    if(metroGrid1.Rows[e.RowIndex].Cells["Status"].Value.ToString() =="P")
                    {
                        metroGrid1.Rows[e.RowIndex].Cells["Status"].Value = "A";
                    }
                    else
                        metroGrid1.Rows[e.RowIndex].Cells["Status"].Value = "P";
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
     
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           // reportView rp = new reportView();
           // rp.Show();
        }

       
    }
}
