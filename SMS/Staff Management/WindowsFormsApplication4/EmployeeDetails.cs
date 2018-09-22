using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace WindowsFormsApplication4
{
    public partial class EmployeeDetails : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            TableLoad();
            ColumnLoad();
        }

        public void TableLoad()
        {
           
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName,LastName,DOB,Mobile,CurrentAddress,Salary from RegEmployee ", conn);

                

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "RegEmployee");
                metroGrid1.DataSource = ds.Tables["RegEmployee"].DefaultView;


                Cmd.ExecuteNonQuery();
                conn.Close();
                metroGrid1.Columns[4].HeaderText = "ID ";
                metroGrid1.Columns[5].HeaderText = "First Name ";
                metroGrid1.Columns[6].HeaderText = "Last Name ";
                metroGrid1.Columns[7].HeaderText = "D.O.B ";
                metroGrid1.Columns[8].HeaderText = "Mobile ";
                metroGrid1.Columns[9].HeaderText = "Current Address ";
                metroGrid1.Columns[10].HeaderText = "Salary ";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void ColumnLoad()
        {
           
            metroGrid1.Columns[0].DisplayIndex = 10;
            metroGrid1.Columns[1].DisplayIndex = 10;
            metroGrid1.Columns[2].DisplayIndex = 10;
            metroGrid1.Columns[3].DisplayIndex = 10;
        }
       
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName,LastName,DOB,Mobile,CurrentAddress,Salary from RegEmployee where FirstName like '" + metroTextBox1.Text + "%'", conn);


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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;
            else
            {
                string empId = metroGrid1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                if (e.ColumnIndex == metroGrid1.Columns["View"].Index)
               {
                    ViewEmployee vw=new ViewEmployee();
                    vw.ControlBox = true;
               // int empId = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                vw.ViewEmp(empId);
                vw.Location = new Point(100, 100);

                vw.Show();
               }
                 if (e.ColumnIndex == metroGrid1.Columns["Delete"].Index)
                 {
                     if (MessageBox.Show("Delete selected Employee?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                     {
                         DeleteEmp(empId);
                     }
                 }
                 if (e.ColumnIndex == metroGrid1.Columns["Update"].Index)
                 {
                    
                     UpdateEmp(empId);
                     
                 }
                 if (e.ColumnIndex == metroGrid1.Columns["PaySlip"].Index)
                 {
                     Salary sa = new Salary();
                     // int empId = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                     sa.FillSlip(empId);
           
                     sa.Location = new Point(100, 100);

                     sa.Show();
                 }
            }

        }
        public void DeleteEmp(string id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("delete  from RegEmployee where ID='" + id+"'", conn);



                //connection.OpenConnection();
                Cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee Deleted Successfully");
                TableLoad();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        public void UpdateEmp(string id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from RegEmployee where ID='" + id+"'", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    //  metroLabel15.Text = dr["ID"].ToString();
                    string empID = id;
                    string Fname = dr["FirstName"].ToString();
                    string Lname = dr["LastName"].ToString();
                    DateTime dob = Convert.ToDateTime(dr["DOB"]);
                    string gend = dr["Gender"].ToString();
                   // MessageBox.Show(gend);
                    string nic = dr["NIC"].ToString();
                    string maritial = dr["MartialStatus"].ToString();
                    string rel = dr["Religion"].ToString();
                    string Mob = dr["Mobile"].ToString();
                    string ph = dr["Phone"].ToString();
                    string mail = dr["Email"].ToString();
                    string type = dr["EmployeeType"].ToString();
                    string cadd = dr["CurrentAddress"].ToString();
                    string padd = dr["PermanantAddress"].ToString();
                    string qual = dr["Qualifications"].ToString();
                   DateTime jdate = Convert.ToDateTime(dr["JoinDate"]);
                    string sal = dr["Salary"].ToString();

                    conn.Close();
                    using (RegisterEmployee ad = new RegisterEmployee())
                    {
                       // ad.Show();
                        ad.ControlBox = true;
                        ad.assignValues(id, Fname, Lname, dob, gend, nic, maritial, rel, Mob, ph, mail, type, cadd, padd, qual, jdate, sal);
                        ad.sendStatus("Update");
                        DialogResult result = ad.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            TableLoad();
                        }
                    }

                 /* Form5 ad = new Form5();
       
                    ad.Show();
                    ad.assignValues(id,Fname, Lname, dob, gend,nic, maritial, rel, Mob, ph, mail, type, cadd, padd, qual, jdate, sal);*/
                    
                  //  conn.Close();
                    }
              


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName,LastName,DOB,Mobile,CurrentAddress,Salary from RegEmployee where LastName like '" + metroTextBox2.Text + "%'", conn);


              //  Cmd.ExecuteNonQuery();



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

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SalaryReport sr = new SalaryReport();
            //sr.Show();
        }
    }
}