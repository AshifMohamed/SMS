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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            RegisterBook regbk = new RegisterBook();
            regbk.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            RegisterStudent regstud = new RegisterStudent();
            regstud.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Fine fin = new Fine();
            fin.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            ReturnDetails retBk = new ReturnDetails();
            retBk.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
