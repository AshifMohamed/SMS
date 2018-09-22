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

namespace ExamITP
{
    public partial class examProcess : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        public examProcess()
        {
            InitializeComponent();
            metroComboBox1.Text = "1";
            metroComboBox3.Text = "Term1";
            Load += examProcess_Load;
            
        }

        public void organize()
        {
            metroGrid1.Columns[0].HeaderText = "Admission No";
            metroGrid1.Columns[1].HeaderText = "First Name";
            metroGrid1.Columns[2].HeaderText = "Last Name";
        }

        public void refreshExProcess()
        {
            if (metroComboBox1.Text == "" ||  metroComboBox3.Text == "")
            {
                MessageBox.Show("Fill the empty fields");
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                if (metroComboBox3.Text == "Term1")
                {
                    if (metroComboBox1.Text == "1" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '13' ";
                    }
                    
                }
                else if (metroComboBox3.Text == "Term2")
                {
                    if (metroComboBox1.Text == "1" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '13' ";
                    }
                    
                }
                else if (metroComboBox3.Text == "Term3")
                {
                    if (metroComboBox1.Text == "1" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13" )
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '13' ";
                    }

                }

                else
                {

                }


                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                metroGrid1.DataSource = data;
            }
        }

        public void updateExProcess()
        {
            if (metroComboBox1.Text == "" || metroComboBox3.Text == "")
            {
                MessageBox.Show("Fill the empty fields");
            }
            else
            {
                if (metroComboBox3.Text.ToString() == "Term1")
                {
                    string query = "insert into LonGTerm1(AdmissionNo,fname,surname,admissionGrade) select stud_regis.AdmissionNo,stud_regis.fname,stud_regis.surname,stud_regis.admissionGrade from stud_regis  WHERE NOT EXISTS(select AdmissionNo from LonGTerm1 where stud_regis.AdmissionNo=LonGTerm1.AdmissionNo )  ;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    metroGrid1.DataSource = dt;
                }
                else if (metroComboBox3.Text.ToString() == "Term2")
                {
                    string query = "insert into LonGTerm2(AdmissionNo,fname,surname,admissionGrade) select stud_regis.AdmissionNo,stud_regis.fname,stud_regis.surname,stud_regis.admissionGrade from stud_regis  WHERE NOT EXISTS(select AdmissionNo from LonGTerm2 where stud_regis.AdmissionNo=LonGTerm2.AdmissionNo )  ;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    metroGrid1.DataSource = dt;
                }
                else if (metroComboBox3.Text.ToString() == "Term3")
                {
                    string query = "insert into LonGTerm3(AdmissionNo,fname,surname,admissionGrade) select stud_regis.AdmissionNo,stud_regis.fname,stud_regis.surname,stud_regis.admissionGrade from stud_regis  WHERE NOT EXISTS(select AdmissionNo from LonGTerm3 where stud_regis.AdmissionNo=LonGTerm3.AdmissionNo )  ;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    metroGrid1.DataSource = dt;
                }
               
                else
                {

                }
            }
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "" || metroComboBox3.Text == "")
            {
                MessageBox.Show("Fill the empty fields");
            }

            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                
                
