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
    public partial class lab_arc : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        private string[] comboBox1Range = new[] { "Flasks", "Equipments ", "Tubes", "Books", "Solid Meterials", "liquid Metirials" };
        private string[] comboBox2RangeA1 = new[] { "Conical Flask", "Volumetric Flask", "Round-Bottom Flask", "Retort Flask", "Starus Flask", "Kjedahl Flask" };
        private string[] comboBox2RangeB1 = new[] { "Gas", "Magnifying Glass", "Scale", "Bunsen Burner", "Funnel", "Spectro Meter" };
        private string[] comboBox2RangeC1 = new[] { "Y Tube", "Small Test Tube", "U tube", "Dropper" };
        private string[] comboBox2RangeD1 = new[] { "Uncle Tungsten", "Lehninger Principles of Biochemistry", "The Golden Book of Chemistry Experiments", "The Sceptical Chymist", "CRC Handbook of Chemistry and Physics", "The Cartoon Guide to Chemistry", "Encyclopedia of Reagents for Organic Synthesis" };
        private string[] comboBox2RangeE1 = new[] { "Sodium", "Potassium", "Carbon", "Magneesium" };
       
        public lab_arc()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        

        }

        private void lab_arc_Load(object sender, EventArgs e)
        {
            display();
 
        }
        void display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from lab", con);
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
        void reset()
        {
            metroComboBox1.SelectedItem = -1;
            metroComboBox2.SelectedItem = -1;
            textBoxX1.Text = "";
            metroTextBox1.Text = "";
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
                SqlCommand cmd1= new SqlCommand("insert INTO krida_arc ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
         //       int qun = Convert.ToInt32(this.metroTextBox1.Text);
           //     string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
             //   SqlCommand cmd1 = new SqlCommand("update lab_arc set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);
               // SqlCommand cmd2 = new SqlCommand("update lab set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);

                cmd1.ExecuteNonQuery();
                //cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                display();
                reset();
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "Flasks":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeA1);
                    break;
                case "Equipments":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeB1);
                    break;
                case "Tubes":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeC1);
                    break;
                case "Books":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeD1);
                    break;
                case "Solid Meterials":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeD1);
                    break;
                case "liquid Metirials":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeE1);
                    break;
            }

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
                    textBoxX1.Text = row.Cells[0].Value.ToString();
                    metroComboBox1.SelectedValue = row.Cells[1].Value.ToString();
                    metroComboBox1.SelectedValue = row.Cells[2].Value.ToString();
                    metroTextBox1.Text = row.Cells[3].Value.ToString();
                }
            }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
                        if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroTextBox1.Text == "")
            {
                MessageBox.Show(" Please enter a value into all boxes");
            }

            else
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("insert INTO krida_arc ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
                int qun = Convert.ToInt32(this.metroTextBox1.Text);
                string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
                SqlCommand cmd1 = new SqlCommand("update lab_arc set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);
                SqlCommand cmd2 = new SqlCommand("update lab set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                display();
                reset();
            
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            //SqlCommand cmd = new SqlCommand("insert INTO krida_arc ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
            int qun = Convert.ToInt32(this.metroTextBox1.Text);
            string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
            SqlCommand cmd1 = new SqlCommand("update lab_arc set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);
           // SqlCommand cmd2 = new SqlCommand("update lab set quantity = quantity - '" + qun + "' where itemname = '" + name + "'", con);

            cmd1.ExecuteNonQuery();
           // cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            display();
            reset();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            furniture f = new furniture();
            this.Hide();
            f.Show();
        }

        }


    }



