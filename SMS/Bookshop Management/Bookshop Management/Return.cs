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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            rload_table();
            FillCombo();
            rUpdateButton.Enabled = false;
            rDeleteButton.Enabled = false;
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

       

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder po = new PurchaseOrder();
            po.Show();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier s1 = new Supplier();
            s1.Show();
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

        private void rAddButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "select Quantity from StockItems Where ItemCode = '" + rItemCode.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int qty = Convert.ToInt16(sdr["Quantity"].ToString());

            conn.Close();

            if(rName.Text == "")
            {
                MessageBox.Show("Name field cannot be null ! ");
            }

            else if(rDate.Text == "")
            {
                MessageBox.Show("Date field cannot be null !");
            }

            else if(rQuantity.Text == "")
            {
                MessageBox.Show("Quantity  field cannot be null !");
            }

            else if(Convert.ToInt16(rQuantity.Text) > qty)
            {
                MessageBox.Show("Cannot Return More then existing Stock Quantity");
            }

            else if (rDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Date! You might entering a Future Date");
            }

            else
            {

                try
                {

                    conn.Open();

                    String reItemCode = rItemCode.Text;
                    String reName = rName.Text;
                    int reQuantity = Convert.ToInt32(rQuantity.Text);
                    DateTime retDate = Convert.ToDateTime(rDate.Text);

                    string reDate = retDate.ToString("yyyy/MM/dd");
                    String reDescreption = rDescreption.Text;



                    SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO ReturnItems(ItemCode, Name, Quantity, Date, Descreption) VALUES('" + reItemCode + "', '" + reName + "', " + reQuantity + ", '" + reDate + "', '" + reDescreption + "')", conn);
                    SDA.SelectCommand.ExecuteNonQuery();

                    SqlDataAdapter QTY = new SqlDataAdapter("Update StockItems SET Quantity = Quantity - " + reQuantity + " where ItemCode = '" + reItemCode + "'", conn);
                    QTY.SelectCommand.ExecuteNonQuery();



                    conn.Close();
                    clear();
                    rload_table();
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
            rItemCode.Text = "";
            rName.ResetText();
            rQuantity.Clear();
            rDate.ResetText();
            rDescreption.Clear();
            rName.SelectedIndex = -1;
        }


        void rload_table()
        {
            String conString = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("Select * from ReturnItems", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                rDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rUpdateButton_Click(object sender, EventArgs e)
        {
            if(rName.Text == "")
            {
                MessageBox.Show("Name field cannot be null ! ");
            }

            else if(rDate.Text == "")
            {
                MessageBox.Show("Date field cannot be null !");
            }

            else if(rQuantity.Text == "")
            {
                MessageBox.Show("Quantity  field cannot be null !");
            }

            else if (rDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Date! You might entering a Future Date");
            }

            else
            {

                try
                {
                    conn.Open();

                    String reID = rID.Text;
                    String reItemCode = rItemCode.Text;
                    String reName = rName.Text;
                    int reQuantity = Convert.ToInt32(rQuantity.Text);
                    DateTime retDate = Convert.ToDateTime(rDate.Text);

                    string reDate = retDate.ToString("yyyy/MM/dd");
                    String reDescreption = rDescreption.Text;



                    SqlDataAdapter SDA = new SqlDataAdapter("UPDATE ReturnItems SET ItemCode = '" + reItemCode + "', Name = '" + reName + "', Quantity = " + reQuantity + ", Date = '" + reDate + "', Descreption = '" + reDescreption + "' WHERE ReturnID = '" + reID + "'", conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    clear();
                    rload_table();
                    MessageBox.Show("Updated Successfully !!!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void rDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String reID = rID.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM ReturnItems WHERE ReturnID = '" + reID + "'", conn);
                SDA.SelectCommand.ExecuteNonQuery();
                conn.Close();
                rload_table();
                clear();
                MessageBox.Show("Deleted Successfully !!!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String reSearch = rSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM ReturnItems WHERE Name like '" + reSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                rDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                String reSearch = rSearch.Text;


                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM ReturnItems WHERE Name like '" + reSearch + "%'", conn);
                DataTable dt;
                dt = new DataTable();
                SDA.Fill(dt);
                rDataGrid.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rResetButton_Click(object sender, EventArgs e)
        {
            clear();
            rID.Text = "";
            rSearch.Clear();
            rload_table();
            rAddButton.Enabled = true;
            rUpdateButton.Enabled = false;
            rDeleteButton.Enabled = false;
        }

        private void rDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.rDataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                rID.Text = row.Cells[0].Value.ToString();
                rItemCode.Text = row.Cells[1].Value.ToString();
                rName.Text = row.Cells[2].Value.ToString();
                rQuantity.Text = row.Cells[3].Value.ToString();
                rDate.Text = row.Cells[4].Value.ToString();
                rDescreption.Text = row.Cells[5].Value.ToString();
            }

            rAddButton.Enabled = false;
            rUpdateButton.Enabled = true;
            rDeleteButton.Enabled = true;
        }

        private void rItemCode_Enter(object sender, EventArgs e)
        {
            
        }

        private void rName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String constring = "Data Source=LENOVO;Initial Catalog=School;Integrated Security=True";
            String Query = "select * from Inventory where Name = '"+rName.Text+"'";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while(myReader.Read())
                {
                    rItemCode.Text = myReader[0].ToString();
                    
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    String sName = myReader[1].ToString();
                    rName.Items.Add(sName);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rQuantity_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
