using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ITPPro
{
    public partial class finace : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = DBAccess.GetConnection();
        string eid;
      
        public finace()
        {
            InitializeComponent();
        }

        private void finace_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToAddRows = false;
            
            dataGridView2.AllowUserToAddRows = false;

            
        }



        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        public void update()
        {

            try
            {

                if (FactName.Text == "" || descr.Text == "" || nounit.Text == "" || nocost.Text == "")
                {

                    MessageBox.Show("Please Fill The Empty Fields!");


                }

                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Cost  SET FacName='" + FactName.Text + "', Nouni= '" + nounit.Text + "', unico= '" + nocost.Text + "', tot= '" + total.Text + "' where Descp = '" + descr.Text + "'", con);
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

        public void pupdate()
        {

            try
            {

                if (scnames.Text == "" || descpr.Text == "" || nounitp.Text == "" || nocostp.Text == "")
                {
                    MessageBox.Show("Please Fill The Empty Fields!");
                }

                else
                {
                    con.Open();

                     SqlCommand cmd = new SqlCommand("UPDATE Profit  SET scrname='" + scnames.Text + "', nouni= '" + nounitp.Text + "', unico= '" + nocostp.Text + "', tot= '" + totalp.Text + "' where descp = '" + descpr.Text + "'", con);
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


        public void disp()
        {

            con.Open();

            String vi = "select * from Cost where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        public void sendid(string id)
        {
            label1.Text = id;
            idlbl.Text = id;
            eid = id;// Convert.ToInt32(id);
            
            disp();
            ctotal();
           
            profdis();
           
            ptotal();
            net();

        }
        public void ctotal()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            metroTextBox1.Text = sum.ToString();
            costex.Text = sum.ToString();
        }



        public void profdis()
        {

            con.Open();


            String pi = "select * from Profit where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(pi, con);
            cmd.ExecuteNonQuery();
            DataTable pt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(pt);
            dataGridView2.DataSource = pt;
            con.Close();


        }

        public void ptotal()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {

                sum = sum + int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }

            prof.Text = sum.ToString();
            protex.Text = sum.ToString();
        }

        void net()
        {

            nettex.Text = (Convert.ToDouble(protex.Text) - Convert.ToDouble(costex.Text)).ToString();
        }


        private void savebtn_Click(object sender, EventArgs e)
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


                cost add = new cost();

                if (!string.IsNullOrEmpty(nounit.Text) && !string.IsNullOrEmpty(nocost.Text))
                    total.Text = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();
                tot = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();




                add.CreateCost(fname, des, nuni, unic, tot, id);
                disp();
                ctotal();

            }
        }

        private void costdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
                  == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM Cost WHERE (Descp ='" + descr.Text + "')", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                disp();
                ctotal();

            }

        }

        private void updttn_Click(object sender, EventArgs e)
        {
            update();
            disp();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {

                    c.Text = "";

                }

                if (c is ComboBox)
                {

                    c.Text = "";
                }

                if (c is DomainUpDown)
                {

                    c.Text = "";
                }
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            groupBox4.Show();
        }

        private void savbtn_Click(object sender, EventArgs e)
        {
            if (scnames.Text == "" || descpr.Text == "" || nounitp.Text == "" || nocostp.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");


            }



            else
            {




                string sname = scnames.Text;
                string desi = descpr.Text;
                string nunii = nounitp.Text;
                string unici = nocostp.Text;
                string toti = totalp.Text;
                string id = idlbl.Text;


                profit add = new profit();

                if (!string.IsNullOrEmpty(nounitp.Text) && !string.IsNullOrEmpty(nocostp.Text))
                    totalp.Text = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();
                toti = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();




                add.Createprofit(sname, desi, nunii, unici, toti,id);
                profdis();
                ptotal();


            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            pupdate();
            profdis();
        }

        private void prodele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
              == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM Profit WHERE (Descp ='" + descpr.Text + "')", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                profdis();
                ptotal();

            }
        }

    
      

        public void hi()
        {

            if (!string.IsNullOrEmpty(nounit.Text) && !string.IsNullOrEmpty(nocost.Text))
                total.Text = (Convert.ToDouble(nounit.Text) * Convert.ToDouble(nocost.Text)).ToString();
        }

        public void hione()
        {
            if (!string.IsNullOrEmpty(nounitp.Text) && !string.IsNullOrEmpty(nocostp.Text))
                totalp.Text = (Convert.ToDouble(nounitp.Text) * Convert.ToDouble(nocostp.Text)).ToString();
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

        private void prof_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                scnames.Text = row.Cells[0].Value.ToString();
                descpr.Text = row.Cells[1].Value.ToString();
                nounitp.Text = row.Cells[2].Value.ToString();
                nocostp.Text = row.Cells[3].Value.ToString();
                totalp.Text = row.Cells[4].Value.ToString();

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

        private void nounit_SelectedItemChanged_1(object sender, EventArgs e)
        {
            int nouni;
            if (int.TryParse(nounit.Text, out nouni))
            {

                hi();
                errorProvider2.Clear();

            }

            else
            {
                errorProvider2.SetError(nounit, "Please provide number only");
            }

        }

        private void nocost_SelectedItemChanged_1(object sender, EventArgs e)
        {
            int nocos;
            if (int.TryParse(nocost.Text, out nocos))
            {

                hi();
                errorProvider1.Clear();

            }

            else
            {
                errorProvider1.SetError(nocost, "Please provide number only");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel) { 
            
                    Microsoft.Office.Interop.Excel.Application ExcelApp    = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                //change properties of the workbook
                    ExcelApp.Columns.ColumnWidth = 20;
                //sorting headre part in excel 
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    
                    }
                // sorting each row and colums valu to excel sheet
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++) 
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        
                        }
                    
                    }

                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                    MessageBox.Show("Exported Succesfully");
            }
        }

        private void nettex_Click(object sender, EventArgs e)
        {
            net(); 
        }

        private void domainUpDown1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void costex_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void nettex_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            FactName.SelectedIndex = -1;
            descr.Clear();
            total.Text = "";
            nounit.Text = "";
            nocost.Text = "";
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            scnames.SelectedIndex = -1;
            descpr.Clear();
            nounitp.Text = "";
            nocostp.Text = "";
            totalp.Text = "";   
        }
        


    }

}
 
