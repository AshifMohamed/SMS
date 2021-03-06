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
using Excel = Microsoft.Office.Interop.Excel;
using WindowsFormsApplication4;


namespace _23
{
    public partial class viewallachievements : Form
    {

        SqlConnection conn = DBAccess.GetConnection();
        public viewallachievements()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select achieve_id,stud_regnum,name,grade,semester,academicyear,achievefield,achievedescription from achievements where stud_regnum like '"+ metroTextBox1.Text +"%" , conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = item[0].ToString();
                metroGrid1.Rows[n].Cells[1].Value = item[1].ToString();        
                metroGrid1.Rows[n].Cells[2].Value = item[2].ToString();
                metroGrid1.Rows[n].Cells[3].Value = item[3].ToString();
                metroGrid1.Rows[n].Cells[4].Value = item[4].ToString();
                metroGrid1.Rows[n].Cells[5].Value = item[5].ToString();
                metroGrid1.Rows[n].Cells[6].Value = item[6].ToString();
                metroGrid1.Rows[n].Cells[7].Value = item[7].ToString();
            }
        }

        private void viewallachievements_Load(object sender, EventArgs e)
        {

            displaylist();
        }

        void displaylist()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select achieve_id,stud_regnum,name,grade,semester,academicyear,achievefield,achievedescription from achievements GROUP BY stud_regnum", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = item[0].ToString();
                metroGrid1.Rows[n].Cells[1].Value = item[1].ToString();
                metroGrid1.Rows[n].Cells[2].Value = item[2].ToString();
                metroGrid1.Rows[n].Cells[3].Value = item[3].ToString();
                metroGrid1.Rows[n].Cells[4].Value = item[4].ToString();
                metroGrid1.Rows[n].Cells[5].Value = item[5].ToString();
                metroGrid1.Rows[n].Cells[6].Value = item[6].ToString();
                metroGrid1.Rows[n].Cells[7].Value = item[7].ToString();
            }
        }

        private void copyAlltoClipboard()
        {
            metroGrid1.SelectAll();
            DataObject dataObj = metroGrid1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true); 
        }



    }
}
