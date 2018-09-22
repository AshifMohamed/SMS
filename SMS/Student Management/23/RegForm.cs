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
namespace _23
{
    public partial class RegForm : MetroFramework.Forms.MetroForm
    {

        SqlConnection conn = DBAccess.GetConnection();

        public RegForm()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        
        

        private void RegForm_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage1;
            gendercombo.Items.Add("Male");
            gendercombo.Items.Add("Female");
            txtadmissiongrade.Items.Add("1");
            txtadmissiongrade.Items.Add("2");
            txtadmissiongrade.Items.Add("3");
            txtadmissiongrade.Items.Add("4");
            txtadmissiongrade.Items.Add("5");
            txtadmissiongrade.Items.Add("6");
            txtadmissiongrade.Items.Add("7");
            txtadmissiongrade.Items.Add("8");
            txtadmissiongrade.Items.Add("9");
            txtadmissiongrade.Items.Add("10");
            txtadmissiongrade.Items.Add("11");
            txtadmissiongrade.Items.Add("12");
            txtage.Items.Add("5");
            txtage.Items.Add("6");
            txtage.Items.Add("7");
            txtage.Items.Add("8");
            txtage.Items.Add("9");
            txtage.Items.Add("10");
            txtage.Items.Add("11");
            txtage.Items.Add("12");
            txtage.Items.Add("13");
            txtage.Items.Add("14");
            txtage.Items.Add("15");
            txtage.Items.Add("16");
            txtage.Items.Add("17");
            txtage.Items.Add("18");

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtregdatepick.Text != "" & txtfname.Text != "" & txtmidName.Text != "" & txtsurname.Text != "" & txtdob.Text != "" & txthomeaddress.Text != "" & txtadmissiongrade.Text != ""
           & txtfathername.Text != "" & txtfatherocc.Text != "" & txtfatheroccuadd.Text != "" & txtmothername.Text != "" & txtmotheroccu.Text != ""
          & txtmotheroccuadd.Text != "" & txtage.Text != "" & txtnationality.Text != "" & txtcontact.Text != "" & txtemail.Text != "" & txtemername.Text != ""
          & txtemeraddress.Text != "" & txtemercontact.Text != "" & txtemerrelation.Text != "" & gendercombo.Text != "")
                {




                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO  stud_regis (dateOfReg,fname,midname,surname,dob,address,admissionGrade,fathersName,fathersOccu,fathersOccuAddress,mothersName,mothersOccu,mothersOccuAddress,age,nationality,contact,email,emerName,emerAddress,emerContact,emerRelationship,gender) VALUES (@2,@3,@4,@5,@6,@7,@8,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@21,@22,@23,@24,@25);", conn);

                   
                    cmd.Parameters.AddWithValue("@2", txtregdatepick.Text);
                    cmd.Parameters.AddWithValue("@3", txtfname.Text);
                    cmd.Parameters.AddWithValue("@4", txtmidName.Text);
                    cmd.Parameters.AddWithValue("@5", txtsurname.Text);
                    cmd.Parameters.AddWithValue("@6", txtdob.Text);
                    cmd.Parameters.AddWithValue("@7", txthomeaddress.Text);
                    cmd.Parameters.AddWithValue("@8", txtadmissiongrade.Text);
                    cmd.Parameters.AddWithValue("@10", txtfathername.Text);
                    cmd.Parameters.AddWithValue("@11", txtfatherocc.Text);
                    cmd.Parameters.AddWithValue("@12", txtfatheroccuadd.Text);
                    cmd.Parameters.AddWithValue("@13", txtmothername.Text);
                    cmd.Parameters.AddWithValue("@14", txtmotheroccu.Text);
                    cmd.Parameters.AddWithValue("@15", txtmotheroccuadd.Text);
                    cmd.Parameters.AddWithValue("@16", txtage.Text);
                    cmd.Parameters.AddWithValue("@17", txtnationality.Text);
                    cmd.Parameters.AddWithValue("@18", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@19", txtemail.Text); 
                    cmd.Parameters.AddWithValue("@21", txtemername.Text);
                    cmd.Parameters.AddWithValue("@22", txtemeraddress.Text);
                    cmd.Parameters.AddWithValue("@23", txtemercontact.Text);
                    cmd.Parameters.AddWithValue("@24", txtemerrelation.Text);
                    cmd.Parameters.AddWithValue("@25", gendercombo.Text);
                   


                    cmd.ExecuteNonQuery();

                    conn.Close();
                   reset();

                    MessageBox.Show("The student entry was successfully added.");
                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show("This Student has been registered already.");
                reset();
            }

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

            viewAllStudents dora = new viewAllStudents();
            dora.Show();



        }


