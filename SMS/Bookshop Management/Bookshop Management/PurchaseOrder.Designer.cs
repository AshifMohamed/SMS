namespace Bookshop_Management
{
    partial class PurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.poSupID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.poItemCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.poName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.poOrderNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.poDescreption = new MetroFramework.Controls.MetroTextBox();
            this.poDate = new MetroFramework.Controls.MetroDateTime();
            this.poQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.poPrice = new MetroFramework.Controls.MetroTextBox();
            this.poResetButton = new MetroFramework.Controls.MetroButton();
            this.poDataGrid = new MetroFramework.Controls.MetroGrid();
            this.poSearchButton = new MetroFramework.Controls.MetroButton();
            this.poSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.poDeleteButton = new MetroFramework.Controls.MetroButton();
            this.poAddButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.SalesButton = new MetroFramework.Controls.MetroButton();
            this.ReturnButton = new MetroFramework.Controls.MetroButton();
            this.InventoryButton = new MetroFramework.Controls.MetroButton();
            this.PurchaseButton = new MetroFramework.Controls.MetroButton();
            this.SupplierButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.poUpdateButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poDataGrid)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.poResetButton);
            this.metroPanel1.Controls.Add(this.poDataGrid);
            this.metroPanel1.Controls.Add(this.poSearchButton);
            this.metroPanel1.Controls.Add(this.poSearch);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.poDeleteButton);
            this.metroPanel1.Controls.Add(this.poAddButton);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.poUpdateButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1008, 561);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.poSupID);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.poItemCode);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.poName);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.poOrderNo);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.poDescreption);
            this.groupBox1.Controls.Add(this.poDate);
            this.groupBox1.Controls.Add(this.poQuantity);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.poPrice);
            this.groupBox1.Location = new System.Drawing.Point(236, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 225);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Order No";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Item Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Descreption";
            // 
            // poSupID
            // 
            this.poSupID.FormattingEnabled = true;
            this.poSupID.ItemHeight = 23;
            this.poSupID.Location = new System.Drawing.Point(488, 126);
            this.poSupID.Name = "poSupID";
            this.poSupID.Size = new System.Drawing.Size(128, 29);
            this.poSupID.TabIndex = 30;
            this.poSupID.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(379, 44);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Quantity";
            // 
            // poItemCode
            // 
            this.poItemCode.AutoSize = true;
            this.poItemCode.Location = new System.Drawing.Point(111, 90);
            this.poItemCode.Name = "poItemCode";
            this.poItemCode.Size = new System.Drawing.Size(101, 19);
            this.poItemCode.TabIndex = 29;
            this.poItemCode.Text = "                       ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(379, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Price";
            // 
            // poName
            // 
            this.poName.FormattingEnabled = true;
            this.poName.ItemHeight = 23;
            this.poName.Location = new System.Drawing.Point(111, 130);
            this.poName.Name = "poName";
            this.poName.Size = new System.Drawing.Size(206, 29);
            this.poName.TabIndex = 28;
            this.poName.UseSelectable = true;
            this.poName.SelectedIndexChanged += new System.EventHandler(this.poName_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(379, 185);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Date";
            // 
            // poOrderNo
            // 
            this.poOrderNo.AutoSize = true;
            this.poOrderNo.Location = new System.Drawing.Point(111, 44);
            this.poOrderNo.Name = "poOrderNo";
            this.poOrderNo.Size = new System.Drawing.Size(89, 19);
            this.poOrderNo.TabIndex = 9;
            this.poOrderNo.Text = "                    ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 90);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(71, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Item Code";
            // 
            // poDescreption
            // 
            // 
            // 
            // 
            this.poDescreption.CustomButton.Image = null;
            this.poDescreption.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.poDescreption.CustomButton.Name = "";
            this.poDescreption.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poDescreption.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.poDescreption.CustomButton.TabIndex = 1;
            this.poDescreption.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.poDescreption.CustomButton.UseSelectable = true;
            this.poDescreption.CustomButton.Visible = false;
            this.poDescreption.Lines = new string[0];
            this.poDescreption.Location = new System.Drawing.Point(111, 181);
            this.poDescreption.MaxLength = 32767;
            this.poDescreption.Name = "poDescreption";
            this.poDescreption.PasswordChar = '\0';
            this.poDescreption.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poDescreption.SelectedText = "";
            this.poDescreption.SelectionLength = 0;
            this.poDescreption.SelectionStart = 0;
            this.poDescreption.ShortcutsEnabled = true;
            this.poDescreption.Size = new System.Drawing.Size(206, 23);
            this.poDescreption.TabIndex = 11;
            this.poDescreption.UseSelectable = true;
            this.poDescreption.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poDescreption.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poDate
            // 
            this.poDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.poDate.Location = new System.Drawing.Point(488, 175);
            this.poDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.poDate.Name = "poDate";
            this.poDate.Size = new System.Drawing.Size(128, 29);
            this.poDate.TabIndex = 24;
            this.poDate.Value = new System.DateTime(2016, 9, 14, 22, 33, 0, 0);
            this.poDate.ValueChanged += new System.EventHandler(this.poDate_ValueChanged);
            // 
            // poQuantity
            // 
            // 
            // 
            // 
            this.poQuantity.CustomButton.Image = null;
            this.poQuantity.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.poQuantity.CustomButton.Name = "";
            this.poQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.poQuantity.CustomButton.TabIndex = 1;
            this.poQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.poQuantity.CustomButton.UseSelectable = true;
            this.poQuantity.CustomButton.Visible = false;
            this.poQuantity.Lines = new string[0];
            this.poQuantity.Location = new System.Drawing.Point(488, 40);
            this.poQuantity.MaxLength = 32767;
            this.poQuantity.Name = "poQuantity";
            this.poQuantity.PasswordChar = '\0';
            this.poQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poQuantity.SelectedText = "";
            this.poQuantity.SelectionLength = 0;
            this.poQuantity.SelectionStart = 0;
            this.poQuantity.ShortcutsEnabled = true;
            this.poQuantity.Size = new System.Drawing.Size(128, 23);
            this.poQuantity.TabIndex = 12;
            this.poQuantity.UseSelectable = true;
            this.poQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.poQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.poQuantity_KeyPress);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(379, 140);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Supplier ID";
            // 
            // poPrice
            // 
            // 
            // 
            // 
            this.poPrice.CustomButton.Image = null;
            this.poPrice.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.poPrice.CustomButton.Name = "";
            this.poPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.poPrice.CustomButton.TabIndex = 1;
            this.poPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.poPrice.CustomButton.UseSelectable = true;
            this.poPrice.CustomButton.Visible = false;
            this.poPrice.Lines = new string[0];
            this.poPrice.Location = new System.Drawing.Point(488, 86);
            this.poPrice.MaxLength = 32767;
            this.poPrice.Name = "poPrice";
            this.poPrice.PasswordChar = '\0';
            this.poPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poPrice.SelectedText = "";
            this.poPrice.SelectionLength = 0;
            this.poPrice.SelectionStart = 0;
            this.poPrice.ShortcutsEnabled = true;
            this.poPrice.Size = new System.Drawing.Size(128, 23);
            this.poPrice.TabIndex = 13;
            this.poPrice.UseSelectable = true;
            this.poPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.poPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.poPrice_KeyPress);
            // 
            // poResetButton
            // 
            this.poResetButton.Location = new System.Drawing.Point(827, 520);
            this.poResetButton.Name = "poResetButton";
            this.poResetButton.Size = new System.Drawing.Size(92, 23);
            this.poResetButton.TabIndex = 27;
            this.poResetButton.Text = "Reset";
            this.poResetButton.UseSelectable = true;
            this.poResetButton.Click += new System.EventHandler(this.poResetButton_Click);
            // 
            // poDataGrid
            // 
            this.poDataGrid.AllowUserToResizeRows = false;
            this.poDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.poDataGrid.EnableHeadersVisualStyles = false;
            this.poDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poDataGrid.Location = new System.Drawing.Point(236, 342);
            this.poDataGrid.Name = "poDataGrid";
            this.poDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poDataGrid.Size = new System.Drawing.Size(736, 146);
            this.poDataGrid.TabIndex = 21;
            this.poDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poDataGrid_CellClick);
            // 
            // poSearchButton
            // 
            this.poSearchButton.Location = new System.Drawing.Point(469, 5);
            this.poSearchButton.Name = "poSearchButton";
            this.poSearchButton.Size = new System.Drawing.Size(92, 23);
            this.poSearchButton.TabIndex = 20;
            this.poSearchButton.Text = "Search";
            this.poSearchButton.UseSelectable = true;
            this.poSearchButton.Click += new System.EventHandler(this.poSearchButton_Click);
            // 
            // poSearch
            // 
            // 
            // 
            // 
            this.poSearch.CustomButton.Image = null;
            this.poSearch.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.poSearch.CustomButton.Name = "";
            this.poSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.poSearch.CustomButton.TabIndex = 1;
            this.poSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.poSearch.CustomButton.UseSelectable = true;
            this.poSearch.CustomButton.Visible = false;
            this.poSearch.Lines = new string[0];
            this.poSearch.Location = new System.Drawing.Point(282, 5);
            this.poSearch.MaxLength = 32767;
            this.poSearch.Name = "poSearch";
            this.poSearch.PasswordChar = '\0';
            this.poSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poSearch.SelectedText = "";
            this.poSearch.SelectionLength = 0;
            this.poSearch.SelectionStart = 0;
            this.poSearch.ShortcutsEnabled = true;
            this.poSearch.Size = new System.Drawing.Size(158, 23);
            this.poSearch.TabIndex = 19;
            this.poSearch.UseSelectable = true;
            this.poSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.poSearch.TextChanged += new System.EventHandler(this.poSearch_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(218, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Search";
            // 
            // poDeleteButton
            // 
            this.poDeleteButton.Location = new System.Drawing.Point(721, 520);
            this.poDeleteButton.Name = "poDeleteButton";
            this.poDeleteButton.Size = new System.Drawing.Size(92, 23);
            this.poDeleteButton.TabIndex = 17;
            this.poDeleteButton.Text = "Delete";
            this.poDeleteButton.UseSelectable = true;
            this.poDeleteButton.Click += new System.EventHandler(this.poDeleteButton_Click);
            // 
            // poAddButton
            // 
            this.poAddButton.Location = new System.Drawing.Point(893, 263);
            this.poAddButton.Name = "poAddButton";
            this.poAddButton.Size = new System.Drawing.Size(92, 23);
            this.poAddButton.TabIndex = 15;
            this.poAddButton.Text = "Purchase";
            this.poAddButton.UseSelectable = true;
            this.poAddButton.Click += new System.EventHandler(this.poAddButton_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.SalesButton);
            this.metroPanel2.Controls.Add(this.ReturnButton);
            this.metroPanel2.Controls.Add(this.InventoryButton);
            this.metroPanel2.Controls.Add(this.PurchaseButton);
            this.metroPanel2.Controls.Add(this.SupplierButton);
            this.metroPanel2.Controls.Add(this.HomeButton);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 561);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(-3, 342);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(207, 45);
            this.SalesButton.TabIndex = 8;
            this.SalesButton.Text = "P.O.S";
            this.SalesButton.UseSelectable = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(-3, 298);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(207, 45);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return Items";
            this.ReturnButton.UseSelectable = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(-3, 253);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(207, 45);
            this.InventoryButton.TabIndex = 6;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseSelectable = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(-3, 208);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(207, 45);
            this.PurchaseButton.TabIndex = 5;
            this.PurchaseButton.Text = "Purchase Order";
            this.PurchaseButton.UseSelectable = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // SupplierButton
            // 
            this.SupplierButton.Location = new System.Drawing.Point(-3, 163);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(207, 45);
            this.SupplierButton.TabIndex = 4;
            this.SupplierButton.Text = "Supplier";
            this.SupplierButton.UseSelectable = true;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(-7, 118);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(207, 45);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseSelectable = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // poUpdateButton
            // 
            this.poUpdateButton.Location = new System.Drawing.Point(615, 520);
            this.poUpdateButton.Name = "poUpdateButton";
            this.poUpdateButton.Size = new System.Drawing.Size(92, 23);
            this.poUpdateButton.TabIndex = 16;
            this.poUpdateButton.Text = "Update";
            this.poUpdateButton.UseSelectable = true;
            this.poUpdateButton.Click += new System.EventHandler(this.poUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.Image = global::Bookshop_Management.Properties.Resources.uilogo;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 115);
            this.label1.TabIndex = 9;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poDataGrid)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton ReturnButton;
        private MetroFramework.Controls.MetroButton InventoryButton;
        private MetroFramework.Controls.MetroButton PurchaseButton;
        private MetroFramework.Controls.MetroButton SupplierButton;
        private MetroFramework.Controls.MetroButton SalesButton;
        private MetroFramework.Controls.MetroButton poDeleteButton;
        private MetroFramework.Controls.MetroButton poUpdateButton;
        private MetroFramework.Controls.MetroButton poAddButton;
        private MetroFramework.Controls.MetroTextBox poPrice;
        private MetroFramework.Controls.MetroTextBox poQuantity;
        private MetroFramework.Controls.MetroTextBox poDescreption;
        private MetroFramework.Controls.MetroLabel poOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid poDataGrid;
        private MetroFramework.Controls.MetroButton poSearchButton;
        private MetroFramework.Controls.MetroTextBox poSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime poDate;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton poResetButton;
        private MetroFramework.Controls.MetroComboBox poName;
        private MetroFramework.Controls.MetroLabel poItemCode;
        private MetroFramework.Controls.MetroComboBox poSupID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

