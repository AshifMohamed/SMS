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

namespace ExamITP
{
    public partial class placeExamTable : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        public placeExamTable()
        {
            InitializeComponent();
        }

        public void organize()
        {
            metroGrid1.Columns[0].HeaderText = "Placement ID";
            metroGrid1.Columns[1].HeaderText = "First Name";
            metroGrid1.Columns[2].HeaderText = "Middle Name";
            metroGrid1.Columns[3].HeaderText = "Last Name";
            metroGrid1.Columns[4].HeaderText = "Gender";
            metroGrid1.Columns[5].HeaderText = "Age";
            metroGrid1.Columns[6].HeaderText = "DOB";
            metroGrid1.Columns[7].HeaderText = "Religion";
            metroGrid1.Columns[8].HeaderText = "Nationality";
            metroGrid1.Columns[9].HeaderText = "Address";
            metroGrid1.Columns[10].HeaderText = "Land No";
            metroGrid1.Columns[11].HeaderText = "Mobile No";
            metroGrid1.Columns[12].HeaderText = "E-mail";
            
        }

        public void refreshPE()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT * FROM placeExam order by placeID";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            metroGrid1.DataSource = data;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            placeExam a1 = new placeExam(this);
            a1.metroLabel21.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
            a1.metroTextBox1.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            a1.metroTextBox2.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            a1.metroTextBox3.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            a1.metroComboBox1.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            a1.metroComboBox5.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            a1.dateTimePicker1.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            a1.metroComboBox3.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
            a1.metroTextBox10.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            a1.metroTextBox5.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            a1.metroTextBox4.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
            a1.metroTextBox9.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
            a1.metroTextBox6.Text = this.metroGrid1.CurrentRow.Cells[12].Value.ToString();
            a1.metroComboBox4.Text = this.metroGrid1.CurrentRow.Cells[13].Value.ToString();
            a1.metroTextBox8.Text = this.metroGrid1.CurrentRow.Cells[14].Value.ToString();
            a1.metroTextBox7.Text = this.metroGrid1.CurrentRow.Cells[15].Value.ToString();
            a1.metroButton1.Enabled = false;
            this.Hide();
            a1.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            refreshPE();
            organize();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedRows.Count > 0)
            {
                int selectedIndex = metroGrid1.SelectedRows[0].Index;

                int placeID = int.Parse(metroGrid1[0, selectedIndex].Value.ToString());
                string sql = "DELETE FROM placeExam WHERE placeID = @placeID";

                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = con;
                deleteRecord.CommandType = CommandType.Text;
                deleteRecord.CommandText = sql;

                SqlParameter RowParameter = new SqlParameter();
                RowParameter.ParameterName = "@placeID";
                RowParameter.SqlDbType = SqlDbType.Int;
                RowParameter.IsNullable = false;
                RowParameter.Value = placeID;

                deleteRecord.Parameters.Add(RowParameter);

                deleteRecord.Connection.Open();

                deleteRecord.ExecuteNonQuery();

                deleteRecord.Connection.Close();

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM placeExam order by placeID";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                metroGrid1.DataSource = data;
                organize();

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
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

        private void placeExamTable_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT * FROM placeExam order by placeID";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            metroGrid1.DataSource = data;
            organize();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            placeExam a = new placeExam(this);
            this.Hide();
            a.metroButton2.Enabled = false;
            a.Show();
        }
    }
}
