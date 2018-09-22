using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPLibrary
{
    public partial class LibraryHome : Form
    {
        public LibraryHome()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RegisterBook regbk = new RegisterBook();
            regbk.Show();
            //this.Hide();
           
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            RegisterStudent regstd = new RegisterStudent();
            regstd.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Issue iss = new Issue();
            iss.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           // this.Hide();
            ReturnDetails rd = new ReturnDetails();
            rd.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
