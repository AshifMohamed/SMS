namespace Bookshop_Management
{
    partial class Supplier
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
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.sAddButton = new MetroFramework.Controls.MetroButton();
            this.sSearchButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.sResetButton = new MetroFramework.Controls.MetroButton();
            this.sSearch = new MetroFramework.Controls.MetroTextBox();
            this.sUpdateButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sID = new MetroFramework.Controls.MetroLabel();
            this.sAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.sPhone = new MetroFramework.Controls.MetroTextBox();
            this.sCompany = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.sName = new MetroFramework.Controls.MetroTextBox();
            this.sEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.sDataGrid = new MetroFramework.Controls.MetroGrid();
            this.sDeleteButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.SalesButton = new MetroFramework.Controls.MetroButton();
            this.ReturnButton = new MetroFramework.Controls.MetroButton();
            this.InventoryButton = new MetroFramework.Controls.MetroButton();
            this.PurchaseButton = new MetroFramework.Controls.MetroButton();
            this.SupplierButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGrid)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1010, 735);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.sAddButton);
            this.metroPanel5.Controls.Add(this.sSearchButton);
            this.metroPanel5.Controls.Add(this.metroLabel8);
            this.metroPanel5.Controls.Add(this.sResetButton);
            this.metroPanel5.Controls.Add(this.sSearch);
            this.metroPanel5.Controls.Add(this.sUpdateButton);
            this.metroPanel5.Controls.Add(this.groupBox1);
            this.metroPanel5.Controls.Add(this.sDataGrid);
            this.metroPanel5.Controls.Add(this.sDeleteButton);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(200, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(810, 735);
            this.metroPanel5.TabIndex = 25;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // sAddButton
            // 
            this.sAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sAddButton.Location = new System.Drawing.Point(676, 204);
            this.sAddButton.Name = "sAddButton";
            this.sAddButton.Size = new System.Drawing.Size(90, 23);
            this.sAddButton.TabIndex = 15;
            this.sAddButton.Text = "Add";
            this.sAddButton.UseSelectable = true;
            this.sAddButton.Click += new System.EventHandler(this.sAddButton_Click);
            // 
            // sSearchButton
            // 
            this.sSearchButton.Location = new System.Drawing.Point(242, 5);
            this.sSearchButton.Name = "sSearchButton";
            this.sSearchButton.Size = new System.Drawing.Size(90, 23);
            this.sSearchButton.TabIndex = 21;
            this.sSearchButton.Text = "Search";
            this.sSearchButton.UseSelectable = true;
            this.sSearchButton.Click += new System.EventHandler(this.sSearchButton_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Search";
            // 
            // sResetButton
            // 
            this.sResetButton.Location = new System.Drawing.Point(687, 507);
            this.sResetButton.Name = "sResetButton";
            this.sResetButton.Size = new System.Drawing.Size(90, 23);
            this.sResetButton.TabIndex = 22;
            this.sResetButton.Text = "Reset";
            this.sResetButton.UseSelectable = true;
            this.sResetButton.Click += new System.EventHandler(this.sResetButton_Click);
            // 
            // sSearch
            // 
            // 
            // 
            // 
            this.sSearch.CustomButton.Image = null;
            this.sSearch.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.sSearch.CustomButton.Name = "";
            this.sSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sSearch.CustomButton.TabIndex = 1;
            this.sSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sSearch.CustomButton.UseSelectable = true;
            this.sSearch.CustomButton.Visible = false;
            this.sSearch.Lines = new string[0];
            this.sSearch.Location = new System.Drawing.Point(67, 5);
            this.sSearch.MaxLength = 32767;
            this.sSearch.Name = "sSearch";
            this.sSearch.PasswordChar = '\0';
            this.sSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sSearch.SelectedText = "";
            this.sSearch.SelectionLength = 0;
            this.sSearch.SelectionStart = 0;
            this.sSearch.ShortcutsEnabled = true;
            this.sSearch.Size = new System.Drawing.Size(142, 23);
            this.sSearch.TabIndex = 20;
            this.sSearch.UseSelectable = true;
            this.sSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sSearch.TextChanged += new System.EventHandler(this.sSearch_TextChanged);
            // 
            // sUpdateButton
            // 
            this.sUpdateButton.Location = new System.Drawing.Point(463, 507);
            this.sUpdateButton.Name = "sUpdateButton";
            this.sUpdateButton.Size = new System.Drawing.Size(90, 23);
            this.sUpdateButton.TabIndex = 16;
            this.sUpdateButton.Text = "Update";
            this.sUpdateButton.UseSelectable = true;
            this.sUpdateButton.Click += new System.EventHandler(this.sUpdateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.sID);
            this.groupBox1.Controls.Add(this.sAddress);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.sPhone);
            this.groupBox1.Controls.Add(this.sCompany);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.sName);
            this.groupBox1.Controls.Add(this.sEmail);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Location = new System.Drawing.Point(41, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ID";
            // 
            // sID
            // 
            this.sID.AutoSize = true;
            this.sID.Location = new System.Drawing.Point(119, 19);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(61, 19);
            this.sID.TabIndex = 8;
            this.sID.Text = "             ";
            // 
            // sAddress
            // 
            // 
            // 
            // 
            this.sAddress.CustomButton.Image = null;
            this.sAddress.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.sAddress.CustomButton.Name = "";
            this.sAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sAddress.CustomButton.TabIndex = 1;
            this.sAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sAddress.CustomButton.UseSelectable = true;
            this.sAddress.CustomButton.Visible = false;
            this.sAddress.Lines = new string[0];
            this.sAddress.Location = new System.Drawing.Point(447, 116);
            this.sAddress.MaxLength = 32767;
            this.sAddress.Name = "sAddress";
            this.sAddress.PasswordChar = '\0';
            this.sAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sAddress.SelectedText = "";
            this.sAddress.SelectionLength = 0;
            this.sAddress.SelectionStart = 0;
            this.sAddress.ShortcutsEnabled = true;
            this.sAddress.Size = new System.Drawing.Size(136, 23);
            this.sAddress.TabIndex = 14;
            this.sAddress.UseSelectable = true;
            this.sAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(333, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Phone Number";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(333, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Address";
            // 
            // sPhone
            // 
            // 
            // 
            // 
            this.sPhone.CustomButton.Image = null;
            this.sPhone.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.sPhone.CustomButton.Name = "";
            this.sPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sPhone.CustomButton.TabIndex = 1;
            this.sPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sPhone.CustomButton.UseSelectable = true;
            this.sPhone.CustomButton.Visible = false;
            this.sPhone.Lines = new string[0];
            this.sPhone.Location = new System.Drawing.Point(447, 19);
            this.sPhone.MaxLength = 32767;
            this.sPhone.Name = "sPhone";
            this.sPhone.PasswordChar = '\0';
            this.sPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sPhone.SelectedText = "";
            this.sPhone.SelectionLength = 0;
            this.sPhone.SelectionStart = 0;
            this.sPhone.ShortcutsEnabled = true;
            this.sPhone.Size = new System.Drawing.Size(136, 23);
            this.sPhone.TabIndex = 12;
            this.sPhone.UseSelectable = true;
            this.sPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sPhone_KeyPress);
            // 
            // sCompany
            // 
            // 
            // 
            // 
            this.sCompany.CustomButton.Image = null;
            this.sCompany.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.sCompany.CustomButton.Name = "";
            this.sCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sCompany.CustomButton.TabIndex = 1;
            this.sCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sCompany.CustomButton.UseSelectable = true;
            this.sCompany.CustomButton.Visible = false;
            this.sCompany.Lines = new string[0];
            this.sCompany.Location = new System.Drawing.Point(119, 116);
            this.sCompany.MaxLength = 32767;
            this.sCompany.Name = "sCompany";
            this.sCompany.PasswordChar = '\0';
            this.sCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sCompany.SelectedText = "";
            this.sCompany.SelectionLength = 0;
            this.sCompany.SelectionStart = 0;
            this.sCompany.ShortcutsEnabled = true;
            this.sCompany.Size = new System.Drawing.Size(136, 23);
            this.sCompany.TabIndex = 11;
            this.sCompany.UseSelectable = true;
            this.sCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Company";
            // 
            // sName
            // 
            // 
            // 
            // 
            this.sName.CustomButton.Image = null;
            this.sName.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.sName.CustomButton.Name = "";
            this.sName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sName.CustomButton.TabIndex = 1;
            this.sName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sName.CustomButton.UseSelectable = true;
            this.sName.CustomButton.Visible = false;
            this.sName.Lines = new string[0];
            this.sName.Location = new System.Drawing.Point(119, 67);
            this.sName.MaxLength = 32767;
            this.sName.Name = "sName";
            this.sName.PasswordChar = '\0';
            this.sName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sName.SelectedText = "";
            this.sName.SelectionLength = 0;
            this.sName.SelectionStart = 0;
            this.sName.ShortcutsEnabled = true;
            this.sName.Size = new System.Drawing.Size(131, 23);
            this.sName.TabIndex = 10;
            this.sName.UseSelectable = true;
            this.sName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sName_KeyPress);
            // 
            // sEmail
            // 
            // 
            // 
            // 
            this.sEmail.CustomButton.Image = null;
            this.sEmail.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.sEmail.CustomButton.Name = "";
            this.sEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sEmail.CustomButton.TabIndex = 1;
            this.sEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sEmail.CustomButton.UseSelectable = true;
            this.sEmail.CustomButton.Visible = false;
            this.sEmail.Lines = new string[0];
            this.sEmail.Location = new System.Drawing.Point(447, 67);
            this.sEmail.MaxLength = 32767;
            this.sEmail.Name = "sEmail";
            this.sEmail.PasswordChar = '\0';
            this.sEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sEmail.SelectedText = "";
            this.sEmail.SelectionLength = 0;
            this.sEmail.SelectionStart = 0;
            this.sEmail.ShortcutsEnabled = true;
            this.sEmail.Size = new System.Drawing.Size(136, 23);
            this.sEmail.TabIndex = 13;
            this.sEmail.UseSelectable = true;
            this.sEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(333, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Email";
            // 
            // sDataGrid
            // 
            this.sDataGrid.AllowUserToResizeRows = false;
            this.sDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.sDataGrid.EnableHeadersVisualStyles = false;
            this.sDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sDataGrid.Location = new System.Drawing.Point(41, 280);
            this.sDataGrid.Name = "sDataGrid";
            this.sDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDataGrid.Size = new System.Drawing.Size(725, 203);
            this.sDataGrid.TabIndex = 18;
            this.sDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sDataGrid_CellClick);
            // 
            // sDeleteButton
            // 
            this.sDeleteButton.Location = new System.Drawing.Point(573, 507);
            this.sDeleteButton.Name = "sDeleteButton";
            this.sDeleteButton.Size = new System.Drawing.Size(90, 23);
            this.sDeleteButton.TabIndex = 17;
            this.sDeleteButton.Text = "Delete";
            this.sDeleteButton.UseSelectable = true;
            this.sDeleteButton.Click += new System.EventHandler(this.sDeleteButton_Click);
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
            this.metroPanel2.Size = new System.Drawing.Size(200, 735);
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
            // label1
            // 
            this.label1.Image = global::Bookshop_Management.Properties.Resources.uilogo;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 115);
            this.label1.TabIndex = 9;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sDataGrid)).EndInit();
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
        private MetroFramework.Controls.MetroLabel sID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton sSearchButton;
        private MetroFramework.Controls.MetroTextBox sSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid sDataGrid;
        private MetroFramework.Controls.MetroButton sDeleteButton;
        private MetroFramework.Controls.MetroButton sUpdateButton;
        private MetroFramework.Controls.MetroTextBox sAddress;
        private MetroFramework.Controls.MetroTextBox sEmail;
        private MetroFramework.Controls.MetroTextBox sPhone;
        private MetroFramework.Controls.MetroTextBox sCompany;
        private MetroFramework.Controls.MetroTextBox sName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton sResetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton sAddButton;
        private System.Windows.Forms.Label label1;
    }
}

