using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class 
        link : MetroForm
    {
        public link()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            sports s = new sports();
            s.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            comlab c = new comlab();
            c.Show();
}

        private void metroTile2_Click(object sender, EventArgs e)
        {
            lab l = new lab();
            l.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            furniture f = new furniture();
            f.Show();
        }

        private void link_Load(object sender, EventArgs e)
        {

        }
    }
}
