namespace ITPLibrary
{
    partial class RegisterStudent
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
            this.gender = new MetroFramework.Controls.MetroComboBox();
            this.fname = new MetroFramework.Controls.MetroTextBox();
            this.admisNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tphone = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpexpiry = new MetroFramework.Controls.MetroDateTime();
            this.dtpjoin = new MetroFramework.Controls.MetroDateTime();
            this.RegStd = new MetroFramework.Controls.MetroButton();
            this.deleteregstud = new MetroFramework.Controls.MetroButton();
            this.dgvregStudent = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailBt = new MetroFramework.Controls.MetroButton();
            this.Clear = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.admisNum);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // gender
            // 
            this.gender.Enabled = false;
            this.gender.FormattingEnabled = true;
            this.gender.ItemHeight = 23;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(177, 92);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(162, 29);
            this.gender.TabIndex = 9;
            this.gender.UseSelectable = true;
            // 
            // fname
            // 
            // 
            // 
            // 
            this.fname.CustomButton.Image = null;
            this.fname.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.fname.CustomButton.Name = "";
            this.fname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fname.CustomButton.TabIndex = 1;
            this.fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fname.CustomButton.UseSelectable = true;
            this.fname.CustomButton.Visible = false;
            this.fname.Enabled = false;
            this.fname.Lines = new string[0];
            this.fname.Location = new System.Drawing.Point(177, 63);
            this.fname.MaxLength = 32767;
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fname.SelectedText = "";
            this.fname.SelectionLength = 0;
            this.fname.SelectionStart = 0;
            this.fname.ShortcutsEnabled = true;
            this.fname.Size = new System.Drawing.Size(162, 23);
            this.fname.TabIndex = 6;
            this.fname.UseSelectable = true;
            this.fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // admisNum
            // 
            // 
            // 
            // 
            this.admisNum.CustomButton.Image = null;
            this.admisNum.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.admisNum.CustomButton.Name = "";
            this.admisNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.admisNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.admisNum.CustomButton.TabIndex = 1;
            this.admisNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.admisNum.CustomButton.UseSelectable = true;
            this.admisNum.CustomButton.Visible = false;
            this.admisNum.Lines = new string[0];
            this.admisNum.Location = new System.Drawing.Point(177, 34);
            this.admisNum.MaxLength = 32767;
            this.admisNum.Name = "admisNum";
            this.admisNum.PasswordChar = '\0';
            this.admisNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.admisNum.SelectedText = "";
            this.admisNum.SelectionLength = 0;
            this.admisNum.SelectionStart = 0;
            this.admisNum.ShortcutsEnabled = true;
            this.admisNum.Size = new System.Drawing.Size(162, 23);
            this.admisNum.TabIndex = 5;
            this.admisNum.UseSelectable = true;
            this.admisNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.admisNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.admisNum.TextChanged += new System.EventHandler(this.admisNum_TextChanged);
            this.admisNum.Enter += new System.EventHandler(this.admisNum_Enter);
            this.admisNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.admisNum_KeyDown);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Gender ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Full Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Admission Number";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Telephone";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 54);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Email";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 22);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Joining Date";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 57);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(122, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Membership Expiry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tphone);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Location = new System.Drawing.Point(407, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tphone
            // 
            // 
            // 
            // 
            this.tphone.CustomButton.Image = null;
            this.tphone.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.tphone.CustomButton.Name = "";
            this.tphone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tphone.CustomButton.TabIndex = 1;
            this.tphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tphone.CustomButton.UseSelectable = true;
            this.tphone.CustomButton.Visible = false;
            this.tphone.Enabled = false;
            this.tphone.Lines = new string[0];
            this.tphone.Location = new System.Drawing.Point(153, 21);
            this.tphone.MaxLength = 32767;
            this.tphone.Name = "tphone";
            this.tphone.PasswordChar = '\0';
            this.tphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tphone.SelectedText = "";
            this.tphone.SelectionLength = 0;
            this.tphone.SelectionStart = 0;
            this.tphone.ShortcutsEnabled = true;
            this.tphone.Size = new System.Drawing.Size(162, 23);
            this.tphone.TabIndex = 8;
            this.tphone.UseSelectable = true;
            this.tphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Enabled = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(153, 50);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(162, 23);
            this.email.TabIndex = 3;
            this.email.UseSelectable = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpexpiry);
            this.groupBox3.Controls.Add(this.dtpjoin);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Location = new System.Drawing.Point(407, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Information";
            // 
            // dtpexpiry
            // 
            this.dtpexpiry.Location = new System.Drawing.Point(150, 47);
            this.dtpexpiry.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpexpiry.Name = "dtpexpiry";
            this.dtpexpiry.Size = new System.Drawing.Size(166, 29);
            this.dtpexpiry.TabIndex = 6;
            // 
            // dtpjoin
            // 
            this.dtpjoin.Location = new System.Drawing.Point(150, 12);
            this.dtpjoin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpjoin.Name = "dtpjoin";
            this.dtpjoin.Size = new System.Drawing.Size(165, 29);
            this.dtpjoin.TabIndex = 5;
            // 
            // RegStd
            // 
            this.RegStd.Location = new System.Drawing.Point(200, 170);
            this.RegStd.Name = "RegStd";
            this.RegStd.Size = new System.Drawing.Size(75, 23);
            this.RegStd.TabIndex = 8;
            this.RegStd.Text = "Register";
            this.RegStd.UseSelectable = true;
            this.RegStd.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // deleteregstud
            // 
            this.deleteregstud.Location = new System.Drawing.Point(110, 170);
            this.deleteregstud.Name = "deleteregstud";
            this.deleteregstud.Size = new System.Drawing.Size(75, 23);
            this.deleteregstud.TabIndex = 7;
            this.deleteregstud.Text = "Delete";
            this.deleteregstud.UseSelectable = true;
            this.deleteregstud.Click += new System.EventHandler(this.deleteregstud_Click);
            // 
            // dgvregStudent
            // 
            this.dgvregStudent.AllowUserToAddRows = false;
            this.dgvregStudent.AllowUserToDeleteRows = false;
            this.dgvregStudent.AllowUserToResizeRows = false;
            this.dgvregStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvregStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvregStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvregStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvregStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvregStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvregStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvregStudent.EnableHeadersVisualStyles = false;
            this.dgvregStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvregStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvregStudent.Location = new System.Drawing.Point(12, 215);
            this.dgvregStudent.Name = "dgvregStudent";
            this.dgvregStudent.ReadOnly = true;
            this.dgvregStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvregStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvregStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvregStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvregStudent.Size = new System.Drawing.Size(746, 150);
            this.dgvregStudent.TabIndex = 9;
            this.dgvregStudent.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvregStudent_RowPrePaint);
            this.dgvregStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvregStudent_MouseClick);
            this.dgvregStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvregStudent_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Admission Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telephone";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Joining Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Membership Expiry";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmailBt
            // 
            this.EmailBt.Location = new System.Drawing.Point(292, 170);
            this.EmailBt.Name = "EmailBt";
            this.EmailBt.Size = new System.Drawing.Size(75, 23);
            this.EmailBt.TabIndex = 10;
            this.EmailBt.Text = "Email";
            this.EmailBt.UseSelectable = true;
            this.EmailBt.Click += new System.EventHandler(this.EmailBt_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(23, 170);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseSelectable = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 377);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.EmailBt);
            this.Controls.Add(this.dgvregStudent);
            this.Controls.Add(this.RegStd);
            this.Controls.Add(this.deleteregstud);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterStudent";
            this.Text = "RegisterStudent";
            this.Load += new System.EventHandler(this.RegisterStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox admisNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox gender;
        private MetroFramework.Controls.MetroTextBox fname;
        private MetroFramework.Controls.MetroTextBox tphone;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroDateTime dtpexpiry;
        private MetroFramework.Controls.MetroDateTime dtpjoin;
        private MetroFramework.Controls.MetroButton RegStd;
        private MetroFramework.Controls.MetroButton deleteregstud;
        private MetroFramework.Controls.MetroGrid dgvregStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton EmailBt;
        private MetroFramework.Controls.MetroButton Clear;
    }
}