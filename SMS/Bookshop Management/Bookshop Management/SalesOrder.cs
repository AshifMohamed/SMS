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
using Bookshop_Management.Properties;
using Bookshop_Management.Models;


namespace Bookshop_Management
{
    public partial class SalesOrder : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LENOVO;Initial Catalog=School;Integrated Security=True");

        public SalesOrder()
        {
            InitializeComponent();
            bindProductCode();
            cboCode.SelectedIndex = -1;
        }

        CartItem Item = new CartItem();

        private List<CartItem> ShoppingCart = new List<CartItem>();

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindProductCode()
        {
            SqlCommand cmd = new SqlCommand("select ItemCode from Inventory", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCode.DisplayMember = "ItemCode";
            cboCode.ValueMember = "ItemCode";
            cboCode.DataSource = dt;
            

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

        private void cboCode_TextChanged(object sender, EventArgs e)
        {
            this.txtQuantity.Text = "";
            this.txtPrice.Text = "";
            this.txtName.Text = "";

            if(cboCode.Text !="")
            {
                readProductByCode(this.cboCode.SelectedValue.ToString());
                this.txtQuantity.Text = "";
            }

        }

        private void readProductByCode(String id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Inventory where ItemCode =" + id, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                this.txtName.Text = dr["Name"].ToString();
                this.txtPrice.Text = dr["Price"].ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "select Quantity from StockItems Where ItemCode = '"+cboCode.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int qty = Convert.ToInt32(sdr["Quantity"].ToString());

            conn.Close();
            

            CartItem item = new CartItem()
            {
                ItemName = txtName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text.Trim()),
                UnitPrice = Convert.ToInt32(txtPrice.Text.Trim()),
                TotalPrice = Convert.ToInt32(txtQuantity.Text.Trim()) * Convert.ToInt32(txtPrice.Text.Trim())
            };

            if (Convert.ToInt16(txtQuantity.Text) > qty)
            {
                MessageBox.Show("Not enough Stock");
            }

            else
            {

                ShoppingCart.Add(item);

                soDataGrid.DataSource = null;
                soDataGrid.DataSource = ShoppingCart;

                conn.Open();
                int qtydec = Convert.ToInt32(txtQuantity.Text);

                SqlDataAdapter QTY = new SqlDataAdapter("Update StockItems SET Quantity = Quantity - " + qtydec + " where ItemCode = '" + cboCode.Text + "'", conn);
                QTY.SelectCommand.ExecuteNonQuery();

                conn.Close();

                cboCode.SelectedIndex = -1;
                txtQuantity.Clear();
                txtName.Clear();

                int totalAmount = ShoppingCart.Sum(x => x.TotalPrice);
                txtTotal.Text = totalAmount.ToString();
            }

        }

        private void soDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==0)
            {
                soDataGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int moneyreturn = int.Parse(this.txtMoneyRecieve.Text) - int.Parse(this.txtTotal.Text);
                this.txtMoneyReturn.Text = moneyreturn.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Clear()
        {
            cboCode.Text = "";
            txtName.Clear();
            txtTotal.Clear();
        }

        private void txtMoneyRecieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && this.txtMoneyRecieve.Text != "" && this.txtTotal.Text == "")
            {
                int moneyreturn = int.Parse(this.txtMoneyRecieve.Text) - int.Parse(this.txtTotal.Text);
                this.txtMoneyReturn.Text = moneyreturn.ToString();
            }
        }

        private void txtMoneyReturn_Click(object sender, EventArgs e)
        {

        }

        private void txtMoneyRecieve_Click(object sender, EventArgs e)
        {

        }

        private void txtMoneyRecieve_Leave(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.AGBS3;
            e.Graphics.DrawImage(image, 220, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- " , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(390, 290));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, 290));
            e.Graphics.DrawString("Total Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(710, 290));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 303));

            int ypos = 330;

            foreach (var i in ShoppingCart )
            {
                e.Graphics.DrawString(i.ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, ypos));
                e.Graphics.DrawString(i.UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(390, ypos));
                e.Graphics.DrawString(i.Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(560, ypos));
                e.Graphics.DrawString(i.TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(710, ypos));

                ypos = ypos + 30;
            }


            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

            e.Graphics.DrawString("Total Amount :            LKR" + txtTotal.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(571, ypos+30));
            e.Graphics.DrawString("Recieved Payment : LKR" + txtMoneyRecieve.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(571, ypos + 60));
            e.Graphics.DrawString("Balance Amount :     LKR" + txtMoneyReturn.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(571, ypos + 90));

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }




        
    }
}
