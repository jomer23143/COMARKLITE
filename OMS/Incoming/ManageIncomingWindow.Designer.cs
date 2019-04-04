namespace OMS.Incoming
{
    partial class ManageIncomingWindow
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
            this.headerGrid = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colshipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWrrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldocumentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorizedShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colincomingtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colissue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerGrid
            // 
            this.headerGrid.AllowUserToAddRows = false;
            this.headerGrid.AllowUserToDeleteRows = false;
            this.headerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.headerGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.headerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colshipID,
            this.colWrrNo,
            this.colwarehouse,
            this.colDatetime,
            this.coldocumentReference,
            this.colClient,
            this.colNr,
            this.colAuthorizedShipper,
            this.colRemarks,
            this.colincomingtype,
            this.colReceivedon,
            this.colStatus,
            this.coldocumentDate,
            this.colCustname,
            this.colissue,
            this.colDateI,
            this.colPick,
            this.colDateP,
            this.colTypeStocks,
            this.colReceived,
            this.colShipped});
            this.headerGrid.EnableHeadersVisualStyles = false;
            this.headerGrid.Location = new System.Drawing.Point(13, 64);
            this.headerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.headerGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.headerGrid.RowTemplate.Height = 35;
            this.headerGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.headerGrid.Size = new System.Drawing.Size(959, 494);
            this.headerGrid.TabIndex = 24;
            this.headerGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.headerGrid_RowPrePaint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(16, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 53);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(147, 7);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 53);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(57, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 15);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(666, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 31);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search :";
            // 
            // colshipID
            // 
            this.colshipID.DataPropertyName = "shipment_id";
            this.colshipID.HeaderText = "Shipment ID";
            this.colshipID.Name = "colshipID";
            this.colshipID.ReadOnly = true;
            this.colshipID.Width = 106;
            // 
            // colWrrNo
            // 
            this.colWrrNo.DataPropertyName = "wrrNo";
            this.colWrrNo.HeaderText = "WRR NO";
            this.colWrrNo.Name = "colWrrNo";
            this.colWrrNo.ReadOnly = true;
            this.colWrrNo.Width = 92;
            // 
            // colwarehouse
            // 
            this.colwarehouse.DataPropertyName = "warehouse";
            this.colwarehouse.HeaderText = "Warehouse";
            this.colwarehouse.Name = "colwarehouse";
            this.colwarehouse.ReadOnly = true;
            this.colwarehouse.Width = 96;
            // 
            // colDatetime
            // 
            this.colDatetime.DataPropertyName = "datetime";
            this.colDatetime.HeaderText = "Date and Time";
            this.colDatetime.Name = "colDatetime";
            this.colDatetime.ReadOnly = true;
            this.colDatetime.Width = 115;
            // 
            // coldocumentReference
            // 
            this.coldocumentReference.DataPropertyName = "document_reference";
            this.coldocumentReference.HeaderText = "Document Reference";
            this.coldocumentReference.Name = "coldocumentReference";
            this.coldocumentReference.ReadOnly = true;
            this.coldocumentReference.Width = 133;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 73;
            // 
            // colNr
            // 
            this.colNr.DataPropertyName = "Nr";
            this.colNr.HeaderText = "Ref Nr.";
            this.colNr.Name = "colNr";
            this.colNr.ReadOnly = true;
            this.colNr.Width = 61;
            // 
            // colAuthorizedShipper
            // 
            this.colAuthorizedShipper.DataPropertyName = "authorized_shipper";
            this.colAuthorizedShipper.HeaderText = "Authorized Shipper";
            this.colAuthorizedShipper.Name = "colAuthorizedShipper";
            this.colAuthorizedShipper.ReadOnly = true;
            this.colAuthorizedShipper.Width = 129;
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "remarks";
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            this.colRemarks.Width = 86;
            // 
            // colincomingtype
            // 
            this.colincomingtype.DataPropertyName = "incoming_type";
            this.colincomingtype.HeaderText = "Incoming Type";
            this.colincomingtype.Name = "colincomingtype";
            this.colincomingtype.ReadOnly = true;
            this.colincomingtype.Width = 108;
            // 
            // colReceivedon
            // 
            this.colReceivedon.DataPropertyName = "received_on";
            this.colReceivedon.HeaderText = "Received On";
            this.colReceivedon.Name = "colReceivedon";
            this.colReceivedon.ReadOnly = true;
            this.colReceivedon.Width = 98;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 74;
            // 
            // coldocumentDate
            // 
            this.coldocumentDate.DataPropertyName = "document_reference_date";
            this.coldocumentDate.HeaderText = "Document Reference Date";
            this.coldocumentDate.Name = "coldocumentDate";
            this.coldocumentDate.ReadOnly = true;
            this.coldocumentDate.Width = 135;
            // 
            // colCustname
            // 
            this.colCustname.DataPropertyName = "custName";
            this.colCustname.HeaderText = "Receiving";
            this.colCustname.Name = "colCustname";
            this.colCustname.ReadOnly = true;
            this.colCustname.Width = 90;
            // 
            // colissue
            // 
            this.colissue.DataPropertyName = "issued";
            this.colissue.HeaderText = "Issued";
            this.colissue.Name = "colissue";
            this.colissue.ReadOnly = true;
            this.colissue.Width = 75;
            // 
            // colDateI
            // 
            this.colDateI.DataPropertyName = "dateIssued";
            this.colDateI.HeaderText = "Date Issued";
            this.colDateI.Name = "colDateI";
            this.colDateI.ReadOnly = true;
            this.colDateI.Width = 94;
            // 
            // colPick
            // 
            this.colPick.DataPropertyName = "pickUp";
            this.colPick.HeaderText = "Picked Up";
            this.colPick.Name = "colPick";
            this.colPick.ReadOnly = true;
            this.colPick.Width = 89;
            // 
            // colDateP
            // 
            this.colDateP.DataPropertyName = "datePick";
            this.colDateP.HeaderText = "Date Picked Up";
            this.colDateP.Name = "colDateP";
            this.colDateP.ReadOnly = true;
            this.colDateP.Width = 98;
            // 
            // colTypeStocks
            // 
            this.colTypeStocks.DataPropertyName = "typeStocks";
            this.colTypeStocks.HeaderText = "Type of Stocks";
            this.colTypeStocks.Name = "colTypeStocks";
            this.colTypeStocks.ReadOnly = true;
            this.colTypeStocks.Width = 109;
            // 
            // colReceived
            // 
            this.colReceived.DataPropertyName = "received";
            this.colReceived.HeaderText = "Received";
            this.colReceived.Name = "colReceived";
            this.colReceived.ReadOnly = true;
            this.colReceived.Width = 87;
            // 
            // colShipped
            // 
            this.colShipped.DataPropertyName = "shippedVia";
            this.colShipped.HeaderText = "Shipped Via";
            this.colShipped.Name = "colShipped";
            this.colShipped.ReadOnly = true;
            this.colShipped.Width = 95;
            // 
            // ManageIncomingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(985, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.headerGrid);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageIncomingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Incoming Windows";
            this.Load += new System.EventHandler(this.ManageIncomingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView headerGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWrrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldocumentReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorizedShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colincomingtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldocumentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colissue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPick;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipped;
    }
}