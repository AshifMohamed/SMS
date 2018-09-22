
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4;
//using _23;
using MetroFramework.Drawing;
namespace ITPnew
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studentPanel.Visible = false;
           // metroButton1.
        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            studentPanel.Visible = true;
        }

        private void metroButton6_MouseDown(object sender, MouseEventArgs e)
        {
            //metroButton6.BackColor = Color.Red;
        }

        private void metroButton6_MouseHover(object sender, EventArgs e)
        {
          //  metroButton6.BackColor = Color.Red;
        }

        private void metroButton6_MouseEnter(object sender, EventArgs e)
        {
            //metroButton6.BackColor = Color.Red;
        
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton6_MouseClick(object sender, MouseEventArgs e)
        {
          //  metroButton6.BackColor = Color.Red;
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
            newMDIChild.Dock =  DockStyle.Fill;
        }

        private void metroButton8_Click(object sender, EventArgs e)
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

        private void metroButton7_Click(object sender, EventArgs e)
        {
          /*  if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
          AddMarksG1 newMDIChild = new AddMarksG1();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill; */
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
          /*  if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            _23.Form1 newMDIChild = new _23.Form1();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill; */

           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
          /*  Home newMDIChild = new Home();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill; */
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        /*  home newMDIChild = new home();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            newMDIChild.Dock = DockStyle.Fill;*/
        }

        public void getLoginDetails(String Username, String Role)
        {
            //metroLabel2.Text = Username;

        }
    }
}
