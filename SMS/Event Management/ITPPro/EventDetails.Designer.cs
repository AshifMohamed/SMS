namespace ITPPro
{
    partial class EventDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Endt = new System.Windows.Forms.DateTimePicker();
            this.satrt = new System.Windows.Forms.DateTimePicker();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.view = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TexId = new MetroFramework.Controls.MetroTextBox();
            this.Endtime = new MetroFramework.Controls.MetroTextBox();
            this.strtime = new MetroFramework.Controls.MetroTextBox();
            this.organize = new MetroFramework.Controls.MetroTextBox();
            this.venue = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxDes = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Endt);
            this.groupBox1.Controls.Add(this.satrt);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.view);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TexId);
            this.groupBox1.Controls.Add(this.Endtime);
            this.groupBox1.Controls.Add(this.strtime);
            this.groupBox1.Controls.Add(this.organize);
            this.groupBox1.Controls.Add(this.venue);
            this.groupBox1.Controls.Add(this.TextBoxDes);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Location = new System.Drawing.Point(193, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Details";
            this.groupBox1.Visible = false;
            // 
            // Endt
            // 
            this.Endt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Endt.Location = new System.Drawing.Point(519, 155);
            this.Endt.Name = "Endt";
            this.Endt.Size = new System.Drawing.Size(82, 20);
            this.Endt.TabIndex = 39;
            this.Endt.ValueChanged += new System.EventHandler(this.Endt_ValueChanged);
            // 
            // satrt
            // 
            this.satrt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.satrt.Location = new System.Drawing.Point(519, 69);
            this.satrt.Name = "satrt";
            this.satrt.Size = new System.Drawing.Size(82, 20);
            this.satrt.TabIndex = 38;
            this.satrt.ValueChanged += new System.EventHandler(this.satrt_ValueChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(160, 252);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(83, 31);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton3.TabIndex = 37;
            this.metroButton3.Text = "Clear";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(269, 252);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(82, 31);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 36;
            this.metroButton2.Text = "Delete";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(406, 196);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "End Time";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(374, 252);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(81, 31);
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Update";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(477, 252);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(88, 31);
            this.view.Style = MetroFramework.MetroColorStyle.Red;
            this.view.TabIndex = 3;
            this.view.Text = "More Details";
            this.view.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.view.UseSelectable = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(406, 156);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "End Date";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(399, 111);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Start Time";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(401, 66);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Start Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(399, 23);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Organizer";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(61, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Venue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "EDescription";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Ename";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "EventID";
            // 
            // TexId
            // 
            // 
            // 
            // 
            this.TexId.CustomButton.Image = null;
            this.TexId.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.TexId.CustomButton.Name = "";
            this.TexId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexId.CustomButton.TabIndex = 1;
            this.TexId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexId.CustomButton.UseSelectable = true;
            this.TexId.CustomButton.Visible = false;
            this.TexId.Lines = new string[0];
            this.TexId.Location = new System.Drawing.Point(149, 23);
            this.TexId.MaxLength = 32767;
            this.TexId.Name = "TexId";
            this.TexId.PasswordChar = '\0';
            this.TexId.ReadOnly = true;
            this.TexId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexId.SelectedText = "";
            this.TexId.SelectionLength = 0;
            this.TexId.SelectionStart = 0;
            this.TexId.ShortcutsEnabled = true;
            this.TexId.Size = new System.Drawing.Size(160, 23);
            this.TexId.TabIndex = 26;
            this.TexId.UseSelectable = true;
            this.TexId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Endtime
            // 
            // 
            // 
            // 
            this.Endtime.CustomButton.Image = null;
            this.Endtime.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.Endtime.CustomButton.Name = "";
            this.Endtime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Endtime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Endtime.CustomButton.TabIndex = 1;
            this.Endtime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Endtime.CustomButton.UseSelectable = true;
            this.Endtime.CustomButton.Visible = false;
            this.Endtime.Lines = new string[0];
            this.Endtime.Location = new System.Drawing.Point(519, 196);
            this.Endtime.MaxLength = 32767;
            this.Endtime.Name = "Endtime";
            this.Endtime.PasswordChar = '\0';
            this.Endtime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Endtime.SelectedText = "";
            this.Endtime.SelectionLength = 0;
            this.Endtime.SelectionStart = 0;
            this.Endtime.ShortcutsEnabled = true;
            this.Endtime.Size = new System.Drawing.Size(82, 23);
            this.Endtime.TabIndex = 24;
            this.Endtime.UseSelectable = true;
            this.Endtime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Endtime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // strtime
            // 
            // 
            // 
            // 
            this.strtime.CustomButton.Image = null;
            this.strtime.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.strtime.CustomButton.Name = "";
            this.strtime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.strtime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.strtime.CustomButton.TabIndex = 1;
            this.strtime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.strtime.CustomButton.UseSelectable = true;
            this.strtime.CustomButton.Visible = false;
            this.strtime.Lines = new string[0];
            this.strtime.Location = new System.Drawing.Point(519, 111);
            this.strtime.MaxLength = 32767;
            this.strtime.Name = "strtime";
            this.strtime.PasswordChar = '\0';
            this.strtime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.strtime.SelectedText = "";
            this.strtime.SelectionLength = 0;
            this.strtime.SelectionStart = 0;
            this.strtime.ShortcutsEnabled = true;
            this.strtime.Size = new System.Drawing.Size(82, 23);
            this.strtime.TabIndex = 22;
            this.strtime.UseSelectable = true;
            this.strtime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.strtime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // organize
            // 
            // 
            // 
            // 
            this.organize.CustomButton.Image = null;
            this.organize.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.organize.CustomButton.Name = "";
            this.organize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.organize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.organize.CustomButton.TabIndex = 1;
            this.organize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.organize.CustomButton.UseSelectable = true;
            this.organize.CustomButton.Visible = false;
            this.organize.Lines = new string[0];
            this.organize.Location = new System.Drawing.Point(519, 23);
            this.organize.MaxLength = 32767;
            this.organize.Name = "organize";
            this.organize.PasswordChar = '\0';
            this.organize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.organize.SelectedText = "";
            this.organize.SelectionLength = 0;
            this.organize.SelectionStart = 0;
            this.organize.ShortcutsEnabled = true;
            this.organize.Size = new System.Drawing.Size(160, 23);
            this.organize.TabIndex = 20;
            this.organize.UseSelectable = true;
            this.organize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.organize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.organize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.organize_KeyPress);
            // 
            // venue
            // 
            // 
            // 
            // 
            this.venue.CustomButton.Image = null;
            this.venue.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.venue.CustomButton.Name = "";
            this.venue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.venue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.venue.CustomButton.TabIndex = 1;
            this.venue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.venue.CustomButton.UseSelectable = true;
            this.venue.CustomButton.Visible = false;
            this.venue.Lines = new string[0];
            this.venue.Location = new System.Drawing.Point(149, 196);
            this.venue.MaxLength = 32767;
            this.venue.Name = "venue";
            this.venue.PasswordChar = '\0';
            this.venue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.venue.SelectedText = "";
            this.venue.SelectionLength = 0;
            this.venue.SelectionStart = 0;
            this.venue.ShortcutsEnabled = true;
            this.venue.Size = new System.Drawing.Size(160, 23);
            this.venue.TabIndex = 13;
            this.venue.UseSelectable = true;
            this.venue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.venue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.venue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.venue_KeyPress);
            // 
            // TextBoxDes
            // 
            // 
            // 
            // 
            this.TextBoxDes.CustomButton.Image = null;
            this.TextBoxDes.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.TextBoxDes.CustomButton.Name = "";
            this.TextBoxDes.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.TextBoxDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDes.CustomButton.TabIndex = 1;
            this.TextBoxDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDes.CustomButton.UseSelectable = true;
            this.TextBoxDes.CustomButton.Visible = false;
            this.TextBoxDes.Lines = new string[0];
            this.TextBoxDes.Location = new System.Drawing.Point(149, 111);
            this.TextBoxDes.MaxLength = 32767;
            this.TextBoxDes.Multiline = true;
            this.TextBoxDes.Name = "TextBoxDes";
            this.TextBoxDes.PasswordChar = '\0';
            this.TextBoxDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDes.SelectedText = "";
            this.TextBoxDes.SelectionLength = 0;
            this.TextBoxDes.SelectionStart = 0;
            this.TextBoxDes.ShortcutsEnabled = true;
            this.TextBoxDes.Size = new System.Drawing.Size(160, 64);
            this.TextBoxDes.TabIndex = 12;
            this.TextBoxDes.UseSelectable = true;
            this.TextBoxDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDes_KeyPress);
            // 
            // TextBoxName
            // 
            // 
            // 
            // 
            this.TextBoxName.CustomButton.Image = null;
            this.TextBoxName.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.TextBoxName.CustomButton.Name = "";
            this.TextBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxName.CustomButton.TabIndex = 1;
            this.TextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxName.CustomButton.UseSelectable = true;
            this.TextBoxName.CustomButton.Visible = false;
            this.TextBoxName.Lines = new string[0];
            this.TextBoxName.Location = new System.Drawing.Point(149, 66);
            this.TextBoxName.MaxLength = 32767;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.SelectionLength = 0;
            this.TextBoxName.SelectionStart = 0;
            this.TextBoxName.ShortcutsEnabled = true;
            this.TextBoxName.Size = new System.Drawing.Size(160, 23);
            this.TextBoxName.TabIndex = 11;
            this.TextBoxName.UseSelectable = true;
            this.TextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(25, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 180);
            this.dataGridView1.Style = MetroFramework.MetroColorStyle.Blue;
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(152, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventDetails";
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton view;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox TexId;
        public MetroFramework.Controls.MetroTextBox Endtime;
        public MetroFramework.Controls.MetroTextBox strtime;
        public MetroFramework.Controls.MetroTextBox organize;
        public MetroFramework.Controls.MetroTextBox venue;
        public MetroFramework.Controls.MetroTextBox TextBoxDes;
        public MetroFramework.Controls.MetroTextBox TextBoxName;
        public MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.DateTimePicker satrt;
        private System.Windows.Forms.DateTimePicker Endt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider2;

    }
}