using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Bookshop_Management
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            SUPload_table();
            sUpdateButton.Enabled = false;
            sDeleteButton.Enabled = false;
        }

        SqlConnection conn = new SqlConnection("Data Source=LENOVO;Initial Catalog=School;Integrated Security=True");

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier s1 = new Supplier();
            s1.Show();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder p1 = new PurchaseOrder();
            p1.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory i1 = new Inventory();
            i1.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return r1 = new Return();
            r1.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOrder so1 = new SalesOrder();
            so1.Show();
        }

        private void sAddButton_Click(object sender, EventArgs e)
        {
            if(sName.Text == "")
            {
                MessageBox.Show("Name field cannot be null");
            }

            else if(sCompany.Text =="")
            {
                MessageBox.Show("Company field cannot be null");
            }

            else if (sPhone.Text == "")
            {
                MessageBox.Show("Phone Number field cannot be null");
            }

            else if (sPhone.Text.Length != 10)
            {
                MessageBox.Show("Enter a Valid 10 Digit Phone Number !");
            }

            else if (sEmail.Text == "")
            {
                MessageBox.Show("Email field cannot be null");
            }

            else if (sAddress.Text == "")
            {
                MessageBox.Show("Address field cannot be null");
            }

            else
            {

                try
                {
                    conn.Open();

                    String supName = sName.Text;
                    String supCompany = sCompany.Text;
                    String supPhone = sPhone.Text;
                    String supEmail = sEmail.Text;
                    String supAddress = sAddress.Text;



                    SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO Supplier(Name, Company, PhoneNo, Email, Address) VALUES('" + supName + "', '" + supCompany + "', '" + supPhone + "', '" + supEmail + "', '" + supAddress + "')", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    clear();
                    SUPload_table();
                    MessageBox.Show("Saved Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        void clear()
        {
            sID.Text = "";
            sName.Clear();
            sCompany.Clear();
            sPhone.Clear();
            sEmail.Clear();
            sAddress.Clear();
        }


        void SUPload_table()
        {
            String conString = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Supplier", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                sDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.sDataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                sID.Text = row.Cells[0].Value.ToString();
                sName.Text = row.Cells[1].Value.ToString();
                sCompany.Text = row.Cells[2].Value.ToString();
                sPhone.Text = row.Cells[3].Value.ToString();
                sEmail.Text = row.Cells[4].Value.ToString();
                sAddress.Text = row.Cells[5].Value.ToString();
            }

            sAddButton.Enabled = false;
            sUpdateButton.Enabled = true;
            sDeleteButton.Enabled = true;
        }

        private void sUpdateButton_Click(object sender, EventArgs e)
        {
            if(sName.Text == "")
            {
                MessageBox.Show("Name field cannot be null");
            }

            else if(sCompany.Text =="")
            {
                MessageBox.Show("Company field cannot be null");
            }

            else if (sPhone.Text == "")
            {
                MessageBox.Show("Phone Number field cannot be null");
            }

            else if (sPhone.Text.Length != 10)
            {
                MessageBox.Show("Enter a Valid 10 Digit Phone Number !");
            }

            else if (sEmail.Text == "")
            {
                MessageBox.Show("Email field cannot be null");
            }

            else if (sAddress.Text == "")
            {
                MessageBox.Show("Address field cannot be null");
            }

            else
            {

                try
                {
                    conn.Open();

                    String supID = sID.Text;
                    String supName = sName.Text;
                    String supCompany = sCompany.Text;
                    String supPhone = sPhone.Text;
                    String supEmail = sEmail.Text;
                    String supAddress = sAddress.Text;


                    SqlDataAdapter SDA = new SqlDataAdapter("UPDATE Supplier SET Name = '" + supName + "', Company = '" + supCompany + "', PhoneNo = '" + supPhone + "', Email = '" + supEmail + "', Address = '" + supAddress + "' WHERE ID = '" + supID + "'", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    clear();
                    SUPload_table();
                    MessageBox.Show("Updated Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void sDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String supID = sID.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM Supplier WHERE ID = '" + supID + "'", conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                SUPload_table();
                clear();
                MessageBox.Show("Deleted Successfully !!!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String supSearch = sSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Supplier WHERE Name like '" + supSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                sDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String supSearch = sSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Supplier WHERE Name like '" + supSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                sDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sResetButton_Click(object sender, EventArgs e)
        {
            clear();
            sID.Text = "";
            sSearch.Clear();

            SUPload_table();
            sAddButton.Enabled = true;
            sUpdateButton.Enabled = false;
            sDeleteButton.Enabled = false;
        }

        private void sPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
