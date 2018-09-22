using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ITPPro
{
    public partial class email : MetroFramework.Forms.MetroForm
    {
        public email()
        {
            InitializeComponent();
        }

        private void emial_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
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
            msg.To.Add(metroLabel2.Text);
            msg.From = new MailAddress("mameershahib@gmail.com");
            msg.Subject = metroTextBox2.Text;

            msg.Body = metroTextBox1.Text;

            //Attachment att = new Attachment(textBox3.Text);
            //msg.Attachments.Add(att);
            client.Send(msg);
            MessageBox.Show("E-mail sent to the sponsor. ");
            this.Hide();
        }
    }
}
