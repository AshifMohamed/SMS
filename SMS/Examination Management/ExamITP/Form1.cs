using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamITP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            examProcess a = new examProcess();
            this.Hide();
            a.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            examFees a = new examFees();
            this.Hide();
            a.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            yearEnd a = new yearEnd();
            this.Hide();
            a.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            placeExamTable a = new placeExamTable();
            this.Hide();
            a.Show();
        }
    }
}