        void reset()
        {
            
            txtfname.Text = "";
            txtmidName.Text = "";
            txtsurname.Text = "";
            txtdob.Text = "";
            txthomeaddress.Text = "";
            txtadmissiongrade.SelectedIndex = -1;    
            txtfathername.Text = "";
            txtfatherocc.Text = "";
            txtfatheroccuadd.Text = "";
            txtmothername.Text = "";
            txtmotheroccu.Text = "";
            txtmotheroccuadd.Text = "";
            gendercombo.SelectedIndex = -1;
            txtage.SelectedIndex = -1;
            txtnationality.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";       
            txtemername.Text = "";
            txtemeraddress.Text = "";
            txtemercontact.Text = "";
            txtemerrelation.Text = "";
            searchreg.Text = "";
       

           


        }

      

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            if (studentValidate.isNumber(fname))
            {
                errorProvider1.SetError(txtfname, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtmidName_TextChanged(object sender, EventArgs e)
        {
            string mname = txtmidName.Text;
            if (studentValidate.isNumber(mname))
            {
                errorProvider1.SetError(txtmidName, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {
            string mname = txtsurname.Text;
            if (studentValidate.isNumber(mname))
            {
                errorProvider1.SetError(txtsurname, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txthomeaddress_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void studentRegBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM  stud_regis where AdmissionNo = @1", conn);
                    cmd.Parameters.AddWithValue("@1", searchreg.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {

                            txtregdatepick.Text = dr["dateOfReg"].ToString();
                            txtfname.Text = dr["fname"].ToString();
                            txtmidName.Text = dr["midName"].ToString();
                            txtsurname.Text = dr["surname"].ToString();
                            txtdob.Text = dr["dob"].ToString();
                            txthomeaddress.Text = dr["address"].ToString();
                            txtadmissiongrade.Text = dr["admissionGrade"].ToString();
                            txtfathername.Text = dr["fathersName"].ToString();
                            txtfatherocc.Text = dr["fathersOccu"].ToString();
                            txtfatheroccuadd.Text = dr["fathersOccuAddress"].ToString();
                            txtmothername.Text = dr["mothersName"].ToString();
                            txtmotheroccu.Text = dr["mothersOccu"].ToString();
                            txtmotheroccuadd.Text = dr["mothersOccuAddress"].ToString();
                            gendercombo.Text = dr["gender"].ToString();
                            txtage.Text = dr["age"].ToString();
                            txtnationality.Text = dr["nationality"].ToString();
                            txtcontact.Text = dr["contact"].ToString();
                            txtemail.Text = dr["email"].ToString();
                            txtemername.Text = dr["emerName"].ToString();
                            txtemeraddress.Text = dr["emerAddress"].ToString();
                            txtemercontact.Text = dr["emerContact"].ToString();
                            txtemerrelation.Text = dr["emerRelationship"].ToString();
                         //   pb1.ImageLocation = dr["studImage"].ToString();


                        }




                    }

                    dr.Close();


               

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                // reset();
            }       

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchreg.Text != "")
                {

                    if (MessageBox.Show("Student entry will be deleted. Do you want to proceed?", "Delete Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        SqlCommand cmd = new SqlCommand("delete from stud_regis where AdmissionNo=@a", conn);
                        cmd.Parameters.AddWithValue("@a", searchreg.Text);
                        conn.Open();
                        int a = cmd.ExecuteNonQuery();
                        reset();
                        if (a > 0)
                        {
                            MessageBox.Show("Student Entry Deleted");

                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a registration number to search and delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                reset();
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtregdatepick.Text != "" & txtfname.Text != "" & txtmidName.Text != "" & txtsurname.Text != "" & txtdob.Text != "" & txthomeaddress.Text != "" & txtadmissiongrade.Text != ""
           & txtfathername.Text != "" & txtfatherocc.Text != "" & txtfatheroccuadd.Text != "" & txtmothername.Text != "" & txtmotheroccu.Text != ""
          & txtmotheroccuadd.Text != "" & txtage.Text != "" & txtnationality.Text != "" & txtcontact.Text != "" & txtemail.Text != ""  & txtemername.Text != ""
          & txtemeraddress.Text != "" & txtemercontact.Text != "" & txtemerrelation.Text != "" & searchreg.Text != "" & gendercombo.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE stud_regis SET dateOfReg=@2,fname=@3,midname=@4,surname=@5,dob=@6,address=@7,admissionGrade=@8,fathersName=@10,fathersOccu=@11,fathersOccuAddress=@12,mothersName=@13,mothersOccu=@14,mothersOccuAddress=@15,age=@16,nationality=@17,contact=@18,email=@19,emerName=@21,emerAddress=@22,emerContact=@23,emerRelationship=@24,gender=@26 WHERE AdmissionNo=@25", conn);
                   
                    cmd.Parameters.AddWithValue("@2", txtregdatepick.Text);
                    cmd.Parameters.AddWithValue("@3", txtfname.Text);
                    cmd.Parameters.AddWithValue("@4", txtmidName.Text);
                    cmd.Parameters.AddWithValue("@5", txtsurname.Text);
                    cmd.Parameters.AddWithValue("@6", txtdob.Text);
                    cmd.Parameters.AddWithValue("@7", txthomeaddress.Text);
                    cmd.Parameters.AddWithValue("@8", txtadmissiongrade.Text);
                    
                    cmd.Parameters.AddWithValue("@10", txtfathername.Text);
                    cmd.Parameters.AddWithValue("@11", txtfatherocc.Text);
                    cmd.Parameters.AddWithValue("@12", txtfatheroccuadd.Text);
                    cmd.Parameters.AddWithValue("@13", txtmothername.Text);
                    cmd.Parameters.AddWithValue("@14", txtmotheroccu.Text);
                    cmd.Parameters.AddWithValue("@15", txtmotheroccuadd.Text);
                    cmd.Parameters.AddWithValue("@16", txtage.Text);
                    cmd.Parameters.AddWithValue("@17", txtnationality.Text);
                    cmd.Parameters.AddWithValue("@18", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@19", txtemail.Text);
                  
                    cmd.Parameters.AddWithValue("@21", txtemername.Text);
                    cmd.Parameters.AddWithValue("@22", txtemeraddress.Text);
                    cmd.Parameters.AddWithValue("@23", txtemercontact.Text);
                    cmd.Parameters.AddWithValue("@24", txtemerrelation.Text);
                    cmd.Parameters.AddWithValue("@25", searchreg.Text);
                    cmd.Parameters.AddWithValue("@26", gendercombo.Text);

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Student Information Updated");
                    }
                }
                else
                {

                    MessageBox.Show("One or more fields are empty");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This Student has been registered already.");
            }
            finally
            {
                conn.Close();
                 reset();
            }
        }

        private void txtemail_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string emai = txtemail.Text;
            if (studentValidate.EmailIsValid(emai))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtemail, "invalid email address");
                metroTile1.Enabled = false;
            }
        }

        private void txtfathername_TextChanged(object sender, EventArgs e)
        {
            string fathernam = txtfathername.Text;
            if (studentValidate.isNumber(fathernam))
            {
                errorProvider1.SetError(txtfathername, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtfatherocc_TextChanged(object sender, EventArgs e)
        {
            string fatherocc = txtfatherocc.Text;
            if (studentValidate.isNumber(fatherocc))
            {
                errorProvider1.SetError(txtfatherocc, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtfatheroccuadd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmothername_TextChanged(object sender, EventArgs e)
        {

            string mothernam = txtmothername.Text;
            if (studentValidate.isNumber(mothernam))
            {
                errorProvider1.SetError(txtmothername, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtmotheroccu_TextChanged(object sender, EventArgs e)
        {
            string motherocc = txtmotheroccu.Text;
            if (studentValidate.isNumber(motherocc))
            {
                errorProvider1.SetError(txtmotheroccu, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtmotheroccuadd_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnationality_TextChanged(object sender, EventArgs e)
        {
            string nation = txtnationality.Text;
            if (studentValidate.isNumber(nation))
            {
                errorProvider1.SetError(txtnationality, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            string cont = txtcontact.Text;
            int length = Convert.ToInt32(txtcontact.Text.Length);
            if ((studentValidate.isLetter(cont)) || (length != 10)) 
            {
                errorProvider1.SetError(txtcontact, "can contain only 10 digits");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtemername_TextChanged(object sender, EventArgs e)
        {
            string emernam = txtemername.Text; 
            if (studentValidate.isNumber(emernam))
            {
                errorProvider1.SetError(txtemername, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtemeraddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtemercontact_TextChanged(object sender, EventArgs e)
        {
            string emecont = txtemercontact.Text;
            int length = Convert.ToInt32(txtemercontact.Text.Length); 
            if ((studentValidate.isLetter(emecont)) || (length!=10)) 
            {
                errorProvider1.SetError(txtemercontact, "can contain only 10 digits");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void txtemerrelation_TextChanged(object sender, EventArgs e)
        {
            string emerrela = txtemerrelation.Text;
            if (studentValidate.isNumber(emerrela))
            {
                errorProvider1.SetError(txtemerrelation, "can contain only letters");
                metroTile1.Enabled = false;

            }
            else
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;


            }
        }

        private void searchreg_TextChanged(object sender, EventArgs e)
        {
            string sear = searchreg.Text;
            if (studentValidate.IsAllLettersOrDigits(sear))
            {
                errorProvider1.Clear();
                metroTile1.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(searchreg, "can contain only letters and digits");
                metroTile1.Enabled = false;
            }

        }

        private void searchreg_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

       



    }
}
