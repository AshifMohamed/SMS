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
using System.Net;
using System.Net.Mail;
using MetroFramework.Forms;
using WindowsFormsApplication4;
namespace School

{
    public partial class request : MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        private string[] comboBox1Range = new[] { "SPORTS", "COMPUTER LAB", "LABORATORY", };
        private string[] comboBox2RangeC = new[] { "Cricket", "Hockey", "Football", "volleyball", "Chess" };
        private string[] comboBox2RangeB = new[] { "Printers", "Routers", "Monitors", "CPU", "UPS" };
        private string[] comboBox2RangeA = new[] { "Flasks", "Equipments ", "Tubes", "Books", "Solid Meterials", "liquid Metirials" };

        public request()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
            metroComboBox1.Items.AddRange(comboBox1Range);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == -1 || metroComboBox2.SelectedIndex == -1 )
                MessageBox.Show(" Please enter a value into all boxes");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert INTO admin_req ( itemcategory, itemname, quantity,  ) VALUES('" + metroComboBox1.GetItemText(metroComboBox1.SelectedItem) + "','" + metroComboBox2.GetItemText(metroComboBox2.SelectedItem) + "','" + textBox5.Text + "',)", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Request Was Successfully Sent ");
                reset();
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = metroComboBox1.SelectedItem as string;

            switch (selectedValue)
            {
                case "SPORTS":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeA);
                    break;
                case "COMPUTER LAB":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeB);
                    break;
                case "LABORATORY":
                    metroComboBox2.Items.Clear();
                    metroComboBox2.Items.AddRange(comboBox2RangeC);
                    break;

            }
 
        }
        void reset()
        {
            metroComboBox1.SelectedItem = -1;
            metroComboBox2.SelectedItem = -1;
        }

        private void request_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(
                    "mameershahib@gmail.com", "ameer497191"); //enter your gmail id and password

                MailMessage msg = new MailMessage();
                if (metroComboBox4.SelectedItem == "Sports")
                msg.To.Add("randikamalli@gmail.com");
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Body = textBox4.Text;
                if (metroComboBox4.SelectedItem == "Laboratory")
                    msg.To.Add("mohammedameershib@gmail.com");
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Body = textBox4.Text;
                if (metroComboBox4.SelectedItem == "Computer Lab")
                    msg.To.Add("agmohammed1@gmail.com");
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Body = textBox4.Text;

                client.Send(msg);
            
                MessageBox.Show("Message sent to the suppliers");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
      

        }
 
    }
}
