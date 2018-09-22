using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPnew
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void metroButton6_MouseEnter(object sender, EventArgs e)
        {
            metroButton6.BackColor = Color.CornflowerBlue;
        }

        private void metroButton6_MouseHover(object sender, EventArgs e)
        {
            metroButton6.BackColor = Color.CornflowerBlue;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            metroButton6.Select();
            button1.BackColor = Color.FromArgb(41, 52, 65);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button1.FlatAppearance.BorderSize = 1;
            button2.BackColor = Color.FromArgb(41, 52, 65);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button2.FlatAppearance.BorderSize = 1;
            //studentPanel.Visible = false;
            button3.BackColor = Color.FromArgb(41, 52, 65);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button3.FlatAppearance.BorderSize = 1;
            button4.BackColor = Color.FromArgb(41, 52, 65);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button4.FlatAppearance.BorderSize = 1;
            button5.BackColor = Color.FromArgb(41, 52, 65);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button5.FlatAppearance.BorderSize = 1;
        


        }

        private void Form5_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
          //  button1.BackColor = Color.FromArgb(41,52,65);
            button1.BackColor = Color.FromArgb(41, 52, 65);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button1.FlatAppearance.BorderSize = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroPanel11.Visible = true;
            metroPanel11.Size = new System.Drawing.Size(216, 150);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            button2.BackColor = Color.CornflowerBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(41, 52, 65);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button2.FlatAppearance.BorderSize = 1;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.CornflowerBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(41, 52, 65);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button3.FlatAppearance.BorderSize = 1;
        }

        private void metroButton1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.CornflowerBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(41, 52, 65);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button4.FlatAppearance.BorderSize = 1;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.CornflowerBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(41, 52, 65);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            button5.FlatAppearance.BorderSize = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //studentPanel.Visible = true;
            metroPanel6.Visible = true;
            metroPanel6.Size = new System.Drawing.Size(216, 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metroPanel5.Visible = true;
            metroPanel5.Size = new System.Drawing.Size(216, 150);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            metroPanel8.Visible = true;
            metroPanel8.Size = new System.Drawing.Size(216, 150);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  metroPanel7.Size = new System.Drawing.Size(216, 110);
            if (metroPanel7.Visible == true)
            {
                metroPanel7.Visible = false;

            }
            else {

                metroPanel7.Visible = true;
            }*/
            
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
             
        }
    }
}
