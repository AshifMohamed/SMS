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
namespace School
{
    public partial class Expences : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        public Expences()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 ||  metroTextBox1.Text == "" || textBox1.Text == "")
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
            metroComboBox1.SelectedIndex = -1 ;
            metroTextBox1.Text = "" ;
            textBox1.Text = "";

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroButton1.Text == "" || textBox1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes","warning");


            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert INTO exreq ( num,date ,category, amount, description ) VALUES('" + metroLabel1.Text + "','" + metroDateTime1.Value.ToString("MM/dd/yyyy") + "','" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroTextBox1.Text + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("An request was sent to the principal regurfing the expence");
                reset();
            }
        }

        private void Expences_Load(object sender, EventArgs e)
        {

        }
    }
}
