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
    public partial class sports : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        private string[] comboBox1Range = new[] { "Cricket", "Hockey", "Football", "volleyball", "Chess" };
        private string[] comboBox2RangeA = new[] { "Ball", "Bat", "Pads", "Ball gurd", "Shoes", "Wickets", "Helmat" };
        private string[] comboBox2RangeB = new[] { "Hockey Stick", "Shoes", "Mouth Guard", "Ball", "Stick Bag", "Goli kit" };
        private string[] comboBox2RangeC = new[] { "Foot Ball", "Footwear", "Soccer Socks", "Shin-Guards", "Net" };
        private string[] comboBox2RangeD = new[] { "Balls", "Net", "Posts and Cables", "Shoes", "Knee pads" };
        private string[] comboBox2RangeE = new[] { "Chess Sets", "Chess Pieces", "Chess Clock" };


        public sports()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Application.DoEvents();
          
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxX1.Text = row.Cells["id"].Value.ToString();
                metroComboBox1.SelectedValue = row.Cells["itemcategory"].Value.ToString();
                metroComboBox1.SelectedValue = row.Cells["itemname"].Value.ToString();
                metroTextBox1.Text = row.Cells["quantity"].Value.ToString();
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "Cricket":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeA);
                    break;
                case "Hockey":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeB);
                    break;
                case "volleyball":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeD);
                    break;
                case "Football":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeC);
                    break;
                case "Chess":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeE);
                    break;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroButton1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes");
            else if (50 < int.Parse(metroTextBox1.Text))
            {
                MessageBox.Show(" Please enter a reasonable Number");
            }

            else
            {
                con.Open();
               //  SqlCommand cmd = new SqlCommand("insert INTO krida ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
                int qun = Convert.ToInt32(this.metroTextBox1.Text);
                string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
               SqlCommand cmd = new SqlCommand("update krida set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                display();
                //reset();
            }

        }

        private void sports_Load(object sender, EventArgs e)
        {
            display();

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroButton1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE krida  SET itemcategory='" + metroComboBox1.SelectedItem + "',itemname='" + metroComboBox2.SelectedItem + "', quantity='" + metroTextBox1.Text + "', date= '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' where id = '" + textBoxX1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success");
                display();
                reset();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBoxX1.Text = dr.Cells[0].Value.ToString();
            metroTextBox1.Text = dr.Cells[3].Value.ToString();
            metroComboBox1.SelectedItem = dr.Cells[1].Value.ToString();
            metroComboBox2.SelectedItem = dr.Cells[2].Value.ToString();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            sports_arc f = new sports_arc();
            this.Hide();
            f.Show();

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        
        void reset()
        {
            metroComboBox1.SelectedItem = -1;
            metroComboBox2.SelectedItem = -1;
            textBoxX1.Text = "";
            metroTextBox1.Text = "";
        }
        void display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from krida", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        
        }

        
    }
}
