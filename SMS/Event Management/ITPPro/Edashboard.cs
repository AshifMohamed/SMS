using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;


namespace ITPPro
{
    public partial class Edashboard : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();
       
        string eid;
        public Edashboard()
        {
            InitializeComponent();
        }




        private void Edashboard_Load(object sender, EventArgs e)
        {

        }
        
        private void edit_Click(object sender, EventArgs e)
        {
            Runsheet r = new Runsheet();
            r.Show();
            r.sendid(eid);
        }

        private void financial_Click(object sender, EventArgs e)
        {
            finace s = new finace();

            s.Show();
            s.sendid(eid);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            summary l = new summary();
            l.Show();
            l.sendid(eid);
        }
        public void getid(String id)
        {
            eid = id;
       
        }



        private void metroTile6_Click(object sender, EventArgs e)
        {
            
            

            fexecu f = new fexecu();
           
            f.Show();
            f.sendid(eid);
            
            
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            sponser m = new sponser();
            m.Show();
            m.sendid(eid);
        }

        private void report_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       
    }
}
