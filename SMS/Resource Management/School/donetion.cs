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
    public partial class donetion : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
        private string[] comboBox1Range = new[] { "Sports", "Computer Lab", "Laboratory" };
        private string[] comboBox2RangeAA = new[] { "Cricket", "Hockey", "Football", "volleyball", "Chess" };
        private string[] comboBox3RangeA = new[] { "Ball", "Bat", "Pads", "Ball gurd", "Shoes", "Wickets", "Helmat" };
        private string[] comboBox3RangeB = new[] { "Hockey Stick", "Shoes", "Mouth Guard", "Ball", "Stick Bag", "Goli kit" };
        private string[] comboBox3RangeC = new[] { "Foot Ball", "Footwear", "Soccer Socks", "Shin-Guards", "Net" };
        private string[] comboBox3RangeD = new[] { "Balls", "Net", "Posts and Cables", "Shoes", "Knee pads" };
        private string[] comboBox3RangeE = new[] { "Chess Sets", "Chess Pieces", "Chess Clock" };
        private string[] comboBox2RangeBB = new[] { "Printers", "Routers", "Monitors", "CPU", "UPS" };
        private string[] comboBox3RangeA1 = new[] { "Printer", "Printing paprers", "cartridge", "Cleaning equipments", "Power Cables", "Printer cable" };
        private string[] comboBox3RangeB1 = new[] { "Routers", "RJ 45 cable", "Connectors", "Ball", "Stick Bag", "Goli kit" };
        private string[] comboBox3RangeC1 = new[] { "Moniters", "Screen Gurd", "VGA Cable", "Power Cable" };
        private string[] comboBox3RangeD1 = new[] { "CPU", "Ram", "Had Drive", "Cables", "Mouse", "Keybord", "Web Cam" };
        private string[] comboBox3RangeE1 = new[] { "UPS", "Connector", "Power Cable" };
        private string[] comboBox2RangeCC = new[] { "Flasks", "Equipments ", "Tubes", "Books", "Solid Meterials", "liquid Metirials" };
        private string[] comboBox3RangeA2 = new[] { "Conical Flask", "Volumetric Flask", "Round-Bottom Flask", "Retort Flask", "Starus Flask", "Kjedahl Flask" };
        private string[] comboBox3RangeB2 = new[] { "Routers", "RJ 45 cable", "Connectors", "Ball", "Stick Bag", "Goli kit" };
        private string[] comboBox3RangeC2 = new[] { "Y Tube", "Small Test Tube", "U tube", "Dropper" };
        private string[] comboBox3RangeD2 = new[] { "CPU", "Ram", "Had Drive", "Cables", "Mouse", "Keybord", "Web Cam" };
        private string[] comboBox3RangeE2 = new[] { "UPS", "Connector", "Power Cable" };

        public donetion()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            metroComboBox2.SelectedIndexChanged += metroComboBox2_SelectedIndexChanged;
            metroComboBox2.Items.AddRange(comboBox2RangeAA);

        }


        private void donetion_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1)

                    MessageBox.Show(" Please enter a value into all boxes");
                else if (50 < int.Parse(metroTextBox1.Text))
                {
                    MessageBox.Show(" Please enter a reasonable Number");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert INTO donetion_ass ( id,name,date,itemcategory,dividion,itemname,quantity ) VALUES('" + int.Parse(metroTextBox2.Text) + "','" + metroTextBox3.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + metroComboBox3.GetItemText(metroComboBox3.SelectedItem) + "','" + metroTextBox1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Success");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            reset();

       }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "Sports":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeAA);
                    break;
                case "Computer Lab":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeBB);
                    break;
                case "Laboratory":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeBB);
                    break;



            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox2.SelectedItem as string;

            switch (selectedValue)
            {
                case "Cricket":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeA);
                    break;
                case "Football":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeC);
                    break;
                case "Hockey":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeB);
                    break;
                case "volleyball":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeD);
                    break;
                case "Chess":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeD);
                    break;
                case "Printers":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeA1);
                    break;
                case "Routers":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeB1);
                    break;
                case "Monitors":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeC1);
                    break;
                case "CPU":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeD1);
                    break;
                case "UPS":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeE1);
                    break;
                case "Flasks":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeA2);
                    break;
                case "Equipments":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeB2);
                    break;
                case "Tubes":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeC2);
                    break;
                case "Books":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeD2);
                    break;
                case "Solid Metirials":
                    metroComboBox3.Items.Clear();
                    metroComboBox3.Items.AddRange(comboBox3RangeE2);
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       public void reset()
        {

            metroComboBox1.SelectedItem = -1;
            metroTextBox1.Text = "";
            metroComboBox2.SelectedItem = -1;
            metroTextBox3.Text = "";
            metroComboBox3.SelectedItem = -1;
            metroTextBox3.Text = "";
       }
    }

}
