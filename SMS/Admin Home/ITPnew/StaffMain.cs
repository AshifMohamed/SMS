using ExamITP;
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


namespace ITPnew
{
    public partial class StaffMain : Form
    {
        public StaffMain()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            // leaveApplication newMDIChild = new leaveApplication();
            yearEnd newMDIChild = new yearEnd();

            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
               ActiveMdiChild.Close();
            leaveApplication newMDIChild = new leaveApplication();
         
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.FillDetails(metroLabel1.Text);
            newMDIChild.Show();

            newMDIChild.Dock = DockStyle.Fill;
        }
        public void getLoginDetails(String Username, String Role)
        {
            metroLabel1.Text = Username;

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            // leaveApplication newMDIChild = new leaveApplication();
            RegisterEmployee newMDIChild = new RegisterEmployee();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            // leaveApplication newMDIChild = new leaveApplication();
           LeaveApproval newMDIChild = new LeaveApproval();
          
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            // leaveApplication newMDIChild = new leaveApplication();
            ExamITP.examProcess newMDIChild = new ExamITP.examProcess();

            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }
    }
}
