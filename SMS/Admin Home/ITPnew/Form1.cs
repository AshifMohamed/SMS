using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITPnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Visible = false;
            metroPanel1.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage2;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
        }

     
    }
}
