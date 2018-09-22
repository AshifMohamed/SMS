using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;


namespace ITPPro
{
    public partial class EventDetails : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
       
        public EventDetails()
        {
            InitializeComponent();
            eventinfo();

        }


            


     
        public void eventinfo()
        {

            con.Open();
            DateTime thisDay = DateTime.Today;




            String vi = "select * from EventDe  where EndDate >= '" + thisDay + "'";

            SqlCommand cmd = new SqlCommand(vi, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

           
        }
     
        public void update()
        {

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE EventDe  SET Ename='" + TextBoxName.Text + "', EDescription= '" + TextBoxDes.Text + "', Venue= '" + venue.Text + "', MainOrganizer= '" + organize.Text + "', StartDate= '" + satrt.Text + "', StartTime= '" + strtime.Text + "', EndDate= '" + Endt.Text + "', EndTime= '" + Endtime.Text + "' where EventID = '" + TexId.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success");

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void EventDetails_Load(object sender, EventArgs e)
        {
            satrt.Value.AddDays(1);
            Endt.Value.AddDays(1);
        }


        void clear() {

            TextBoxName.Clear();
            TextBoxDes.Clear();             
            venue.Clear();
            organize.Clear(); 
            satrt.ResetText();
            strtime.ResetText();
            Endt.ResetText();
            Endtime.ResetText();
        
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
                  == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("DELETE FROM EventDe WHERE (EventID ='" + TexId.Text + "')", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted Succesfully");
                    eventinfo();
            

                }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
              update();
            eventinfo();
        }



        private void view_Click(object sender, EventArgs e)
        {
            Edashboard ed = new Edashboard();
            ed.getid(TexId.Text);
            ed.Show();
            
            this.Hide();
            
        }




       
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

              if (e.RowIndex >= 0)
            {
                 DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                 
                 
               
                TexId.Text = row.Cells[0].Value.ToString();
                TextBoxName.Text = row.Cells[1].Value.ToString();
                TextBoxDes.Text = row.Cells[2].Value.ToString();
                venue.Text = row.Cells[3].Value.ToString();
                organize.Text = row.Cells[4].Value.ToString();
                satrt.Text = row.Cells[5].Value.ToString();
                strtime.Text = row.Cells[6].Value.ToString();
                Endt.Text = row.Cells[7].Value.ToString();
                Endtime.Text = row.Cells[8].Value.ToString();
               
               
            }

            groupBox1.Show();
          
            

        }

        private void Endt_ValueChanged(object sender, EventArgs e)
        {
            DateTime today;
            bool valid1 = DateTime.TryParse(Endt.Text, out today);
            if (valid1 && (today < DateTime.Now))
            {

                
                errorProvider1.SetError(Endt, "Enter a present DATE !!!");
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
                metroButton3.Enabled = false;
                view.Enabled = false;
            }
            else
            {

                errorProvider1.Clear();
                metroButton1.Enabled = true;
                metroButton2.Enabled = true;
                metroButton3.Enabled = true;
                view.Enabled = true;
           
            }
        }

        private void satrt_ValueChanged(object sender, EventArgs e)
        {
            DateTime today;
            bool valid = DateTime.TryParse(satrt.Text, out today);
            if (valid && (today < DateTime.Now))
            {


                errorProvider2.SetError(satrt, "Enter a present DATE !!!");
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
                metroButton3.Enabled = false;
                view.Enabled = false;
            }
            else
            {

                errorProvider2.Clear();
                metroButton1.Enabled = true;
                metroButton2.Enabled = true;
                metroButton3.Enabled = true;
                view.Enabled = true;

            }

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxDes_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void venue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void organize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

       



        }
 }
