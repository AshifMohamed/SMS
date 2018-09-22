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
    public partial class yearEnd : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        public yearEnd()
        {
            InitializeComponent();
            metroComboBox1.Text = "1";
            Load += yearEnd_Load;
        }

        public void organize()
        {
            metroGrid1.Columns[0].HeaderText = "Admission No";
            metroGrid1.Columns[1].HeaderText = "First Name";
            metroGrid1.Columns[2].HeaderText = "Last Name";
        }

        public void refreshYE()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            if (metroComboBox1.Text == "1" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '1'";
            }
            else if (metroComboBox1.Text == "2" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '2'";
            }
            else if (metroComboBox1.Text == "3" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '3'  ";
            }
            else if (metroComboBox1.Text == "4" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '4'";
            }
            else if (metroComboBox1.Text == "5" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '5' ";
            }
            else if (metroComboBox1.Text == "6" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '6' ";
            }
            else if (metroComboBox1.Text == "7" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '7' ";
            }
            else if (metroComboBox1.Text == "8" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '8'";
            }
            else if (metroComboBox1.Text == "9" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '9'  ";
            }
            else if (metroComboBox1.Text == "10" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '10'  ";
            }
            else if (metroComboBox1.Text == "11" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '11' ";
            }
            else if (metroComboBox1.Text == "12" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '12' ";
            }
            else if (metroComboBox1.Text == "13" )
            {
                command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '13' ";
            }
            else
            {

            }
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            metroGrid1.DataSource = data;
        }

        public void updateYE()
        {
            string query = "DROP TABLE yearEnd";
            string query1 = "select t.AdmissionNo,t.fname,t.surname,t.admissionGrade,avg(cast(t.English as int)) as English,avg(cast(t.Mathematics as int)) as Mathematics,avg(cast(t.Creativity as int)) as Creativity,avg(cast(t.Environmental as int)) as Environmental,avg(cast(t.Religion as int)) as Religion,avg(cast(t.firstLang as int)) as FirstLang,avg(cast(t.Art as int)) as Art,avg(cast(t.Science as int)) as Science,avg(cast(t.ICT as int)) as ICT,avg(cast(t.IT as int)) as IT,avg(cast(t.History as int)) as History,avg(cast(t.Language as int)) as Language,avg(cast(t.healthSci as int)) as HealthSci,avg(cast(t.Englit as int)) as Englit,avg(cast(t.Commerce as int)) as Commerce,avg(cast(t.OLopt1 as int)) as OLopt1,avg(cast(t.OLopt2 as int)) as OLopt2,avg(cast(t.OLopt3 as int)) as OLopt3,avg(cast(t.ALopt1 as int)) as ALopt1,avg(cast(t.ALopt2 as int)) as ALopt2,avg(cast(t.ALopt3 as int)) as ALopt3,avg(cast(t.ALopt4 as int))  as ALopt4,avg(cast(t.Total as int)) as Total,avg(cast(t.Average as int)) as Average,t.Rank into yearEnd from ( select * from LonGTerm1 where admissionGrade='1' union all select * from LonGTerm2 where admissionGrade='1' union all select * from LonGTerm3 where admissionGrade='1' union all select * from LonGTerm1 where admissionGrade='2' union all select * from LonGTerm2 where admissionGrade='2' union all select * from LonGTerm3 where admissionGrade='2' union all select * from LonGTerm1 where admissionGrade='3' union all select * from LonGTerm2 where admissionGrade='3' union all select * from LonGTerm3 where admissionGrade='3' union all  select * from LonGTerm1 where admissionGrade='4' union all select * from LonGTerm2 where admissionGrade='4' union all select * from LonGTerm3 where admissionGrade='4' union all select * from LonGTerm1 where admissionGrade='5' union all select * from LonGTerm2 where admissionGrade='5' union all select * from LonGTerm3 where admissionGrade='5' union all select * from LonGTerm1 where admissionGrade='6' union all select * from LonGTerm2 where admissionGrade='6' union all select * from LonGTerm3 where admissionGrade='6' union all select * from LonGTerm1 where admissionGrade='7' union all select * from LonGTerm2 where admissionGrade='7' union all select * from LonGTerm3 where admissionGrade='7' union all select * from LonGTerm1 where admissionGrade='8' union all select * from LonGTerm2 where admissionGrade='8' union all select * from LonGTerm3 where admissionGrade='8' union all select * from LonGTerm1 where admissionGrade='9' union all select * from LonGTerm2 where admissionGrade='9' union all select * from LonGTerm3 where admissionGrade='9' union all select * from LonGTerm1 where admissionGrade='10' union all select * from LonGTerm2 where admissionGrade='10' union all select * from LonGTerm3 where admissionGrade='10' union all select * from LonGTerm1 where admissionGrade='11' union all select * from LonGTerm2 where admissionGrade='11' union all select * from LonGTerm3 where admissionGrade='11' union all select * from LonGTerm1 where admissionGrade='12' union all select * from LonGTerm2 where admissionGrade='12' union all select * from LonGTerm3 where admissionGrade='12' union all select * from LonGTerm1 where admissionGrade='13' union all select * from LonGTerm2 where admissionGrade='13' union all select * from LonGTerm3 where admissionGrade='13' ) t group by t.AdmissionNo,t.fname,t.surname,t.admissionGrade,t.Rank";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            da.Fill(dt);
            da1.Fill(dt1);
            metroGrid1.DataSource = dt;
            metroGrid1.DataSource = dt1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroComboBox1.Text == "" )
            {
                MessageBox.Show("Fill the empty fields");
            }

            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                
                    if (metroComboBox1.Text == "1")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '1'";
                    }
                    else if (metroComboBox1.Text == "2")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '2'";
                    }
                    else if (metroComboBox1.Text == "3")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '3'  ";
                    }
                    else if (metroComboBox1.Text == "4")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Creativity,Environmental,Religion,firstLang,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade  = '4'";
                    }
                    else if (metroComboBox1.Text == "5")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Art,Science,IT,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '5' ";
                    }
                    else if (metroComboBox1.Text == "6")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '6' ";
                    }
                    else if (metroComboBox1.Text == "7")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '7' ";
                    }
                    else if (metroComboBox1.Text == "8")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '8'";
                    }
                    else if (metroComboBox1.Text == "9")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,Science,ICT,History,Englit,Commerce,Language,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '9'  ";
                    }
                    else if (metroComboBox1.Text == "10")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '10'  ";
                    }
                    else if (metroComboBox1.Text == "11")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,English,Mathematics,OLopt1,OLopt2,OLopt3,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '11' ";
                    }
                    else if (metroComboBox1.Text == "12")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '12' ";
                    }
                    else if (metroComboBox1.Text == "13")
                    {
                        command.CommandText = "SELECT AdmissionNo,fname,surname,ALopt1,ALopt2,ALopt3,ALopt4,English,Total,[Average],DENSE_RANK() OVER (ORDER BY Average DESC) AS [Rank] FROM yearEnd where admissionGrade = '13' ";
                    }
                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    metroGrid1.DataSource = data;
                    metroButton3.Enabled = true;
                    metroButton4.Enabled = true;
                
                
                

            }
        }

        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            updateYE();
            refreshYE();
            organize();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "" )
            {
                MessageBox.Show("Fill the empty fields");
            }

            else
            {
                
                    if (metroComboBox1.Text.ToString() == "1" || metroComboBox1.Text.ToString() == "2")
                    {
                        topAch a = new topAch();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "3" || metroComboBox1.Text.ToString() == "4")
                    {
                        topAch3 a = new topAch3();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "5")
                    {
                        topAch5 a = new topAch5();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "6")
                    {
                        topAch6 a = new topAch6();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "7")
                    {
                        topAch7 a = new topAch7();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        this.Hide();
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "8" || metroComboBox1.Text.ToString() == "9")
                    {
                        topAch8 a = new topAch8();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        this.Hide();
                        a.Show();
                    }
                    else if (metroComboBox1.Text.ToString() == "10" || metroComboBox1.Text.ToString() == "11")
                    {
                        topAch10 a = new topAch10();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        this.Hide();
                        a.Show();
                    }

                   else if (metroComboBox1.Text.ToString() == "12" || metroComboBox1.Text.ToString() == "13")
                    {
                        topAch12 a = new topAch12();
                        a.PassValue(metroComboBox1.SelectedItem.ToString());
                        this.Hide();
                        a.Show();
                    }
                    
                else
                {

                }

            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void yearEnd_Load(object sender, EventArgs e)
        {
            metroButton1.PerformClick();
            organize();
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void metroButton6_Click(object sender, EventArgs e)
        {
            cryRep a = new cryRep();
            a.Show();
        }
    }
}
