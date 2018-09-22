namespace ITPLibrary
{
    partial class RegisterBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.BkID = new MetroFramework.Controls.MetroTextBox();
            this.QtyTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.typecmb = new MetroFramework.Controls.MetroComboBox();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.title = new MetroFramework.Controls.MetroTextBox();
            this.author = new MetroFramework.Controls.MetroTextBox();
            this.accessionNumtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pubdate = new MetroFramework.Controls.MetroDateTime();
            this.pubname = new MetroFramework.Controls.MetroTextBox();
            this.delete = new MetroFramework.Controls.MetroButton();
            this.btregbk = new MetroFramework.Controls.MetroButton();
            this.tableRegBk = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessionNumdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authordgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titledgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubnamedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubdatedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Clear = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegBk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.BkID);
            this.groupBox1.Controls.Add(this.QtyTxt);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.typecmb);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.accessionNumtxt);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 24);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(55, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Book ID";
            // 
            // BkID
            // 
            // 
            // 
            // 
            this.BkID.CustomButton.Image = null;
            this.BkID.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.BkID.CustomButton.Name = "";
            this.BkID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BkID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BkID.CustomButton.TabIndex = 1;
            this.BkID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BkID.CustomButton.UseSelectable = true;
            this.BkID.CustomButton.Visible = false;
            this.BkID.Enabled = false;
            this.BkID.Lines = new string[0];
            this.BkID.Location = new System.Drawing.Point(172, 19);
            this.BkID.MaxLength = 32767;
            this.BkID.Name = "BkID";
            this.BkID.PasswordChar = '\0';
            this.BkID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BkID.SelectedText = "";
            this.BkID.SelectionLength = 0;
            this.BkID.SelectionStart = 0;
            this.BkID.ShortcutsEnabled = true;
            this.BkID.Size = new System.Drawing.Size(158, 23);
            this.BkID.TabIndex = 12;
            this.BkID.UseSelectable = true;
            this.BkID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BkID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QtyTxt
            // 
            // 
            // 
            // 
            this.QtyTxt.CustomButton.Image = null;
            this.QtyTxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.QtyTxt.CustomButton.Name = "";
            this.QtyTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QtyTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QtyTxt.CustomButton.TabIndex = 1;
            this.QtyTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QtyTxt.CustomButton.UseSelectable = true;
            this.QtyTxt.CustomButton.Visible = false;
            this.QtyTxt.Lines = new string[0];
            this.QtyTxt.Location = new System.Drawing.Point(172, 216);
            this.QtyTxt.MaxLength = 32767;
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.PasswordChar = '\0';
            this.QtyTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QtyTxt.SelectedText = "";
            this.QtyTxt.SelectionLength = 0;
            this.QtyTxt.SelectionStart = 0;
            this.QtyTxt.ShortcutsEnabled = true;
            this.QtyTxt.Size = new System.Drawing.Size(158, 23);
            this.QtyTxt.TabIndex = 11;
            this.QtyTxt.UseSelectable = true;
            this.QtyTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QtyTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 220);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Quantity";
            // 
            // typecmb
            // 
            this.typecmb.FormattingEnabled = true;
            this.typecmb.ItemHeight = 23;
            this.typecmb.Items.AddRange(new object[] {
            "Story book",
            "Islamic Religion",
            "Science",
            "Sinhala Language",
            "Tamil Language",
            "History",
            "Geography",
            "Maths",
            "Arts and Crafts",
            "English Language",
            "Arabic Language",
            "Health Science",
            "ICT",
            "Magazine"});
            this.typecmb.Location = new System.Drawing.Point(172, 180);
            this.typecmb.Name = "typecmb";
            this.typecmb.Size = new System.Drawing.Size(158, 29);
            this.typecmb.TabIndex = 9;
            this.typecmb.UseSelectable = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(172, 84);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(158, 29);
            this.date.TabIndex = 8;
            this.date.Value = new System.DateTime(2016, 9, 15, 0, 0, 0, 0);
            // 
            // title
            // 
            // 
            // 
            // 
            this.title.CustomButton.Image = null;
            this.title.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.title.CustomButton.Name = "";
            this.title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.title.CustomButton.TabIndex = 1;
            this.title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title.CustomButton.UseSelectable = true;
            this.title.CustomButton.Visible = false;
            this.title.Lines = new string[0];
            this.title.Location = new System.Drawing.Point(172, 148);
            this.title.MaxLength = 32767;
            this.title.Name = "title";
            this.title.PasswordChar = '\0';
            this.title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.title.SelectedText = "";
            this.title.SelectionLength = 0;
            this.title.SelectionStart = 0;
            this.title.ShortcutsEnabled = true;
            this.title.Size = new System.Drawing.Size(158, 23);
            this.title.TabIndex = 7;
            this.title.UseSelectable = true;
            this.title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // author
            // 
            // 
            // 
            // 
            this.author.CustomButton.Image = null;
            this.author.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.author.CustomButton.Name = "";
            this.author.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.author.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.author.CustomButton.TabIndex = 1;
            this.author.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.author.CustomButton.UseSelectable = true;
            this.author.CustomButton.Visible = false;
            this.author.Lines = new string[0];
            this.author.Location = new System.Drawing.Point(172, 119);
            this.author.MaxLength = 32767;
            this.author.Name = "author";
            this.author.PasswordChar = '\0';
            this.author.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.author.SelectedText = "";
            this.author.SelectionLength = 0;
            this.author.SelectionStart = 0;
            this.author.ShortcutsEnabled = true;
            this.author.Size = new System.Drawing.Size(158, 23);
            this.author.TabIndex = 6;
            this.author.UseSelectable = true;
            this.author.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.author.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            this.author.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // accessionNumtxt
            // 
            // 
            // 
            // 
            this.accessionNumtxt.CustomButton.Image = null;
            this.accessionNumtxt.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.accessionNumtxt.CustomButton.Name = "";
            this.accessionNumtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.accessionNumtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.accessionNumtxt.CustomButton.TabIndex = 1;
            this.accessionNumtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.accessionNumtxt.CustomButton.UseSelectable = true;
            this.accessionNumtxt.CustomButton.Visible = false;
            this.accessionNumtxt.Enabled = false;
            this.accessionNumtxt.Lines = new string[0];
            this.accessionNumtxt.Location = new System.Drawing.Point(172, 51);
            this.accessionNumtxt.MaxLength = 32767;
            this.accessionNumtxt.Name = "accessionNumtxt";
            this.accessionNumtxt.PasswordChar = '\0';
            this.accessionNumtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.accessionNumtxt.SelectedText = "";
            this.accessionNumtxt.SelectionLength = 0;
            this.accessionNumtxt.SelectionStart = 0;
            this.accessionNumtxt.ShortcutsEnabled = true;
            this.accessionNumtxt.Size = new System.Drawing.Size(158, 23);
            this.accessionNumtxt.TabIndex = 5;
            this.accessionNumtxt.UseSelectable = true;
            this.accessionNumtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.accessionNumtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Type";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Title";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Author";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Accession Number";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Publisher Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 76);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Published Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pubdate);
            this.groupBox2.Controls.Add(this.pubname);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Location = new System.Drawing.Point(421, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publisher Details";
            // 
            // pubdate
            // 
            this.pubdate.Location = new System.Drawing.Point(166, 64);
            this.pubdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.pubdate.Name = "pubdate";
            this.pubdate.Size = new System.Drawing.Size(158, 29);
            this.pubdate.TabIndex = 7;
            this.pubdate.Value = new System.DateTime(2016, 9, 15, 0, 0, 0, 0);
            // 
            // pubname
            // 
            // 
            // 
            // 
            this.pubname.CustomButton.Image = null;
            this.pubname.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.pubname.CustomButton.Name = "";
            this.pubname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pubname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pubname.CustomButton.TabIndex = 1;
            this.pubname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pubname.CustomButton.UseSelectable = true;
            this.pubname.CustomButton.Visible = false;
            this.pubname.Lines = new string[0];
            this.pubname.Location = new System.Drawing.Point(166, 35);
            this.pubname.MaxLength = 32767;
            this.pubname.Name = "pubname";
            this.pubname.PasswordChar = '\0';
            this.pubname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pubname.SelectedText = "";
            this.pubname.SelectionLength = 0;
            this.pubname.SelectionStart = 0;
            this.pubname.ShortcutsEnabled = true;
            this.pubname.Size = new System.Drawing.Size(158, 23);
            this.pubname.TabIndex = 6;
            this.pubname.UseSelectable = true;
            this.pubname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pubname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pubname.TextChanged += new System.EventHandler(this.pubname_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(587, 192);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseSelectable = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btregbk
            // 
            this.btregbk.Location = new System.Drawing.Point(731, 192);
            this.btregbk.Name = "btregbk";
            this.btregbk.Size = new System.Drawing.Size(75, 23);
            this.btregbk.TabIndex = 8;
            this.btregbk.Text = "Add";
            this.btregbk.UseSelectable = true;
            this.btregbk.Click += new System.EventHandler(this.btregbk_Click);
            // 
            // tableRegBk
            // 
            this.tableRegBk.AllowUserToAddRows = false;
            this.tableRegBk.AllowUserToDeleteRows = false;
            this.tableRegBk.AllowUserToOrderColumns = true;
            this.tableRegBk.AllowUserToResizeRows = false;
            this.tableRegBk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableRegBk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableRegBk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableRegBk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableRegBk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableRegBk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRegBk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.accessionNumdgv,
            this.datedgv,
            this.authordgv,
            this.titledgv,
            this.typedgv,
            this.pubnamedgv,
            this.pubdatedgv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableRegBk.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableRegBk.EnableHeadersVisualStyles = false;
            this.tableRegBk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableRegBk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableRegBk.Location = new System.Drawing.Point(21, 270);
            this.tableRegBk.Name = "tableRegBk";
            this.tableRegBk.ReadOnly = true;
            this.tableRegBk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableRegBk.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableRegBk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableRegBk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableRegBk.Size = new System.Drawing.Size(839, 131);
            this.tableRegBk.TabIndex = 9;
            this.tableRegBk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableRegBk_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Num";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // accessionNumdgv
            // 
            this.accessionNumdgv.HeaderText = "Accession Number";
            this.accessionNumdgv.Name = "accessionNumdgv";
            this.accessionNumdgv.ReadOnly = true;
            // 
            // datedgv
            // 
            this.datedgv.HeaderText = "Date";
            this.datedgv.Name = "datedgv";
            this.datedgv.ReadOnly = true;
            // 
            // authordgv
            // 
            this.authordgv.HeaderText = "Author";
            this.authordgv.Name = "authordgv";
            this.authordgv.ReadOnly = true;
            // 
            // titledgv
            // 
            this.titledgv.HeaderText = "Title";
            this.titledgv.Name = "titledgv";
            this.titledgv.ReadOnly = true;
            // 
            // typedgv
            // 
            this.typedgv.HeaderText = "Type";
            this.typedgv.Name = "typedgv";
            this.typedgv.ReadOnly = true;
            // 
            // pubnamedgv
            // 
            this.pubnamedgv.HeaderText = "Publisher Name";
            this.pubnamedgv.Name = "pubnamedgv";
            this.pubnamedgv.ReadOnly = true;
            // 
            // pubdatedgv
            // 
            this.pubdatedgv.HeaderText = "Published Date";
            this.pubdatedgv.Name = "pubdatedgv";
            this.pubdatedgv.ReadOnly = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(719, 245);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(127, 19);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Total Book Count : 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(659, 160);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseSelectable = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(498, 160);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Display Quantity";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(438, 192);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Update";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(589, 12);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(133, 23);
            this.metroTextBox1.TabIndex = 15;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(719, 12);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(77, 23);
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "Search";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // RegisterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 432);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tableRegBk);
            this.Controls.Add(this.btregbk);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterBook";
            this.Text = "RegisterBook";
            this.Load += new System.EventHandler(this.RegisterBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRegBk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox typecmb;
        private MetroFramework.Controls.MetroDateTime date;
        private MetroFramework.Controls.MetroTextBox title;
        private MetroFramework.Controls.MetroTextBox author;
        private MetroFramework.Controls.MetroTextBox pubname;
        private MetroFramework.Controls.MetroDateTime pubdate;
        private MetroFramework.Controls.MetroButton delete;
        private MetroFramework.Controls.MetroButton btregbk;
        private MetroFramework.Controls.MetroGrid tableRegBk;
        private MetroFramework.Controls.MetroLabel lblCount;
        private MetroFramework.Controls.MetroTextBox accessionNumtxt;
        private MetroFramework.Controls.MetroTextBox QtyTxt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton Clear;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox BkID;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNumdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn authordgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn titledgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn typedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubnamedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubdatedgv;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}