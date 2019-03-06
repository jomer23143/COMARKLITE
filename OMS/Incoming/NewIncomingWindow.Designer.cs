namespace OMS.Incoming
{
    partial class NewIncomingWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShipper = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtIncomingType = new System.Windows.Forms.ComboBox();
            this.txtDocDate = new System.Windows.Forms.DateTimePicker();
            this.headerGrid = new System.Windows.Forms.DataGridView();
            this.colCode = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lot_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.txtWarehouse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtAddressS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtwrrNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtAddressR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtCodeR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtCodeS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtShipped = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtTypeStocks = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ref Document :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Document Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incoming Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Received :";
            // 
            // txtShipper
            // 
            this.txtShipper.BackColor = System.Drawing.Color.White;
            this.txtShipper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipper.Location = new System.Drawing.Point(60, 12);
            this.txtShipper.Margin = new System.Windows.Forms.Padding(2);
            this.txtShipper.Name = "txtShipper";
            this.txtShipper.Size = new System.Drawing.Size(141, 15);
            this.txtShipper.TabIndex = 0;
            // 
            // txtReference
            // 
            this.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(83, 11);
            this.txtReference.Margin = new System.Windows.Forms.Padding(2);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(86, 15);
            this.txtReference.TabIndex = 5;
            // 
            // txtReceived
            // 
            this.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.Location = new System.Drawing.Point(69, 11);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(208, 15);
            this.txtReceived.TabIndex = 11;
            // 
            // txtIncomingType
            // 
            this.txtIncomingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIncomingType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtIncomingType.FormattingEnabled = true;
            this.txtIncomingType.Items.AddRange(new object[] {
            "Replenishment",
            "Return from Trade",
            "Return from Delivery",
            "Stock Transfer"});
            this.txtIncomingType.Location = new System.Drawing.Point(85, 8);
            this.txtIncomingType.Margin = new System.Windows.Forms.Padding(2);
            this.txtIncomingType.Name = "txtIncomingType";
            this.txtIncomingType.Size = new System.Drawing.Size(125, 21);
            this.txtIncomingType.TabIndex = 9;
            // 
            // txtDocDate
            // 
            this.txtDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDocDate.Location = new System.Drawing.Point(93, 10);
            this.txtDocDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocDate.Name = "txtDocDate";
            this.txtDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocDate.Size = new System.Drawing.Size(117, 20);
            this.txtDocDate.TabIndex = 4;
            // 
            // headerGrid
            // 
            this.headerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.headerGrid.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.headerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.uom,
            this.lot_no,
            this.expiry,
            this.qty});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.headerGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.headerGrid.Location = new System.Drawing.Point(21, 234);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.headerGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.headerGrid.RowTemplate.Height = 28;
            this.headerGrid.Size = new System.Drawing.Size(807, 195);
            this.headerGrid.TabIndex = 12;
            this.headerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.headerGrid_CellContentClick);
            this.headerGrid.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.headerGrid_CellStyleChanged);
            this.headerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.headerGrid_CellValueChanged);
            this.headerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.headerGrid_KeyDown);
            // 
            // colCode
            // 
            this.colCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.colCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.colCode.DisplayMember = "Text";
            this.colCode.DropDownHeight = 106;
            this.colCode.DropDownWidth = 121;
            this.colCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCode.HeaderText = "Product";
            this.colCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCode.IntegralHeight = false;
            this.colCode.ItemHeight = 15;
            this.colCode.Name = "colCode";
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 300;
            // 
            // uom
            // 
            this.uom.HeaderText = "Uom";
            this.uom.Items.AddRange(new object[] {
            "PCS",
            "CASES"});
            this.uom.Name = "uom";
            this.uom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uom.Width = 70;
            // 
            // lot_no
            // 
            this.lot_no.HeaderText = "Lot No.";
            this.lot_no.Name = "lot_no";
            this.lot_no.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lot_no.Width = 70;
            // 
            // expiry
            // 
            // 
            // 
            // 
            this.expiry.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.expiry.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.expiry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.expiry.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.expiry.HeaderText = "Expiry";
            this.expiry.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.expiry.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.expiry.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.expiry.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.expiry.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.expiry.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.expiry.Name = "expiry";
            this.expiry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.expiry.Width = 70;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 70;
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(18, 434);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 13;
            this.btnDeclare.Text = "Declare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouse.FormattingEnabled = true;
            this.txtWarehouse.Location = new System.Drawing.Point(74, 7);
            this.txtWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(125, 24);
            this.txtWarehouse.TabIndex = 8;
            this.txtWarehouse.SelectedValueChanged += new System.EventHandler(this.txtWarehouse_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Warehouse :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtShipper);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 38);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtReference);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(246, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 38);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDocDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 38);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtIncomingType);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(439, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 38);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtReceived);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(21, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 38);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtWarehouse);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(439, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 38);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtClient);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(664, 143);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 38);
            this.panel7.TabIndex = 10;
            // 
            // txtClient
            // 
            this.txtClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtClient.FormattingEnabled = true;
            this.txtClient.Items.AddRange(new object[] {
            "Comark"});
            this.txtClient.Location = new System.Drawing.Point(52, 9);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(106, 21);
            this.txtClient.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Client :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtAddressS);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(21, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(405, 38);
            this.panel8.TabIndex = 3;
            // 
            // txtAddressS
            // 
            this.txtAddressS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressS.Location = new System.Drawing.Point(69, 11);
            this.txtAddressS.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressS.Name = "txtAddressS";
            this.txtAddressS.Size = new System.Drawing.Size(325, 15);
            this.txtAddressS.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address :";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtwrrNo);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(21, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(219, 38);
            this.panel9.TabIndex = 0;
            // 
            // txtwrrNo
            // 
            this.txtwrrNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtwrrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwrrNo.Location = new System.Drawing.Point(69, 11);
            this.txtwrrNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtwrrNo.Name = "txtwrrNo";
            this.txtwrrNo.Size = new System.Drawing.Size(128, 15);
            this.txtwrrNo.TabIndex = 0;
            this.txtwrrNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtwrrNo_KeyDown);
            this.txtwrrNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtwrrNo_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "WRR No. :";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtAddressR);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(439, 101);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(390, 38);
            this.panel10.TabIndex = 37;
            // 
            // txtAddressR
            // 
            this.txtAddressR.AutoSize = true;
            this.txtAddressR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressR.Location = new System.Drawing.Point(61, 11);
            this.txtAddressR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAddressR.Name = "txtAddressR";
            this.txtAddressR.Size = new System.Drawing.Size(0, 16);
            this.txtAddressR.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Address :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtCodeR);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(649, 54);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(180, 38);
            this.panel11.TabIndex = 36;
            // 
            // txtCodeR
            // 
            this.txtCodeR.AutoSize = true;
            this.txtCodeR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeR.Location = new System.Drawing.Point(76, 11);
            this.txtCodeR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCodeR.Name = "txtCodeR";
            this.txtCodeR.Size = new System.Drawing.Size(0, 16);
            this.txtCodeR.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Whse Code :";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtCodeS);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(246, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(180, 38);
            this.panel12.TabIndex = 2;
            // 
            // txtCodeS
            // 
            this.txtCodeS.BackColor = System.Drawing.Color.White;
            this.txtCodeS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeS.Location = new System.Drawing.Point(69, 11);
            this.txtCodeS.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeS.Name = "txtCodeS";
            this.txtCodeS.Size = new System.Drawing.Size(100, 15);
            this.txtCodeS.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Whse Code :";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtShipped);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(439, 188);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(390, 38);
            this.panel13.TabIndex = 11;
            // 
            // txtShipped
            // 
            this.txtShipped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipped.Location = new System.Drawing.Point(79, 11);
            this.txtShipped.Margin = new System.Windows.Forms.Padding(2);
            this.txtShipped.Name = "txtShipped";
            this.txtShipped.Size = new System.Drawing.Size(304, 15);
            this.txtShipped.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Shipped Via :";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtTypeStocks);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Location = new System.Drawing.Point(439, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(219, 38);
            this.panel14.TabIndex = 7;
            // 
            // txtTypeStocks
            // 
            this.txtTypeStocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTypeStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeStocks.FormattingEnabled = true;
            this.txtTypeStocks.Items.AddRange(new object[] {
            "GOOD STOCKS",
            "DAMAGE STOCKS"});
            this.txtTypeStocks.Location = new System.Drawing.Point(85, 6);
            this.txtTypeStocks.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeStocks.Name = "txtTypeStocks";
            this.txtTypeStocks.Size = new System.Drawing.Size(125, 24);
            this.txtTypeStocks.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Type of Stock :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewIncomingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 482);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.headerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewIncomingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incoming Window";
            this.Load += new System.EventHandler(this.NewIncomingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView headerGrid;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox txtClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtShipper;
        public System.Windows.Forms.TextBox txtReference;
        public System.Windows.Forms.TextBox txtReceived;
        public System.Windows.Forms.ComboBox txtIncomingType;
        public System.Windows.Forms.DateTimePicker txtDocDate;
        public System.Windows.Forms.ComboBox txtWarehouse;
        public System.Windows.Forms.TextBox txtAddressS;
        public System.Windows.Forms.TextBox txtwrrNo;
        public System.Windows.Forms.TextBox txtCodeS;
        public System.Windows.Forms.TextBox txtShipped;
        public System.Windows.Forms.ComboBox txtTypeStocks;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label txtCodeR;
        public System.Windows.Forms.Label txtAddressR;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_no;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
    }
}