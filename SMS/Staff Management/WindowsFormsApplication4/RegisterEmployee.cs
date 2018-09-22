using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WindowsFormsApplication4;
using System.Data.SqlClient;
using MetroFramework.Controls;
using MetroFramework;

namespace WindowsFormsApplication4
{
    public partial class RegisterEmployee : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        String status;
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab ( tabPage1);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage2);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage3);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage1);
            metroButton6.Select();
          //  metroButton5.Visible = false;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (isNotNull())
            { 
            string Fname = metroTextBox1.Text;
            string Lname = metroTextBox2.Text;
            DateTime dob = metroDateTime1.Value;
            string gend = metroComboBox1.SelectedItem.ToString();
            String nic = metroTextBox4.Text;
            string maritial = metroComboBox2.SelectedItem.ToString();
            string rel = metroComboBox3.SelectedItem.ToString();
            string Mob = metroTextBox6.Text;
            string ph = metroTextBox3.Text;
            string mail = metroTextBox7.Text;
            string type = metroComboBox4.SelectedItem.ToString();
            string cadd = richTextBox1.Text;
            string padd = richTextBox2.Text;
            string qual = richTextBox3.Text;
            DateTime jdate = metroDateTime2.Value;
            string sal = metroTextBox5.Text;
            AddEmployee ad1 = new AddEmployee();
            ad1.addEmp(Fname, Lname, dob, gend,nic, maritial, rel, Mob, ph, mail, type, cadd, padd, qual, jdate, sal);
            }
        }

        public  void clear()
        {
            metroTextBox1.Clear();
            metroTextBox2.Clear();
            metroDateTime1.Value=DateTime.Today;
            metroComboBox1.SelectedItem.ToString();
            metroTextBox4.Clear();
            metroComboBox2.SelectedIndex=-1;
            metroComboBox3.SelectedIndex=-1;
            metroTextBox6.Clear();
            metroTextBox3.Clear();
            metroTextBox7.Clear();
             metroComboBox4.SelectedIndex=-1;
             richTextBox1.Clear();
             richTextBox2.Clear();
             richTextBox3.Clear();
             metroDateTime2.Value=DateTime.Today;
             metroTextBox5.Clear();
             MetroFramework.MetroMessageBox.Show(this, "Please Fill All the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       public void assignValues (string pid,String pFname,String pLname,DateTime pdob,String pvalue,String pnic,String pmaritial,String prel,String pMob,String pph,String pmail,String ptype,String pcadd,String ppadd,String pQual,DateTime pjdate,String psal)
        {
            id.Text = pid;
           metroTextBox1.Text=pFname;
           metroTextBox2.Text=pLname;
            metroDateTime1.Value=pdob;
            String gend = pvalue;
            metroComboBox1.SelectedItem = pvalue;
           
            metroComboBox2.SelectedItem=pmaritial;
            metroComboBox3.SelectedItem=prel;
            metroTextBox4.Text = pnic;
          metroTextBox6.Text= pMob;
         metroTextBox3.Text=pph;
            metroTextBox7.Text=pmail;
           metroComboBox4.SelectedItem=ptype;
          richTextBox1.Text=pcadd;
            richTextBox2.Text=ppadd;
            richTextBox3.Text=pQual;
            metroDateTime2.Value=pjdate;
            metroTextBox5.Text=psal;
            
          //  metroButton5.Enabled = true;
            metroButton4.Visible = false;
            metroButton5.Visible = true;
            

        }

       private void metroButton5_Click(object sender, EventArgs e)
       {
           string empid = id.Text;
           if (isNotNull())
           {
               string Fname = metroTextBox1.Text;
               string Lname = metroTextBox2.Text;
               DateTime dob = metroDateTime1.Value;
               string gend = metroComboBox1.SelectedItem.ToString();
               string nic = metroTextBox4.Text;
               string maritial = metroComboBox2.SelectedItem.ToString();
               string rel = metroComboBox3.SelectedItem.ToString();
               string Mob = metroTextBox6.Text;
               string ph = metroTextBox3.Text;
               string mail = metroTextBox7.Text;
               string emtype = metroComboBox4.SelectedItem.ToString();
               string cadd = richTextBox1.Text;
               string padd = richTextBox2.Text;
               string qual = richTextBox3.Text;
               DateTime jdate = metroDateTime2.Value;
               string sal = metroTextBox5.Text;

              UpdateEmployee ud1 = new UpdateEmployee();
               ud1.UpdateEmployees(empid, Fname, Lname, dob, gend,nic, maritial, rel, Mob, ph, mail, emtype, cadd, padd, qual, jdate, sal);
              DialogResult = DialogResult.OK;
           }

       }

      

     

      

      
      
            
        public Boolean isNotNull()
       {
           MetroTextBox[] newTextBox = { metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox6 };
           for (int i = 0; i < newTextBox.Length; i++)
           {
               if (newTextBox[i].Text == string.Empty)
               {
                  // MetroMessageBox.Show(this, "Please fill the text box", MessageBoxIcon.Hand);
                   MetroMessageBox.Show(this, "Please Fill All the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   newTextBox[i].Focus();
                   return false;
               }
              
           }
           RichTextBox[] newRichTextBox = { richTextBox1, richTextBox2, richTextBox3 };
           for (int i = 0; i < newRichTextBox.Length; i++)
           {
               if (newRichTextBox[i].Text == string.Empty)
               {
                   MetroMessageBox.Show(this, "Please Fill All the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   newTextBox[i].Focus();
                   return false;
               }

           }
           MetroComboBox[] newCombo = { metroComboBox1, metroComboBox2, metroComboBox3, metroComboBox4 };
           for (int i = 0; i < newCombo.Length; i++)
           {
               if (newCombo[i].SelectedIndex==-1)
               {
                   MetroMessageBox.Show(this, "Please Fill All the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   newTextBox[i].Focus();
                   return false;
               }

           }
           return true;
       }

        

      
        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void clearUpdate()
        {
            metroButton5.Visible = false;
        }

      
        private void metroTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
           string fname = metroTextBox1.Text;

           if (ValidateEmployee.isLetter(fname))
           {
               errorProvider1.SetError(metroTextBox1, "Can contain only letters");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
           else
           {
               errorProvider1.Clear();
               metroButton4.Enabled = true;
               metroButton5.Enabled = true;
           }
       
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
  
           string lname = metroTextBox2.Text;

           if (ValidateEmployee.isLetter(lname))
           {
               errorProvider1.SetError(metroTextBox2, "Can contain only letters");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
           else
           {
               errorProvider1.Clear();
               metroButton4.Enabled = true;
               metroButton5.Enabled = true;
           }
       
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
 
           string ph = metroTextBox3.Text;
           int no = ph.Length;

           if (no>10)
           {
               errorProvider1.SetError(metroTextBox3, "can contain only 10 Numbers");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
          
         
           else if (ValidateEmployee.isNumber(ph))
           {
               errorProvider1.SetError(metroTextBox3, "can contain only numbers");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
           else
           {
               errorProvider1.Clear();
               metroButton4.Enabled = true;
               metroButton5.Enabled = true;
           }
       
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {

           string mo = metroTextBox6.Text;
           int no = mo.Length;

           if (no > 10)
           {
               errorProvider1.SetError(metroTextBox6, "can contain only 10 Numbers");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }

           else if (ValidateEmployee.isNumber(mo))
           {
               errorProvider1.SetError(metroTextBox6, "can contain only numbers");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
           else
           {
               errorProvider1.Clear();
               metroButton4.Enabled = true;
               metroButton5.Enabled = true;
           }
       

        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
 
           string sal = metroTextBox5.Text;

           if (ValidateEmployee.isNumber(sal))
           {
               errorProvider1.SetError(metroTextBox5, "can contain only numbers");
               metroButton4.Enabled = false;
               metroButton5.Enabled = false;
           }
           else
           {
               errorProvider1.Clear();
               metroButton4.Enabled = true;
               metroButton5.Enabled = true;
           }
       
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
   
            string ni = metroTextBox4.Text;
          int nic = ni.Length;
            if(nic<10)
            {
               

                if (ValidateEmployee.isNumber(ni))
                {
                    errorProvider1.SetError(metroTextBox4, "can contain only numbers");
                    metroButton4.Enabled = false;
                    metroButton5.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    metroButton4.Enabled = true;
                    metroButton5.Enabled = true;
                }
            }
            else if(nic==10)
            {

                if (!(ni[9].Equals('v') || ni[9].Equals ('V')))
                {
                    errorProvider1.SetError(metroTextBox4, "last character should be V");
                    metroButton4.Enabled = false;
                    metroButton5.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    metroButton4.Enabled = true;
                    metroButton5.Enabled = true;
                }
            }

            else
              if (ValidateEmployee.isMaxLength(nic))
               {
                   errorProvider1.SetError(metroTextBox4, "can contain only 10 Characters");
                   metroButton4.Enabled = false;
                   metroButton5.Enabled = false;
               }
               else
               {
                   errorProvider1.Clear();
                   metroButton4.Enabled = true;
                   metroButton5.Enabled = true;
               }

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage1);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage2);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage3);
        }

        public void sendStatus(string stat)
        {
            if(stat=="Update")
            {
                metroButton5.Visible = true;
            }
            else
                metroButton5.Visible = false;

        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            string m2 = metroTextBox6.Text;

            if (ValidateEmployee.EmailIsValid(m2))
            {

                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(metroTextBox6, "Enter correct E-mail");

            }
        }
       
    }
}