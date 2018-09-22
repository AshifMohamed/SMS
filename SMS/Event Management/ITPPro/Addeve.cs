using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4;


namespace ITPPro
{
    public partial class Addeve : MetroFramework.Forms.MetroForm
    {
        public Addeve()
        {
            InitializeComponent();
        }

        private void Addeve_Load(object sender, EventArgs e)
        {

        }
       

        private void save_Click(object sender, EventArgs e)
        {
   
            if (eveName.Text == "" || eDes.Text == "" || Venu.Text == "" || mainOrg.Text == "")
            {

                MessageBox.Show("Please Fill The Empty Fields!");


            }

      
            else
            {

                // string eid = eveID.Text;
                string name = eveName.Text;
                string des = eDes.Text;
                string venue = Venu.Text;
                string mainorg = mainOrg.Text;
                string stdate = startT.Value.ToString();
                string sttime = stime.Value.ToString();
                string endate = EndT.Value.ToString();
                string entime = etime.Value.ToString();






                eventsinfo add = new eventsinfo();

                add.createEve(name, des, venue, mainorg, stdate, sttime, endate, entime);



            }

           
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            home s = new home();
            this.Hide();
            
        }

        private void startT_ValueChanged(object sender, EventArgs e)
        {
            DateTime today;
            bool valid = DateTime.TryParse(startT.Text, out today);
            

            if (valid && (today < DateTime.Now)) 
            {
                errorProvider1.SetError(startT,"Enter a present DATE !!!");
              //  save.Enabled = false;
                //back.Enabled = false;
            }

            else {

                errorProvider1.Clear();
              //  save.Enabled = true;
                //back.Enabled = true;
            
            }

           
        }

        private void EndT_ValueChanged(object sender, EventArgs e)
        {
            DateTime today;
            bool valid1 = DateTime.TryParse(EndT.Text, out today);
            if (valid1 && (today < DateTime.Now))
            {


                errorProvider2.SetError(EndT, "Enter a present DATE !!!");
                   save.Enabled = false;
                back.Enabled = false;
            }
            else
            {

                errorProvider2.Clear();
                save.Enabled = true;
                back.Enabled = true;

            }

        }

        private void eveName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void eDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Venu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void mainOrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
