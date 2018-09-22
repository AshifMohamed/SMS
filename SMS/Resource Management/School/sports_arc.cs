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
using System.Data.Sql;
using WindowsFormsApplication4;

namespace School
{
    public partial class sports_arc : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        private string[] comboBox1Range = new[] { "Cricket", "Hockey", "Football", "volleyball", "Chess" };
        private string[] comboBox2RangeA = new[] { "Ball", "Bat", "Pads", "Ball gurd", "Shoes", "Wickets", "Helmat" };
        private string[] comboBox2RangeB = new[] { "Hockey Stick", "Shoes", "Mouth Guard", "Ball", "Stick Bag", "Goli kit" };
        private string[] comboBox2RangeC = new[] { "Foot Ball", "Footwear", "Soccer Socks", "Shin-Guards", "Net" };
        private string[] comboBox2RangeD = new[] { "Balls", "Net", "Posts and Cables", "Shoes", "Knee pads" };
        private string[] comboBox2RangeE = new[] { "Chess Sets", "Chess Pieces", "Chess Clock" };

        public sports_arc()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         
        }

        private void sports_arc_Load(object sender, EventArgs e)
        {
            display();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                textBoxX1.Text = row.Cells["Id"].Value.ToString();
                metroComboBox1.SelectedValue = row.Cells["Itemcategory"].Value.ToString();
                metroComboBox1.SelectedValue = row.Cells["Itemname"].Value.ToString();
                textBoxX1.Text = row.Cells["Quantity"].Value.ToString();
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
            
            //con.Open();
            //    string sql ="select quantity from krida_arc where itemname = '"+metroComboBox1.SelectedItem+"'";
            //    SqlCommand cmd  = new SqlCommand(sql,con);
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    sdr.Read();
            //    int qty = Convert.ToInt32(sdr["quantity"]);
            //    con.Close();
            
            //            int qun1 = Convert.ToInt32(this.textBoxX1.Text);
             
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroButton1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes");
            //else if (50 < Convert.ToInt32(this.textBoxX1.Text))
            //{
            //    MessageBox.Show(" Please enter a reasonable Number");
            //}
            ////else if (qty < qun1 )
            //{
            //    MessageBox.Show(" Avalable quntity is less than the quantity you entered");
            //}
            else
            {
                con.Open();
               // SqlCommand cmd1 = new SqlCommand("insert INTO krida_arc ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
               int qun = Convert.ToInt32(this.textBoxX1.Text);
                string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
                SqlCommand cmd1 = new SqlCommand("update krida_arc set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);
                SqlCommand cmd2 = new SqlCommand("update krida set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);
                
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroTextBox1.Text == "")
            {
                MessageBox.Show(" Please enter a value into all boxes");
            }

            else
            {
                {
                    int qun = Convert.ToInt32(this.textBoxX1.Text);
                    string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update krida_arc set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                }
           
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            int qun = Convert.ToInt32(this.textBoxX1.Text);
            string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update krida_arc set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);
            SqlCommand cmd = new SqlCommand("update krida set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            display();
            reset();

           }
        void reset()
        {
            metroComboBox1.SelectedItem = -1;
            metroComboBox2.SelectedItem = -1;
            textBoxX1.Text = "";
            metroTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comlab c = new comlab();
            this.Hide();
            c.Show();
        
        }
        void display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from krida_arc", con);
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
