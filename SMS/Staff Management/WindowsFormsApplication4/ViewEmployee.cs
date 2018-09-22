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
    public partial class ViewEmployee : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage1);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage2);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage3);
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage1);

        }
        public void ViewEmp(string id)
        {
            try
            {

                conn.Open();

                SqlCommand Cmd = new SqlCommand("Select * from RegEmployee where ID='" + id+"'", conn);

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    metroLabel15.Text = dr["FirstName"].ToString();
                    metroLabel21.Text = dr["LastName"].ToString();
                    metroLabel16.Text = dr["Gender"].ToString();
                    metroLabel17.Text = dr["DOB"].ToString();
                    metroLabel18.Text = dr["MartialStatus"].ToString();
                    metroLabel19.Text = dr["Religion"].ToString();
                    metroLabel20.Text = dr["NIC"].ToString();
                    metroLabel22.Text = dr["CurrentAddress"].ToString();
                    metroLabel23.Text = dr["PermanantAddress"].ToString();
                    metroLabel24.Text = dr["Phone"].ToString();
                    metroLabel25.Text = dr["Email"].ToString();
                    metroLabel26.Text = dr["Mobile"].ToString();
                    metroLabel27.Text = dr["JoinDate"].ToString();
                    metroLabel28.Text = dr["Salary"].ToString();
                    metroLabel29.Text = dr["Qualifications"].ToString();
                    metroLabel30.Text = dr["EmployeeType"].ToString();

                    //   metroComboBox1.Text = dr["Status"].ToString();
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void pageSliderPage3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}