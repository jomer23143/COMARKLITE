﻿namespace OMS.Outgoing
{
    partial class SalerProcessing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCode = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQuantity = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.colPrice = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.colAmount = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtAmountD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtWarehouse = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalA = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxpriceType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTypeStock = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTerrCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxWarehouse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPoNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoldTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesInvoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.colUnit,
            this.colQuantity,
            this.colPrice,
            this.colAmount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 185);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // colCode
            // 
            this.colCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.colCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.colCode.DisplayMember = "Text";
            this.colCode.DropDownHeight = 106;
            this.colCode.DropDownWidth = 121;
            this.colCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCode.HeaderText = "Product Code";
            this.colCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCode.IntegralHeight = false;
            this.colCode.ItemHeight = 15;
            this.colCode.Name = "colCode";
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colCode.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 200;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Items.AddRange(new object[] {
            "PCS",
            "CASES"});
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colQuantity
            // 
            // 
            // 
            // 
            this.colQuantity.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colQuantity.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuantity.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle9;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPrice
            // 
            // 
            // 
            // 
            this.colPrice.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colPrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPrice.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPrice.DisplayFormat = "0.00";
            this.colPrice.HeaderText = "U-Price";
            this.colPrice.Increment = 1D;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAmount
            // 
            // 
            // 
            // 
            this.colAmount.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colAmount.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAmount.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAmount.DisplayFormat = "0.00";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Increment = 1D;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtAmountD);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Location = new System.Drawing.Point(589, 477);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(234, 38);
            this.panel14.TabIndex = 45;
            // 
            // txtAmountD
            // 
            this.txtAmountD.BackColor = System.Drawing.Color.White;
            this.txtAmountD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountD.Location = new System.Drawing.Point(104, 12);
            this.txtAmountD.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountD.Name = "txtAmountD";
            this.txtAmountD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmountD.Size = new System.Drawing.Size(110, 13);
            this.txtAmountD.TabIndex = 5;
            this.txtAmountD.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Amount Due: ";
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(710, 520);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 2;
            this.btnDeclare.Text = "Declare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.txtWarehouse);
            this.panel16.Controls.Add(this.label16);
            this.panel16.Location = new System.Drawing.Point(882, 179);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(211, 38);
            this.panel16.TabIndex = 9;
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtWarehouse.FormattingEnabled = true;
            this.txtWarehouse.Location = new System.Drawing.Point(63, 14);
            this.txtWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(137, 21);
            this.txtWarehouse.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 1);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Warehouse :";
            // 
            // txtTotalA
            // 
            this.txtTotalA.AutoSize = true;
            this.txtTotalA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalA.Location = new System.Drawing.Point(23, 7);
            this.txtTotalA.Name = "txtTotalA";
            this.txtTotalA.Size = new System.Drawing.Size(113, 15);
            this.txtTotalA.TabIndex = 52;
            this.txtTotalA.Text = "Total Amount :  0.00";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(45, 28);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(89, 15);
            this.txtDiscount.TabIndex = 53;
            this.txtDiscount.Text = "Discount :  0.00";
            // 
            // txtVat
            // 
            this.txtVat.AutoSize = true;
            this.txtVat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(68, 50);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(63, 15);
            this.txtVat.TabIndex = 54;
            this.txtVat.Text = "VAT :  0.00";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.txtTotalA);
            this.panel17.Controls.Add(this.txtVat);
            this.panel17.Controls.Add(this.txtDiscount);
            this.panel17.Location = new System.Drawing.Point(591, 397);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(231, 74);
            this.panel17.TabIndex = 55;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxpriceType
            // 
            this.cbxpriceType.FormattingEnabled = true;
            this.cbxpriceType.Location = new System.Drawing.Point(104, 140);
            this.cbxpriceType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxpriceType.Name = "cbxpriceType";
            this.cbxpriceType.Size = new System.Drawing.Size(119, 23);
            this.cbxpriceType.TabIndex = 4;
            this.cbxpriceType.SelectedValueChanged += new System.EventHandler(this.cbxpriceType_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 144);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Price Type :";
            // 
            // txtTypeStock
            // 
            this.txtTypeStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTypeStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTypeStock.BackColor = System.Drawing.Color.White;
            this.txtTypeStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeStock.FormattingEnabled = true;
            this.txtTypeStock.Items.AddRange(new object[] {
            "GOOD STOCKS",
            "DAMAGE STOCKS"});
            this.txtTypeStock.Location = new System.Drawing.Point(332, 143);
            this.txtTypeStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeStock.Name = "txtTypeStock";
            this.txtTypeStock.Size = new System.Drawing.Size(129, 23);
            this.txtTypeStock.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(241, 147);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Type of Stock :";
            // 
            // txtTerrCode
            // 
            this.txtTerrCode.BackColor = System.Drawing.Color.White;
            this.txtTerrCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerrCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerrCode.Location = new System.Drawing.Point(332, 112);
            this.txtTerrCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtTerrCode.Name = "txtTerrCode";
            this.txtTerrCode.Size = new System.Drawing.Size(129, 19);
            this.txtTerrCode.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(262, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Terr Code :";
            // 
            // cbxWarehouse
            // 
            this.cbxWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxWarehouse.FormattingEnabled = true;
            this.cbxWarehouse.Location = new System.Drawing.Point(104, 107);
            this.cbxWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.cbxWarehouse.Name = "cbxWarehouse";
            this.cbxWarehouse.Size = new System.Drawing.Size(120, 23);
            this.cbxWarehouse.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "WHSE CODE :";
            // 
            // txtSR
            // 
            this.txtSR.BackColor = System.Drawing.Color.White;
            this.txtSR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSR.Location = new System.Drawing.Point(332, 83);
            this.txtSR.Margin = new System.Windows.Forms.Padding(10);
            this.txtSR.Name = "txtSR";
            this.txtSR.Size = new System.Drawing.Size(127, 19);
            this.txtSR.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "SR :";
            // 
            // txtPoNo
            // 
            this.txtPoNo.BackColor = System.Drawing.Color.White;
            this.txtPoNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoNo.Location = new System.Drawing.Point(105, 80);
            this.txtPoNo.Margin = new System.Windows.Forms.Padding(10);
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Size = new System.Drawing.Size(117, 18);
            this.txtPoNo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "P.O. NO. :";
            // 
            // txtTerms
            // 
            this.txtTerms.BackColor = System.Drawing.Color.White;
            this.txtTerms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerms.Location = new System.Drawing.Point(331, 53);
            this.txtTerms.Margin = new System.Windows.Forms.Padding(10);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(128, 19);
            this.txtTerms.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Terms :";
            // 
            // txtSoNo
            // 
            this.txtSoNo.BackColor = System.Drawing.Color.White;
            this.txtSoNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNo.Location = new System.Drawing.Point(105, 51);
            this.txtSoNo.Margin = new System.Windows.Forms.Padding(10);
            this.txtSoNo.Name = "txtSoNo";
            this.txtSoNo.Size = new System.Drawing.Size(116, 18);
            this.txtSoNo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "S.O NO. :";
            // 
            // txtInstruction
            // 
            this.txtInstruction.BackColor = System.Drawing.Color.White;
            this.txtInstruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstruction.Location = new System.Drawing.Point(485, 147);
            this.txtInstruction.Margin = new System.Windows.Forms.Padding(10);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(280, 15);
            this.txtInstruction.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Delivery/Shipping Instruction :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tin # :";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.AutoSize = true;
            this.txtCustAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(575, 78);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(0, 15);
            this.txtCustAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address :";
            // 
            // txtCustNo
            // 
            this.txtCustNo.AutoSize = true;
            this.txtCustNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNo.Location = new System.Drawing.Point(573, 50);
            this.txtCustNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(0, 15);
            this.txtCustNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer No. :";
            // 
            // txtSoldTo
            // 
            this.txtSoldTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSoldTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSoldTo.FormattingEnabled = true;
            this.txtSoldTo.Location = new System.Drawing.Point(573, 20);
            this.txtSoldTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoldTo.Name = "txtSoldTo";
            this.txtSoldTo.Size = new System.Drawing.Size(192, 23);
            this.txtSoldTo.TabIndex = 10;
            this.txtSoldTo.SelectedValueChanged += new System.EventHandler(this.txtSoldTo_SelectedValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sold To :";
            // 
            // txtDateS
            // 
            this.txtDateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateS.Location = new System.Drawing.Point(331, 20);
            this.txtDateS.Name = "txtDateS";
            this.txtDateS.Size = new System.Drawing.Size(128, 22);
            this.txtDateS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // txtSalesInvoice
            // 
            this.txtSalesInvoice.BackColor = System.Drawing.Color.White;
            this.txtSalesInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesInvoice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesInvoice.Location = new System.Drawing.Point(105, 23);
            this.txtSalesInvoice.Margin = new System.Windows.Forms.Padding(10);
            this.txtSalesInvoice.Name = "txtSalesInvoice";
            this.txtSalesInvoice.Size = new System.Drawing.Size(117, 18);
            this.txtSalesInvoice.TabIndex = 0;
            this.txtSalesInvoice.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalesInvoice_Validating_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sales Invoice :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtTin);
            this.groupBox1.Controls.Add(this.txtInstruction);
            this.groupBox1.Controls.Add(this.txtTypeStock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCustAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCustNo);
            this.groupBox1.Controls.Add(this.txtSoldTo);
            this.groupBox1.Controls.Add(this.txtTerrCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSR);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTerms);
            this.groupBox1.Controls.Add(this.txtDateS);
            this.groupBox1.Controls.Add(this.cbxpriceType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxWarehouse);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtPoNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSoNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSalesInvoice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 183);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTin
            // 
            this.txtTin.AutoSize = true;
            this.txtTin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.Location = new System.Drawing.Point(572, 106);
            this.txtTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTin.Name = "txtTin";
            this.txtTin.Size = new System.Drawing.Size(0, 15);
            this.txtTin.TabIndex = 12;
            // 
            // SalerProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalerProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.SalerProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox txtWarehouse;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.TextBox txtAmountD;
        public System.Windows.Forms.Label txtTotalA;
        public System.Windows.Forms.Label txtDiscount;
        public System.Windows.Forms.Label txtVat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSoNo;
        public System.Windows.Forms.TextBox txtSalesInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxpriceType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox txtTypeStock;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtTerrCode;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cbxWarehouse;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSR;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPoNo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label txtCustAddress;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label txtCustNo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtSoldTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDateS;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colQuantity;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colPrice;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colAmount;
        public System.Windows.Forms.Label txtTin;
    }
}