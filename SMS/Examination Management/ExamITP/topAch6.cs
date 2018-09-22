﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication4;

namespace ExamITP
{
    public partial class topAch6 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = DBAccess.GetConnection();

        public topAch6()
        {
            InitializeComponent();
        }

        public void PassValue(string strValue1)
        {
            metroLabel6.Text = strValue1;
           

        }

        private void topAch6_Load(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand();
            command1.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command1.CommandText = "select AdmissionNo,fname,surname,[English],DENSE_RANK() OVER (ORDER BY English DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            adapter1.Fill(data1);
            metroGrid1.DataSource = data1;


            SqlCommand command2 = new SqlCommand();
            command2.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command2.CommandText = "select AdmissionNo,fname,surname,[Mathematics],DENSE_RANK() OVER (ORDER BY Mathematics DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            adapter2.Fill(data2);
            metroGrid2.DataSource = data2;


            SqlCommand command3 = new SqlCommand();
            command3.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command3.CommandText = "select AdmissionNo,fname,surname,[ICT],DENSE_RANK() OVER (ORDER BY ICT DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            adapter3.Fill(data3);
            metroGrid3.DataSource = data3;


            SqlCommand command4 = new SqlCommand();
            command4.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command4.CommandText = "select AdmissionNo,fname,surname,[Science],DENSE_RANK() OVER (ORDER BY Science DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            adapter4.Fill(data4);
            metroGrid4.DataSource = data4;


            SqlCommand command5 = new SqlCommand();
            command5.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command5.CommandText = "select AdmissionNo,fname,surname,[History],DENSE_RANK() OVER (ORDER BY History DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data5 = new DataTable();
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
            adapter5.Fill(data5);
            metroGrid5.DataSource = data5;


            SqlCommand command6 = new SqlCommand();
            command6.Connection = con;
            if (metroLabel6.Text == "6")
            {
                command6.CommandText = "select AdmissionNo,fname,surname,[Language],DENSE_RANK() OVER (ORDER BY Language DESC) AS [Standing] from yearEnd where admissionGrade  = '6'";
            }
            else
            {

            }
            DataTable data6 = new DataTable();
            SqlDataAdapter adapter6 = new SqlDataAdapter(command6);
            adapter6.Fill(data6);
            metroGrid6.DataSource = data6;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            yearEnd a = new yearEnd();
            this.Hide();
            a.Show();
        }
    }
}
