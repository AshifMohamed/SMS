using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class commonform : Form
    {
        public commonform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            applicantForm dora = new applicantForm();
            dora.Show();
        }

        private void commonform_Load(object sender, EventArgs e)
        {

        }
    }
}
