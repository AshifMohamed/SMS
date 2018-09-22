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
    public partial class Runsheet : MetroFramework.Forms.MetroForm
    {
        string eid;
        SqlConnection con = DBAccess.GetConnection();
        
        public Runsheet()
        {
            InitializeComponent();
        }

        private void Runsheet_Load(object sender, EventArgs e)
        {

        }
        public void disdayone()
        {

            con.Open();

            String vi = "select * from Dayone  where eid = '" + eid + "'";
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
            run.Text = id;
            eid = id;// Convert.ToInt32(id);
            disdayone();
            
        }
       

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (description.Text == "" || person.Text == "" || respons.Text == "" || team.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");


            }



            else
            {




                string timep = time.Value.ToString();
                string desc = description.Text;
                string personp = person.Text;
                string responsp = respons.Text;
                string teamp = team.Text;
                string id = run.Text;
               


                dayone add = new dayone();






                add.Dayo(timep, desc, personp, responsp, teamp,id);
                disdayone();


            }
        }

        public void update()
        {

            try
            {

                if (description.Text == "" || person.Text == "" || respons.Text == "" || team.Text == "")
                {

                    MessageBox.Show("Please Fill The Empty Fields!");


                }

                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Dayone SET Description='" + description.Text + "', PersonInAction= '" + person.Text + "', Responsible= '" + respons.Text + "', TeamLeader= '" + team.Text + "' where Time = '" + time.Text + "'", con);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            update();
            disdayone();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM Dayone WHERE (Description ='" + description.Text + "')", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                disdayone();


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                time.Text = row.Cells[0].Value.ToString();
                description.Text = row.Cells[1].Value.ToString();
                person.Text = row.Cells[2].Value.ToString();
                respons.Text = row.Cells[3].Value.ToString();
                team.Text = row.Cells[4].Value.ToString();
                run.Text = row.Cells[5].Value.ToString();



            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void person_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void respons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void team_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
