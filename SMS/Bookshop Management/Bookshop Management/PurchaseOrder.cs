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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
            POload_table();
            FillCombo();
            FillSupCombo();
            poUpdateButton.Enabled = false;
            poDeleteButton.Enabled = false;
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

        private void poAddButton_Click(object sender, EventArgs e)
        {
            if(poName.Text == "")
            {
                MessageBox.Show("Name Cannot Be Null");
            }

            else if(poQuantity.Text =="")
            {
                MessageBox.Show("Quantity Cannot Be Null");
            }

            else if(poPrice.Text =="")
            {
                MessageBox.Show("Price Cannot Be Null");
            }

            else if (poSupID.Text == "")
            {
                MessageBox.Show("Supplier ID Cannot Be Null");
            }

            else if (poDate.Text == "")
            {
                MessageBox.Show("Date Cannot Be Null");
            }



            else if (poDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Date! You might entering a Future Date");
            }

            else
            {

                try
                {
                    conn.Open();

                    String puOrderNo = poOrderNo.Text;
                    int puItemCode = Convert.ToInt32(poItemCode.Text);
                    String puName = poName.Text;
                    String puDescreption = poDescreption.Text;
                    int puQuantity = Convert.ToInt32(poQuantity.Text);
                    double puPrice = Convert.ToDouble(poPrice.Text);
                    String puSupID = poSupID.Text;
                    DateTime purDate = Convert.ToDateTime(poDate.Text);

                    string puDate = purDate.ToString("yyyy/MM/dd");



                    SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO PurchaseOrder(ItemCode, Name, Descreption, Quantity, Price, SupID, Date) VALUES('" + puItemCode + "', '" + puName + "', '" + puDescreption + "', " + puQuantity + ", " + puPrice + ", '" + puSupID + "', '" + puDate + "')", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("Update StockItems SET Quantity = Quantity + " + puQuantity + " where ItemCode = '" + puItemCode + "'", conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    clear();
                    POload_table();
                    MessageBox.Show("Saved Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }


        void POload_table()
        {
            String conString = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("Select * from PurchaseOrder", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                poDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void clear()
        {
            poOrderNo.Text = "";
            poItemCode.Text = "";
            poName.SelectedIndex = -1;
            poDescreption.Clear();
            poQuantity.Clear();
            poPrice.Clear();
            poSupID.SelectedIndex = -1;
            poDate.ResetText();
        }

        private void poDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.poDataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                poOrderNo.Text = row.Cells[0].Value.ToString();
                poItemCode.Text = row.Cells[1].Value.ToString();
                poName.Text = row.Cells[2].Value.ToString();
                poDescreption.Text = row.Cells[3].Value.ToString();
                poQuantity.Text = row.Cells[4].Value.ToString();
                poPrice.Text = row.Cells[5].Value.ToString();
                poSupID.Text = row.Cells[6].Value.ToString();
                poDate.Text = row.Cells[7].Value.ToString();
            }

            poAddButton.Enabled = false;
            poUpdateButton.Enabled = true;
            poDeleteButton.Enabled = true;
        }

        private void poUpdateButton_Click(object sender, EventArgs e)
        {
            if(poName.Text == "")
            {
                MessageBox.Show("Name Cannot Be Null");
            }

            else if(poQuantity.Text =="")
            {
                MessageBox.Show("Quantity Cannot Be Null");
            }

            else if(poPrice.Text =="")
            {
                MessageBox.Show("Price Cannot Be Null");
            }

            else if (poSupID.Text == "")
            {
                MessageBox.Show("Supplier ID Cannot Be Null");
            }

            else if (poDate.Text == "")
            {
                MessageBox.Show("Date Cannot Be Null");
            }



            else if (poDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Date! You might entering a Future Date");
            }

            else
            {

                try
                {
                    conn.Open();

                    String puOrderNo = poOrderNo.Text;
                    String puItemCode = poItemCode.Text;
                    String puName = poName.Text;
                    String puDescreption = poDescreption.Text;
                    int puQuantity = Convert.ToInt32(poQuantity.Text);
                    double puPrice = Convert.ToDouble(poPrice.Text);
                    String puSupID = poSupID.Text;
                    DateTime purDate = Convert.ToDateTime(poDate.Text);

                    string puDate = purDate.ToString("yyyy/MM/dd");



                    SqlDataAdapter SDA = new SqlDataAdapter("UPDATE PurchaseOrder SET ItemCode = '" + puItemCode + "', Name = '" + puName + "', Descreption = '" + puDescreption + "', Quantity = '" + puQuantity + "', Price = '" + puPrice + "', SupID = '" + puSupID + "', Date = '" + puDate + "' WHERE OrderNo = '" + puOrderNo + "'", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    clear();
                    POload_table();
                    MessageBox.Show("Updated Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

            }
        }

        private void poDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String puOrderNo = poOrderNo.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM PurchaseOrder WHERE OrderNo = '" + puOrderNo + "'", conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                POload_table();
                clear();
                MessageBox.Show("Deleted Successfully !!!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String puSearch = poSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PurchaseOrder WHERE Name like '" + poSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                poDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String puSearch = poSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PurchaseOrder WHERE Name like '" + poSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                poDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poResetButton_Click(object sender, EventArgs e)
        {
            clear();
            poOrderNo.Text = "";
            poSearch.Clear();
            POload_table();
            poAddButton.Enabled = true;
            poUpdateButton.Enabled = false;
            poDeleteButton.Enabled = false;
        }

        private void poName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String constring = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            String Query = "select * from Inventory where Name = '"+ poName.Text +"'";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    poItemCode.Text = myReader[0].ToString();    

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           /* try
            {


                readProductByName(this.poName.Text);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        void FillCombo()
        {
            String constring = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            String Query = "select * from Inventory";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    String invName = myReader[1].ToString();
                    poName.Items.Add(invName);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillSupCombo()
        {
            String constring = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            String Query = "select * from Supplier";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    String supID = myReader[0].ToString();
                    poSupID.Items.Add(supID);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void poDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void poQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void poPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void readProductByName(String Name)
        {
            SqlCommand cmd = new SqlCommand("Select * from Inventory where Name =" + Name, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                this.poItemCode.Text = dr["ItemCode"].ToString();
            }
        }

    }
}
