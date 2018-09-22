//using ITPnew;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bookshop_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