                    if (metroComboBox1.Text == "1" && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5" && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13"  && metroComboBox3.Text == "Term1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm1 where admissionGrade = '13' ";
                    }
                    else if (metroComboBox1.Text == "1"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8" && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11"  && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12" && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13" && metroComboBox3.Text == "Term2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm2 where admissionGrade = '13' ";
                    }
                    else if (metroComboBox1.Text == "1"  && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13" && metroComboBox3.Text == "Term3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM LonGTerm3 where admissionGrade = '13' ";
                    }

                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    metroGrid1.DataSource = data;
                    
                
                
                
            }
        }

        private void examProcess_Load(object sender, EventArgs e)
        {
            metroButton1.PerformClick();
            organize();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


            if (metroComboBox1.Text == "" ||  metroComboBox3.Text == "")
            {
                MessageBox.Show("Fill the empty fields");
            }

            else
            {
                
                    if (metroComboBox1.Text.ToString() == "1" || metroComboBox1.Text.ToString() == "2")
                    {
                        AddMarksG1 a1 = new AddMarksG1(this);
                        if (metroGrid1.CurrentRow != null)
                        {
                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue( metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }
                    }
                    else if (metroComboBox1.Text.ToString() == "3" || metroComboBox1.Text.ToString() == "4")
                    {
                        AddMarksG3 a1 = new AddMarksG3(this);
                        if (metroGrid1.CurrentRow != null)
                        {
                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue(metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }
                    }
                    else if (metroComboBox1.Text.ToString() == "5")
                    {
                        AddMarksG5 a1 = new AddMarksG5(this);
                        if (metroGrid1.CurrentRow != null)
                        {
                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue(metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }

                    }
                    else if (metroComboBox1.Text.ToString() == "6")
                    {
                        AddMarksG6 a1 = new AddMarksG6(this);
                        if (metroGrid1.CurrentRow != null)
                        {
                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();

                            a1.metroButton2.Enabled = false;
                            a1.PassValue(metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");

                        }
                    }
                    else if (metroComboBox1.Text.ToString() == "7")
                    {
                        AddMarksG7 a1 = new AddMarksG7(this);
                        if (metroGrid1.CurrentRow != null)
                        {

                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue( metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");

                        }
                    }
                    else if (metroComboBox1.Text.ToString() == "8" || metroComboBox1.Text.ToString() == "9")
                    {
                        AddMarksG8 a1 = new AddMarksG8(this);
                        if (metroGrid1.CurrentRow != null)
                        {

                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroTextBox7.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroTextBox8.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[12].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue( metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }
                    }

                    else if (metroComboBox1.Text.ToString() == "10" || metroComboBox1.Text.ToString() == "11")
                    {
                        AddMarksG10 a1 = new AddMarksG10(this);
                        if (metroGrid1.CurrentRow != null)
                        {

                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue( metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }
                    }

                    else if (metroComboBox1.Text.ToString() == "12" || metroComboBox1.Text.ToString() == "13")
                    {
                        AddMarksG12 a1 = new AddMarksG12(this);
                        if (metroGrid1.CurrentRow != null)
                        {
                            a1.metroLabel15.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
                            a1.metroLabel16.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                            a1.metroLabel4.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
                            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
                            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
                            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
                            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
                            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
                            a1.metroLabel17.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
                            a1.metroLabel18.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
                            a1.metroButton2.Enabled = false;
                            a1.PassValue(metroComboBox1.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString());
                            a1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nothing to edit");
                        }
                    }
            } 
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            updateExProcess();
            refreshExProcess();
            organize();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string searchValue = metroTextBox1.Text;

            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Enter correct Admission No ");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide(); 
            a.Show();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                if (metroComboBox3.Text == "Term1")
                {
                    int selectedIndex = metroGrid1.SelectedRows[0].Index;

                    string AdmissionNo = metroGrid1[0, selectedIndex].Value.ToString();
                    string sql = "DELETE FROM LonGTerm1 WHERE AdmissionNo = @AdmissionNo";

                    SqlCommand deleteRecord = new SqlCommand();
                    deleteRecord.Connection = con;
                    deleteRecord.CommandType = CommandType.Text;
                    deleteRecord.CommandText = sql;

                    SqlParameter RowParameter = new SqlParameter();
                    RowParameter.ParameterName = "@AdmissionNo";
                    RowParameter.SqlDbType = SqlDbType.VarChar;
                    RowParameter.IsNullable = false;
                    RowParameter.Value = AdmissionNo;

                    deleteRecord.Parameters.Add(RowParameter);

                    deleteRecord.Connection.Open();

                    deleteRecord.ExecuteNonQuery();

                    deleteRecord.Connection.Close();

                    updateExProcess();
                    refreshExProcess();
                    organize();
                } 
                else if (metroComboBox3.Text == "Term2")
                {
                    int selectedIndex = metroGrid1.SelectedRows[0].Index;

                    string AdmissionNo = metroGrid1[0, selectedIndex].Value.ToString();
                    string sql = "DELETE FROM LonGTerm2 WHERE AdmissionNo = @AdmissionNo";

                    SqlCommand deleteRecord = new SqlCommand();
                    deleteRecord.Connection = con;
                    deleteRecord.CommandType = CommandType.Text;
                    deleteRecord.CommandText = sql;

                    SqlParameter RowParameter = new SqlParameter();
                    RowParameter.ParameterName = "@AdmissionNo";
                    RowParameter.SqlDbType = SqlDbType.VarChar;
                    RowParameter.IsNullable = false;
                    RowParameter.Value = AdmissionNo;

                    deleteRecord.Parameters.Add(RowParameter);

                    deleteRecord.Connection.Open();

                    deleteRecord.ExecuteNonQuery();

                    deleteRecord.Connection.Close();

                    updateExProcess();
                    refreshExProcess();
                    organize();
                }
                else if (metroComboBox3.Text == "Term3")
                {
                    try
                    {
                        int selectedIndex = metroGrid1.SelectedRows[0].Index;

                        string AdmissionNo = metroGrid1[0, selectedIndex].Value.ToString();
                        string sql = "DELETE FROM LonGTerm3 WHERE AdmissionNo = @AdmissionNo";

                        SqlCommand deleteRecord = new SqlCommand();
                        deleteRecord.Connection = con;
                        deleteRecord.CommandType = CommandType.Text;
                        deleteRecord.CommandText = sql;

                        SqlParameter RowParameter = new SqlParameter();
                        RowParameter.ParameterName = "@AdmissionNo";
                        RowParameter.SqlDbType = SqlDbType.VarChar;
                        RowParameter.IsNullable = false;
                        RowParameter.Value = AdmissionNo;

                        deleteRecord.Parameters.Add(RowParameter);

                        deleteRecord.Connection.Open();

                        deleteRecord.ExecuteNonQuery();

                        deleteRecord.Connection.Close();

                        updateExProcess();
                        refreshExProcess();
                        organize();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                }
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            
            worksheet.Columns.ColumnWidth = 20;
            for (int i = 1; i < metroGrid1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = metroGrid1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < metroGrid1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < metroGrid1.Columns.Count; j++)
                {
                    if (metroGrid1.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = metroGrid1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            
        }
    }
}


        