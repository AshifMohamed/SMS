﻿using System;
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
    public partial class furniture : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        private string[] comboBox1Range = new[] { "Class Room", "Office", "Auditorium" };
        private string[] comboBox2RangeA1 = new[] { "Desks", "Chairs", "White Bord", "Tearchers Chair", "Teachers Table" };
        private string[] comboBox2RangeB1 = new[] { "File Cabinet", "Table", "Chair", "Computer", "4", "5" };
        private string[] comboBox2RangeC1 = new[] { "", "Small Test Tube", "U tube", "Dropper" };
    

        public furniture()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void furniture_Load(object sender, EventArgs e)
        {
            display();
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
                //  SqlCommand cmd = new SqlCommand("insert INTO furniture ( itemcategory, itemname, quantity, date ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroTextBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);
                int qun = Convert.ToInt32(this.metroTextBox1.Text);
                string name = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
                SqlCommand cmd = new SqlCommand("update furniture set quantity = quantity + '" + qun + "' where itemname = '" + name + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                display();
                reset();
            }

        }
        void display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from furniture", con);
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 || metroButton1.Text == "")
                MessageBox.Show(" Please enter a value into all boxes");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE furniture  SET itemcategory='" + metroComboBox1.SelectedItem + "',itemname='" + metroComboBox2.SelectedItem + "', quantity='" + metroTextBox1.Text + "', date= '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' where id = '" + textBoxX1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success");
                display();
                reset();
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;



            switch (selectedValue)
            {
                case "Class Room":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeA1);
                    break;
                case "Office":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeB1);
                    break;
                case "Auditorium":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeC1);
                    break;
            }


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            furniture_damaged fd = new furniture_damaged();
            this.Hide();
            fd.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBoxX1.Text = dr.Cells[0].Value.ToString();
            metroTextBox1.Text = dr.Cells[3].Value.ToString();
            metroComboBox1.SelectedItem = dr.Cells[1].Value.ToString();
            metroComboBox2.SelectedItem = dr.Cells[2].Value.ToString();

        }


    }
}
