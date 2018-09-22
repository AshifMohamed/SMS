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

namespace ExamITP
{
    public partial class mailEF : MetroFramework.Forms.MetroForm
    {
        public mailEF()
        {
            InitializeComponent();
            metroTextBox2.Text = "Examination Fees Due";
            string mystring = "Hi, \n\n This e-mail is to confirm that your Wisdom international school Examination fee is due. \n If you have already paid, please contact abc@gmail.com. \n\n Thank you, \n Office of Wisdom International";
            metroTextBox1.Text = mystring.Replace("\n", Environment.NewLine);
        }

        private void mailEF_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
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
            msg.To.Add(metroLabel5.Text);
            msg.From = new MailAddress("mameershahib@gmail.com");
            msg.Subject = metroTextBox2.Text;

            msg.Body = metroTextBox1.Text; 

            //Attachment att = new Attachment(textBox3.Text);
            //msg.Attachments.Add(att);
            client.Send(msg);
            MessageBox.Show("E-mail sent to the student. ");
            this.Hide();
        }
    }
}
