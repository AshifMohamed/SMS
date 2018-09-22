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
using System.Text.RegularExpressions;
using WindowsFormsApplication4;

namespace ITPPro
{
    public partial class sponser : MetroFramework.Forms.MetroForm
    {
        string eid;
        SqlConnection con = DBAccess.GetConnection();
       
        public sponser()
        {
            InitializeComponent();
        }

        private void sponser_Load(object sender, EventArgs e)
        {

        }

        public void addspons()
        {

            con.Open();

            String vi = "select * from Sponser where eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(vi, con);


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            metroGrid1.DataSource = dt;
            con.Close();


        }

        public void sendid(string id)
        {
            sid.Text = id;
            eid = id;
            addspons();
           
        }


        static Regex ValidEmailRegex = CreateValidEmailRegex();
       private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
           bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (spnsr.Text == "" || typ.Text == "" || add.Text == "" || cat.Text == "" || descp.Text == "" || cont.Text == "" || email.Text == "" || amo.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");

               

            }

            else if (cont.Text.Length != 10)
            {


                MessageBox.Show("Enter only 10 numbers");
            
            }




            else
            {

                // string eid = eveID.Text;
                string name = spnsr.Text;
                string type = typ.Text;
                string addr = add.Text;
                string cato = cat.Text;
                string desp = descp.Text;
                string contact = cont.Text;
                string emai = email.Text;
                string amou = amo.Text;
                string id = sid.Text;






                sponserinfo adds = new sponserinfo();

                adds.addsponser(name, type, addr, cato, desp, contact, emai, amou, id);
                addspons();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                spnsr.Text = row.Cells[0].Value.ToString();
                typ.Text = row.Cells[1].Value.ToString();
                add.Text = row.Cells[2].Value.ToString();
                cat.Text = row.Cells[3].Value.ToString();
                descp.Text = row.Cells[4].Value.ToString();
                cont.Text = row.Cells[5].Value.ToString();
                email.Text = row.Cells[6].Value.ToString();
                amo.Text = row.Cells[7].Value.ToString();




            }
        }

        public void supdate()
        {

            try
            {

                if (spnsr.Text == "" || add.Text == "" || descp.Text == "" || cont.Text == "" || email.Text == "" || amo.Text == "")
                {

                    MessageBox.Show("Please Fill The Empty Fields!");


                }

                else
                {
                  
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Sponser  SET Type='" + typ.Text + "', Address= '" + add.Text + "', Category= '" + cat.Text + "', Description= '" + descp.Text + "', Contact= '" + cont.Text + "', Email= '" + email.Text + "', Amount= '" + amo.Text + "'  where SponserName = '" + spnsr.Text + "'", con);
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            supdate();
            addspons();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void prodele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ?", "Delete", MessageBoxButtons.YesNo)
              == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM Sponser WHERE (SponserName ='" + spnsr.Text + "')", con);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Succesfully");
                addspons();

            }
        }

        private void spnsr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void amo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void amo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cont_TextChanged(object sender, EventArgs e)
        {
            if (cont.Text.Length != 10)
            {

                errorProvider1.SetError(cont, "Enter only 10 numbers");
                metroButton1.Enabled = false;
                metroButton3.Enabled = false;
                prodele.Enabled = false;
            }

            else
            {

                errorProvider1.Clear();
                metroButton1.Enabled = true;
                metroButton3.Enabled = true;
                prodele.Enabled = true;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           
                    email s = new email();
                    s.metroLabel2.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                    s.Show();
                
            }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string m2 = email.Text;

            if (EmailIsValid(m2))
            {

                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(email, "Enter correct E-mail");

            }
        }
            
         
    }
}
