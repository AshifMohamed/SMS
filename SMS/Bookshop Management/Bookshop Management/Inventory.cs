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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Inventoryload_table();
            Stockload_table();
            iUpdateButton.Enabled = false;
            iDeleteButton.Enabled = false;
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

        private void iAddButton_Click(object sender, EventArgs e)
        {
            if(iName.Text == "")
            {
                MessageBox.Show("Item Name Cannot Be Null");
            }

            else if (iType.Text == "")
            {
                MessageBox.Show("Item Type Cannot Be Null");
            }

            else if (iPrice.Text == "")
            {
                MessageBox.Show("Item Price Cannot Be Null");
            }

            else
            {

                try
                {
                    conn.Open();

                    String inName = iName.Text;
                    String inType = iType.Text;
                    double inPrice = Convert.ToDouble(iPrice.Text);
                    String inDescreption = iDescreption.Text;
                    int inQuantity = 0;


                    SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO Inventory(Name, Type, Price, Descreption) VALUES('" + inName + "', '" + inType + "', " + inPrice + ", '" + inDescreption + "')", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO StockItems(Name, Quantity) VALUES('" + inName + "', " + inQuantity + ")", conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    Inventoryload_table();
                    Stockload_table();
                    clear();
                    MessageBox.Show("Saved Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void iUpdateButton_Click(object sender, EventArgs e)
        {
            if (iName.Text == "")
            {
                MessageBox.Show("Item Name Cannot Be Null");
            }

            else if (iType.Text == "")
            {
                MessageBox.Show("Item Type Cannot Be Null");
            }

            else if (iPrice.Text == "")
            {
                MessageBox.Show("Item Price Cannot Be Null");
            }

            else
            {

                try
                {
                    conn.Open();

                    String inItemCode = iItemCode.Text;
                    String inName = iName.Text;
                    String inType = iType.Text;
                    double inPrice = Convert.ToDouble(iPrice.Text);
                    String inDescreption = iDescreption.Text;


                    SqlDataAdapter SDA = new SqlDataAdapter("UPDATE Inventory SET Name = '" + inName + "', Type = '" + inType + "', Price = " + inPrice + ", Descreption = '" + inDescreption + "' WHERE ItemCode = '" + inItemCode + "'", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("UPDATE StockItems SET Name = '" + inName + "' WHERE ItemCode = '" + inItemCode + "'", conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    Inventoryload_table();
                    Stockload_table();
                    clear();
                    MessageBox.Show("Updated Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void iDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String inItemCode = iItemCode.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM Inventory WHERE ItemCode = '" + inItemCode + "'", conn);
                SDA.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM StockItems WHERE ItemCode = '" + inItemCode + "'", conn);
                sda.SelectCommand.ExecuteNonQuery();
                conn.Close();
                Inventoryload_table();
                Stockload_table();
                clear();
                MessageBox.Show("Deleted Successfully !!!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iResetButton_Click(object sender, EventArgs e)
        {
            clear();
            Inventoryload_table();
            iSearch.Clear();
            iUpdateButton.Enabled = false;
            iDeleteButton.Enabled = false;
            iAddButton.Enabled = true;
        }


        void clear()
        {
            iItemCode.Text = "";
            iName.Clear();
            iType.SelectedIndex = -1;
            iPrice.Clear();
            iDescreption.Clear();
        }


        void Inventoryload_table()
        {
            String conString = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Inventory", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                iDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    

        private void iDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.iDataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                iItemCode.Text = row.Cells[0].Value.ToString();
                iName.Text = row.Cells[1].Value.ToString();
                iType.Text = row.Cells[2].Value.ToString();
                iPrice.Text = row.Cells[3].Value.ToString();
                iDescreption.Text = row.Cells[4].Value.ToString();
            }

         iUpdateButton.Enabled = true;
         iDeleteButton.Enabled = true;
         iAddButton.Enabled = false;
        }

        private void iSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String inSearch = iSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Inventory WHERE Name like '" + inSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                iDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String inSearch = iSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Inventory WHERE Name like '" + inSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                iDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Stockload_table()
        {
            String conString = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("select ItemCode, Name, sum(Quantity) as [Quantity] from StockItems Group By ItemCode, Name, Quantity ", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                iDataGrid2.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void iName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }

}

