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
    public partial class fexecu : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
       

        string eid;
      
        public fexecu()
        {
            InitializeComponent();
        }

       
        private void fexecu_Load(object sender, EventArgs e)
        {
            
          ///  dataGridView1.AllowUserToAddRows = false;
             //rcost();
            //rctotal();
            //dataGridView2.AllowUserToAddRows = false;
            
           // rptotal();
           // net();
            
        }

        public void rcost()
        {
            
            con.Open();

            String vi = "select * from RCost where eid = '"+ eid + "' ";
            SqlCommand cmd = new SqlCommand(vi, con);
           

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            

        }
        public void fnet()
        {

            rnet.Text = (Convert.ToDouble(protex.Text) - Convert.ToDouble(costex.Text)).ToString();
        }
        public void sendid(string id)
        {
            label1.Text = id;
            rincom.Text = id;
            eid = id;// Convert.ToInt32(id);

            dataGridView1.AllowUserToAddRows = false;
            rcost();
            rctotal();

            dataGridView2.AllowUserToAddRows = false;

            rprofit();
            rptotal();
            fnet();
           

        }

       
      
        public void rctotal()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            sumTextBox1.Text = sum.ToString();
            costex.Text = sum.ToString();
        }



        public void rprofit()
        {

            con.Open();

            String vi = "select * from RProfit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();


        }

        public void rptotal()
        {
            int summ = 0;
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {

                summ = summ + int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }

            protex.Text = summ.ToString();
            rincome.Text = summ.ToString();
        }

       


        public void hi()
        {
            if (!string.IsNullOrEmpty(nounit.Text) && !string.IsNullOrEmpty(nocost.Text))
                total.Text = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();
        }

        void hione()
        {


            if (!string.IsNullOrEmpty(nounitp.Text) && !string.IsNullOrEmpty(nocostp.Text))
                totalp.Text = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();


        }

        public void update()
        {

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RCost  SET factorName='" + FactName.Text + "',noOfUnits= '" + nounit.Text + "', unitCost= '" + nocost.Text + "', total= '" + total.Text + "' where description = '" + descr.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success");


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void pupdate()
        {

            try
            {

                if (scnamesp.Text == "" || descr.Text == "" || nounit.Text == "" || nocost.Text == "")
                {

                    MessageBox.Show("Please Fill The Empty Fields!");


                }

                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE RProfit  SET sourceName='" + scnamesp.Text + "', noOfUnits= '" + nounitp.Text + "', unitCost= '" + nocostp.Text + "', total= '" + totalp.Text + "' where description = '" + descrp.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Success");
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

       

      

     

        

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            if (FactName.Text == "" || descr.Text == "" || nounit.Text == "" || nocost.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");


            }



            else
            {




                string fname = FactName.Text;
                string des = descr.Text;
                string nuni = nounit.Text;
                string unic = nocost.Text;
                string tot = total.Text;
                string id = label1.Text;



                RCost add = new RCost();

                if (!string.IsNullOrEmpty(nounit.Text) && !string.IsNullOrEmpty(nocost.Text))
                    total.Text = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();
                tot = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();




                add.RealCost(fname, des, nuni, unic, tot, id);

               
                rcost();


                rctotal();


            }

            
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            update();
           
            rcost();

            //rcost();
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM RCost WHERE description ='" + descr.Text + "'", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                rcost();
                rctotal();

            }
        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
            scnamesp.SelectedIndex = -1;
            descr.Clear();
            total.Text = "";
            nounit.Text = "";
            nocost.Text = "";
        }

        private void sumTextBox1_Click_1(object sender, EventArgs e)
        {
            //rctotal();
        }

        private void rincome_Click(object sender, EventArgs e)
        {
            //rptotal();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (scnamesp.Text == "" || descrp.Text == "" || nounitp.Text == "" || nocostp.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");


            }



            else
            {




                string snamei = scnamesp.Text;
                string desi = descrp.Text;
                string nunii = nounitp.Text;
                string unici = nocostp.Text;
                string toti = totalp.Text;
                string id = rincom.Text; 


                Rprofit add = new Rprofit();

                if (!string.IsNullOrEmpty(nounitp.Text) && !string.IsNullOrEmpty(nocostp.Text))
                    totalp.Text = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();
                toti = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();




                add.RealProfit(snamei, desi, nunii, unici, toti, id);
                rprofit();
                rptotal();

            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            pupdate();
            rprofit();
        }

        private void delpro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM RProfit WHERE description ='" + descrp.Text + "'", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                rprofit();
                rptotal();

            }
           
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            scnamesp.SelectedIndex = -1;
            descrp.Clear();
            totalp.Text = "";
            nounitp.Text = "";
            nocostp.Text = "";
          
    
            
         }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                scnamesp.Text = row.Cells[0].Value.ToString();
                descrp.Text = row.Cells[1].Value.ToString();
                nounitp.Text = row.Cells[2].Value.ToString();
                nocostp.Text = row.Cells[3].Value.ToString();
                totalp.Text = row.Cells[4].Value.ToString();




            }
        }

        private void nounitp_SelectedItemChanged(object sender, EventArgs e)
        {
            int nounp;
            if (int.TryParse(nounitp.Text, out nounp))
            {

                hione();
                errorProvider1.Clear();

            }

            else
            {
                errorProvider1.SetError(nounitp, "Please provide number only");
            }
            
            
        }

        private void nounit_SelectedItemChanged(object sender, EventArgs e)
        {
            int nouni;
            if (int.TryParse(nounit.Text, out nouni))
            {

                hi();
                errorProvider1.Clear();

            }

            else
            {
                errorProvider1.SetError(nounit, "Please provide number only");

            }
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                FactName.Text = row.Cells[0].Value.ToString();
                descr.Text = row.Cells[1].Value.ToString();
                nounit.Text = row.Cells[2].Value.ToString();
                nocost.Text = row.Cells[3].Value.ToString();
                total.Text = row.Cells[4].Value.ToString();




            }

        }

        private void nettex_Click(object sender, EventArgs e)
        {
            fnet();
        }

        private void nocost_SelectedItemChanged(object sender, EventArgs e)
        {

            int nocos;
            if (int.TryParse(nocost.Text, out nocos))
            {

                hi();
                errorProvider2.Clear();

            }

            else
            {
                errorProvider2.SetError(nocost, "Please provide number only");
            }
        }

        private void nocostp_SelectedItemChanged(object sender, EventArgs e)
        {
            int nocop;
            if (int.TryParse(nocostp.Text, out nocop))
            {

                hione();
                errorProvider1.Clear();

            }

            else
            {
                errorProvider1.SetError(nocostp, "Please provide number only");
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void nounit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nocost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nounitp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nocostp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       
    }
}

