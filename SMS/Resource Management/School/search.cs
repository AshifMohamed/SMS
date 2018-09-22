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
    public partial class search : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        private string[] comboBox1Range = new[] { "krida", "Comlab", "lab" };
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

        public search()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);
            metroComboBox2.SelectedIndexChanged += metroComboBox2_SelectedIndexChanged;
            metroComboBox2.Items.AddRange(comboBox2RangeAA);

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "krida":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeAA);
                    break;
                case "Comlab":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeBB);
                    break;
                case "Lab":
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
                        try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from " + metroComboBox1.SelectedItem + " where itemname = '" + metroComboBox3.SelectedItem + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                metroGrid1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = item[0].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = item[1].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = item[2].ToString();
                    metroGrid1.Rows[n].Cells[3].Value = item[3].ToString();
                    metroGrid1.Rows[n].Cells[4].Value = item[4].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        }
    
}
