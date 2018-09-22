using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;
namespace ITPPro
{
    public partial class history : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        string eid;

        //string cid;
        public history()
        {
            InitializeComponent();
        }

       

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventExp();
        }

        
        public void eventExp()
        {

            con.Open();
            DateTime thisDay = DateTime.Today;

            String vi = "select * from EventDe where EndDate <= '" + thisDay + "'";

            SqlCommand cmd = new SqlCommand(vi, con);
            //  String vi = "select * from EventDe ";
            cmd.ExecuteNonQuery();
            
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            metroGrid1.DataSource = dt;
            con.Close();


        }

        public void getid(String id)
        {
            
            //getid(metroLabel1.Text);
            eid = id;
            //cid = id;

        }
        public void hiscos()
        {

            con.Open();

            String vi = "select * from Cost where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            metroGrid2.DataSource = dt;
            con.Close();


        }

      
        public void hispro()
        {

            con.Open();


            String pi = "select * from Profit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(pi, con);
            cmd.ExecuteNonQuery();
            DataTable pt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(pt);
            metroGrid2.DataSource = pt;
            con.Close();


        }

        public void hisrprofit()
        {

            con.Open();

            String vi = "select * from RProfit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            metroGrid2.DataSource = dt;
            con.Close();


        }

        public void hisrcost()
        {

            con.Open();

            String vi = "select * from RCost where eid = '" + eid + "' ";
            SqlCommand cmd = new SqlCommand(vi, con);


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            metroGrid2.DataSource = dt;
            con.Close();


        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            getid(metroLabel1.Text);
            
            hiscos();
            
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                metroLabel1.Text = row.Cells[0].Value.ToString();
              




            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            getid(metroLabel1.Text);
            hispro();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            getid(metroLabel1.Text);

            hisrprofit();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            getid(metroLabel1.Text);

            hisrcost();
        }
    }
}
