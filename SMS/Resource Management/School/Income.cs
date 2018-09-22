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
using MetroFramework.Forms;
using WindowsFormsApplication4;
namespace School
{
    public partial class Income : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        public Income()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroButton1.Text == "" || textBox1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes");


            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert INTO inex ( num,date ,category, amount, description ) VALUES('" + metroLabel1.Text + "','" + metroDateTime1.Value.ToString("MM/dd/yyyy") + "','" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroTextBox1.Text + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added");
                reset();
            }

        }
        private void reset()
        {
            metroComboBox1.SelectedIndex = -1;
            metroTextBox1.Text = "";
            textBox1.Text = "";

        }

        private void Income_Load(object sender, EventArgs e)
        {

        }
    }
}
