using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ITPPro
{
    public partial class home : MetroFramework.Forms.MetroForm
    {
        public home()
        {
            InitializeComponent();
        }

        SqlConnection con = DBAccess.GetConnection();
        string t;

        private void Form1_Load(object sender, EventArgs e)
        {
            metroListView1.Columns.Add("Event Name",100);
            metroListView1.Columns.Add("Event Date",100);
           
            upcoming();
          
           }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Addeve ad = new Addeve();
            ad.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            EventDetails s = new EventDetails();
            s.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        public void eveExp()
        {

            con.Open();

            DateTime thisDay = DateTime.Today;
            DateTime endDay = DateTime.Today.AddDays(30);
            String vi = "select * from EventDe where StartDate > '" + thisDay + "'";

            // String vi = "select  StartDate as date, Ename as ename from EventDe where StartDate between '2016-09-17' and '2016-09-30'";
           
          

            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            while (d.Read())
            {
                string name = d["ename"].ToString();
                string tot = d["date"].ToString();
                metroListView1.Items.Add(new ListViewItem(new string[] { name, tot }));
                metroListView1.View = View.Details;
                Controls.Add(metroListView1);


               
            }

            con.Close();

        }


        public void upcoming()
        {

            con.Open();

            DateTime thisDay = DateTime.Today;
            DateTime endDay = DateTime.Today.AddDays(30);
            
           
           // String vi = "select  StartDate as date, Ename as ename from EventDe where StartDate between '2016-09-17' and '2016-09-30'";
            String vi = "select  StartDate as date, Ename as ename from EventDe where StartDate between '" + thisDay + "' and '" + endDay + "'";
           
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            while (d.Read())
            {
                string name = d["ename"].ToString();
                string tot = d["date"].ToString();
                metroListView1.Items.Add(new ListViewItem(new string[] { name,tot }));
                metroListView1.View = View.Details;
                Controls.Add(metroListView1);
            }

            con.Close();

        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
          

          if (MessageBox.Show("Would You like to add an event ?", "Event", MessageBoxButtons.YesNo)
                  == DialogResult.Yes)
            {

          
                Addeve s = new Addeve();
                s.startT.Text = monthCalendar1.SelectionStart.ToString();
                s.Show();
                
            
            }
                
        }

  
          
    

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            history f = new history();
            f.Show();
        }
    }
}
