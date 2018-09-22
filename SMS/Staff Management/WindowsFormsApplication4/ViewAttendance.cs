using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ViewAttendance : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = DBAccess.GetConnection();
        public ViewAttendance()
        {
            InitializeComponent();
        }

        public void AttendanceFill()
        {

            try
            {

                conn.Open();
                SqlCommand Cmd = new SqlCommand("select ID,FirstName from RegEmployee ", conn);

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(String));
                dt.Columns.Add("FirstName", typeof(String));

                int mon = metroComboBox1.SelectedIndex + 1;
                for(int i=1;i<=(DateTime.DaysInMonth(DateTime.Today.Year, mon));i++)
                {
                   
                    DateTime dateValue = new DateTime(DateTime.Today.Year,mon ,i);
                    String day=" "+i.ToString() + Environment.NewLine+dateValue.DayOfWeek.ToString().Substring(0,3);
                    dt.Columns.Add(day, typeof(String));
                   
                
                }
                //   dt.Columns.Add("Status", typeof(String));

                SqlDataReader dr;
                dr = Cmd.ExecuteReader();

                while (dr.Read())
                {

                    {
                        dt.Rows.Add(dr["ID"], dr["FirstName"]);
                    }

                }
                dr.Close();
                metroGrid1.DataSource = dt;
               
                metroGrid1.Columns[0].Width = 50;
                metroGrid1.Columns[1].Width = 70;
                metroGrid1.Columns[1].HeaderText = "First Name";
        

                for (int i = 1; i <= (DateTime.DaysInMonth(DateTime.Today.Year, mon)); i++)
                {
                    metroGrid1.Columns[i+1].Width = 30;
                    DateTime dateValue = new DateTime(DateTime.Today.Year, mon, i);
                    String day = " " + i.ToString() + Environment.NewLine + dateValue.DayOfWeek.ToString().Substring(0, 3);
                    foreach (DataGridViewRow row in metroGrid1.Rows)
                    {
                        string empID = row.Cells["ID"].ToString();
                        if(dateValue.DayOfWeek.ToString()=="Saturday" ||dateValue.DayOfWeek.ToString()=="Sunday" )
                        {

                            row.Cells[i + 1].Value = "H";
                        
                        }
                        SqlCommand Cmd1 = new SqlCommand(" select Attendant  from EmpAttendance where Day = '" + dateValue + "' AND ID='" + empID + "' ", conn);
                        SqlDataReader dr1;
                        dr1 = Cmd1.ExecuteReader();

                        if (dr1.Read())
                        {
                            row.Cells[i+1].Value = dr1["Attendant"].ToString();
                         //   row.Cells[i + 1].Style.BackColor = Color.Red;
                           
                        }
                        dr1.Close();
                    }
                }
            
                //    Cmd.ExecuteNonQuery();
                conn.Close();
    

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {
           int i= Convert.ToInt32( DateTime.Now.Month.ToString());
           metroComboBox1.SelectedIndex = i - 1;
            AttendanceFill();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttendanceFill();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files (2003)|*.xls|Excel Files(2007)|*.xlsx";

            if(saveFileDialog1.ShowDialog()!=DialogResult.Cancel)
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
                    
                    
            }
           
                                              
        }
    }

