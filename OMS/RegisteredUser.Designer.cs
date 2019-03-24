namespace ReportGeneratorPortal_v2
{
    partial class RegisteredUser
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
            this.grdUser = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridcolusername = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridcolaccount = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridcolstatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridcolindex = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cboauthlevel = new System.Windows.Forms.ComboBox();
            this.cbousertype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdUser
            // 
            this.grdUser.BackColor = System.Drawing.Color.White;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdUser.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdUser.ForeColor = System.Drawing.Color.Black;
            this.grdUser.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.grdUser.Location = new System.Drawing.Point(0, 0);
            this.grdUser.Name = "grdUser";
            // 
            // 
            // 
            this.grdUser.PrimaryGrid.Columns.Add(this.gridcolusername);
            this.grdUser.PrimaryGrid.Columns.Add(this.gridcolaccount);
            this.grdUser.PrimaryGrid.Columns.Add(this.gridcolstatus);
            this.grdUser.PrimaryGrid.Columns.Add(this.gridcolindex);
            this.grdUser.PrimaryGrid.EnableColumnFiltering = true;
            this.grdUser.PrimaryGrid.EnableFiltering = true;
            // 
            // 
            // 
            this.grdUser.PrimaryGrid.Filter.RowHeight = 30;
            this.grdUser.PrimaryGrid.Filter.Visible = true;
            this.grdUser.PrimaryGrid.UseAlternateColumnStyle = true;
            this.grdUser.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdUser.Size = new System.Drawing.Size(653, 239);
            this.grdUser.TabIndex = 8;
            this.grdUser.Text = "superGridControl1";
            // 
            // gridcolusername
            // 
            this.gridcolusername.HeaderText = "UserName";
            this.gridcolusername.Name = "gridcolusername";
            this.gridcolusername.Width = 300;
            // 
            // gridcolaccount
            // 
            this.gridcolaccount.HeaderText = "Account Type";
            this.gridcolaccount.Name = "gridcolaccount";
            this.gridcolaccount.Width = 200;
            // 
            // gridcolstatus
            // 
            this.gridcolstatus.HeaderText = "Status";
            this.gridcolstatus.Name = "gridcolstatus";
            // 
            // gridcolindex
            // 
            this.gridcolindex.HeaderText = "index";
            this.gridcolindex.Name = "gridcolindex";
            this.gridcolindex.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.cboauthlevel);
            this.panel1.Controls.Add(this.cbousertype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 107);
            this.panel1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(89, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(524, 72);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cboauthlevel
            // 
            this.cboauthlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboauthlevel.FormattingEnabled = true;
            this.Highlighter1.SetHighlightOnFocus(this.cboauthlevel, true);
            this.cboauthlevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboauthlevel.Location = new System.Drawing.Point(418, 44);
            this.cboauthlevel.Name = "cboauthlevel";
            this.cboauthlevel.Size = new System.Drawing.Size(39, 21);
            this.cboauthlevel.TabIndex = 5;
            // 
            // cbousertype
            // 
            this.cbousertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbousertype.FormattingEnabled = true;
            this.Highlighter1.SetHighlightOnFocus(this.cbousertype, true);
            this.cbousertype.Items.AddRange(new object[] {
            "ADMINISTRATOR",
            "OPERATION",
            "ACCOUNTING"});
            this.cbousertype.Location = new System.Drawing.Point(418, 19);
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(182, 21);
            this.cbousertype.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Authentication Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Type";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.Highlighter1.SetHighlightOnFocus(this.txtpassword, true);
            this.txtpassword.Location = new System.Drawing.Point(89, 45);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PreventEnterBeep = true;
            this.txtpassword.Size = new System.Drawing.Size(171, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusername.DisabledBackColor = System.Drawing.Color.White;
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.Highlighter1.SetHighlightOnFocus(this.txtusername, true);
            this.txtusername.Location = new System.Drawing.Point(89, 17);
            this.txtusername.Name = "txtusername";
            this.txtusername.PreventEnterBeep = true;
            this.txtusername.Size = new System.Drawing.Size(171, 20);
            this.txtusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // Highlighter1
            // 
            this.Highlighter1.ContainerControl = this;
            this.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            this.Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // RegisteredUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisteredUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registered New User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdUser;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridcolusername;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridcolaccount;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridcolstatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridcolindex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbousertype;
        private System.Windows.Forms.ComboBox cboauthlevel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBox1;
        internal DevComponents.DotNetBar.Validator.Highlighter Highlighter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}