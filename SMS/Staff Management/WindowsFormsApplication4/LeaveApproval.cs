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
    public partial class LeaveApproval : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        string eid;
        String status;
        public LeaveApproval()
        {
            InitializeComponent();
        }

        private void LeaveApproval_Load(object sender, EventArgs e)
        {
            
           
            TableLoad();
            ColumnLoad();

        }
        public void TableLoad()
        {
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select RequestID, ID,FirstName,LeaveStartDate,LeaveEndDate,Status from EmpLeaveRequest ", conn);



                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "EmpLeaveRequest");
                metroGrid1.DataSource = ds.Tables["EmpLeaveRequest"].DefaultView;


                Cmd.ExecuteNonQuery();
                conn.Close();

               
                     


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ColumnLoad()
        {
            DataGridViewLinkColumn Col = new DataGridViewLinkColumn();
            Col.UseColumnTextForLinkValue = true;
            Col.Name = "Option";
            Col.HeaderText = "Option";
            Col.Text = "Action";
            Col.Width = 100;
            //  metroGrid1.Columns.Add(colname, colname);
            metroGrid1.Columns.Insert(6, Col);
        }

      

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != metroGrid1.Columns["Option"].Index ) 
                return;
            else
            {
                int empId = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells["RequestID"].Value);
               
                 /*   LeaveapproveDetails la=new LeaveapproveDetails();
                    la.ViewLeave(empId);
                    la.Location = new Point(100, 100);

                    la.Show();*/

                using (LeaveapproveDetails la = new LeaveapproveDetails())
                {
                    la.ViewLeave(empId);
                    DialogResult result = la.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        TableLoad();
                    }
                }
             }
                 
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName,LeaveStartDate,LeaveEndDate,Status from EmpLeaveRequest where FirstName like '" + metroTextBox1.Text + "%'", conn);


                Cmd.ExecuteNonQuery();



                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "RegEmployee");
                metroGrid1.DataSource = ds.Tables["RegEmployee"].DefaultView;



                Cmd.ExecuteNonQuery();
                conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
       

      

        public void getID(string id,string stat)
        {
            eid = id;
            status = stat;
        }

    }
}