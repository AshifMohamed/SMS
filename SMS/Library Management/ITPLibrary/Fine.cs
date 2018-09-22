using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4;

namespace ITPLibrary
{
    public partial class Fine : MetroFramework.Forms.MetroForm
    {
        public Fine()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DateTime RetDate = ReturnDate.Value.Date;
            DateTime CurDate = CurrentDate.Value.Date;

            TimeSpan dif = CurDate - RetDate;

            int days = dif.Days;
            if (days < 0)
            {
                MessageBox.Show("No fine to be calculated");
                delay.Text = days.ToString();
            }
            else if ((days == 1) && (days > 1) && (days < 5))
            {
                amt.Text = "Rs.120";
                delay.Text = days.ToString();
            }
            else if ((days == 5) && (days > 5) && (days < 10))
            {
                amt.Text = "Rs.200";
                delay.Text = days.ToString();
            }
            else if ((days == 10) && (days > 10) && (days < 20))
            {
                amt.Text = "Rs.360";
                delay.Text = days.ToString();
            }
            else if ((days == 20) && (days > 20) && (days < 31) && (days == 31))
            {
                amt.Text = "Rs.500";
                delay.Text = days.ToString();
            }
            else
            {
                delay.Text = days.ToString();

            }
        }

        private void Fine_Load(object sender, EventArgs e)
        {

        }
    }
}
