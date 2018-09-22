using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using WindowsFormsApplication4;

namespace ITPLibrary
{
    public partial class Email : MetroFramework.Forms.MetroForm
    {
        public Email()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
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

                msg.To.Add(metroTextBox1.Text);
                msg.From = new MailAddress("mameershahib@gmail.com");
                msg.Subject = (metroTextBox2.Text="Membership Expired");
                msg.Body = (metroTextBox3.Text="renew your membership");


                client.Send(msg);
                MessageBox.Show("Message sent to the parent");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}
