using MetroFramework.Forms;
using School;
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
using _23;
using demo1;
using ExamITP;
using ITPPro;
namespace ITPnew
{
    public partial class adhome : MetroForm
    {
        public adhome()
        {
            InitializeComponent();
        }

        private void adhome_Load(object sender, EventArgs e)
        {
            metroButton6.Select();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            demo1.Form1 newMDIChild = new demo1.Form1();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
            metroPanel5.Visible = false;
            metroPanel9.Visible = false;
            metroPanel7.Visible = false;
            metroPanel8.Visible = false;
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            RegisterEmployee newMDIChild = new RegisterEmployee();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            link newMDIChild = new link();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            EmployeeDetails newMDIChild = new EmployeeDetails();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            LeaveApproval newMDIChild = new LeaveApproval();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ViewAttendance newMDIChild = new ViewAttendance();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Attendance newMDIChild = new Attendance();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (metroPanel9.Visible == true)
            {
                metroPanel9.Visible = false;
           }
            else if (metroPanel9.Visible == false)
            {
                metroPanel9.Visible = true;
                metroPanel9.Size = new System.Drawing.Size(216, 184);   
            }
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (metroPanel7.Visible == true)
            {
                metroPanel7.Visible = false;
            }
            else if (metroPanel7.Visible == false)
            {
                metroPanel7.Visible = true;
                metroPanel7.Size = new System.Drawing.Size(216, 294);
            }
 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Admin newMDIChild = new Admin();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            RegForm  newMDIChild = new RegForm();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            studentSemesFees newMDIChild = new studentSemesFees();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            studentDonation newMDIChild = new studentDonation();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            RefineForm newMDIChild = new RefineForm();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            viewpayhistory newMDIChild = new viewpayhistory();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            OverDuePayments newMDIChild = new OverDuePayments();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Discipline newMDIChild = new Discipline();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            achievements newMDIChild = new achievements();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (metroPanel5.Visible == true)
            {
                metroPanel5.Visible = false;
            }
            else if (metroPanel5.Visible == false)
            {
                metroPanel5.Visible = true;
                metroPanel5.Size = new System.Drawing.Size(216, 111);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
           demo1.Form1  newMDIChild = new demo1.Form1();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }

        private void metroButton31_Click(object sender, EventArgs e)
        {
            if (metroPanel8.Visible == true)
            {
                metroPanel8.Visible = false;
            }
            else if (metroPanel8.Visible == false)
            {
                metroPanel8.Visible = true;
                metroPanel8.Size = new System.Drawing.Size(216, 111);
            }
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            examFees newMDIChild = new examFees();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
     
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            placeExamTable newMDIChild = new placeExamTable();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            home newMDIChild = new home();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            link2 newMDIChild = new link2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        
        }
    }
}
