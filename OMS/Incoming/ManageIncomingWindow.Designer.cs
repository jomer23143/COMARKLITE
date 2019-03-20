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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerGrid = new System.Windows.Forms.DataGridView();
            this.colshipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWrrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldocumentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.headerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colshipID,
            this.colWrrNo,
            this.colwarehouse,
            this.colDatetime,
            this.coldocumentReference,
            this.colClient,
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
            this.headerGrid.Location = new System.Drawing.Point(11, 58);
            this.headerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.headerGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.headerGrid.RowTemplate.Height = 35;
            this.headerGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.headerGrid.Size = new System.Drawing.Size(822, 428);
            this.headerGrid.TabIndex = 24;
            this.headerGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.headerGrid_RowPrePaint);
            // 
            // colshipID
            // 
            this.colshipID.DataPropertyName = "shipment_id";
            this.colshipID.HeaderText = "Shipment ID";
            this.colshipID.Name = "colshipID";
            this.colshipID.ReadOnly = true;
            this.colshipID.Width = 117;
            // 
            // colWrrNo
            // 
            this.colWrrNo.DataPropertyName = "wrrNo";
            this.colWrrNo.HeaderText = "WRR NO";
            this.colWrrNo.Name = "colWrrNo";
            this.colWrrNo.ReadOnly = true;
            // 
            // colwarehouse
            // 
            this.colwarehouse.DataPropertyName = "warehouse";
            this.colwarehouse.HeaderText = "Warehouse";
            this.colwarehouse.Name = "colwarehouse";
            this.colwarehouse.ReadOnly = true;
            this.colwarehouse.Width = 118;
            // 
            // colDatetime
            // 
            this.colDatetime.DataPropertyName = "datetime";
            this.colDatetime.HeaderText = "Date and Time";
            this.colDatetime.Name = "colDatetime";
            this.colDatetime.ReadOnly = true;
            this.colDatetime.Width = 130;
            // 
            // coldocumentReference
            // 
            this.coldocumentReference.DataPropertyName = "document_reference";
            this.coldocumentReference.HeaderText = "Document Reference";
            this.coldocumentReference.Name = "coldocumentReference";
            this.coldocumentReference.ReadOnly = true;
            this.coldocumentReference.Width = 169;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 85;
            // 
            // colAuthorizedShipper
            // 
            this.colAuthorizedShipper.DataPropertyName = "authorized_shipper";
            this.colAuthorizedShipper.HeaderText = "Authorized Shipper";
            this.colAuthorizedShipper.Name = "colAuthorizedShipper";
            this.colAuthorizedShipper.ReadOnly = true;
            this.colAuthorizedShipper.Width = 157;
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "remarks";
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            this.colRemarks.Width = 105;
            // 
            // colincomingtype
            // 
            this.colincomingtype.DataPropertyName = "incoming_type";
            this.colincomingtype.HeaderText = "Incoming Type";
            this.colincomingtype.Name = "colincomingtype";
            this.colincomingtype.ReadOnly = true;
            this.colincomingtype.Width = 131;
            // 
            // colReceivedon
            // 
            this.colReceivedon.DataPropertyName = "received_on";
            this.colReceivedon.HeaderText = "Received On";
            this.colReceivedon.Name = "colReceivedon";
            this.colReceivedon.ReadOnly = true;
            this.colReceivedon.Width = 121;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 85;
            // 
            // coldocumentDate
            // 
            this.coldocumentDate.DataPropertyName = "document_reference_date";
            this.coldocumentDate.HeaderText = "Document Reference Date";
            this.coldocumentDate.Name = "coldocumentDate";
            this.coldocumentDate.ReadOnly = true;
            this.coldocumentDate.Width = 172;
            // 
            // colCustname
            // 
            this.colCustname.DataPropertyName = "custName";
            this.colCustname.HeaderText = "Receiving";
            this.colCustname.Name = "colCustname";
            this.colCustname.ReadOnly = true;
            this.colCustname.Width = 111;
            // 
            // colissue
            // 
            this.colissue.DataPropertyName = "issued";
            this.colissue.HeaderText = "Issued";
            this.colissue.Name = "colissue";
            this.colissue.ReadOnly = true;
            this.colissue.Width = 89;
            // 
            // colDateI
            // 
            this.colDateI.DataPropertyName = "dateIssued";
            this.colDateI.HeaderText = "Date Issued";
            this.colDateI.Name = "colDateI";
            this.colDateI.ReadOnly = true;
            this.colDateI.Width = 115;
            // 
            // colPick
            // 
            this.colPick.DataPropertyName = "pickUp";
            this.colPick.HeaderText = "Picked Up";
            this.colPick.Name = "colPick";
            this.colPick.ReadOnly = true;
            this.colPick.Width = 105;
            // 
            // colDateP
            // 
            this.colDateP.DataPropertyName = "datePick";
            this.colDateP.HeaderText = "Date Picked Up";
            this.colDateP.Name = "colDateP";
            this.colDateP.ReadOnly = true;
            this.colDateP.Width = 119;
            // 
            // colTypeStocks
            // 
            this.colTypeStocks.DataPropertyName = "typeStocks";
            this.colTypeStocks.HeaderText = "Type of Stocks";
            this.colTypeStocks.Name = "colTypeStocks";
            this.colTypeStocks.ReadOnly = true;
            this.colTypeStocks.Width = 130;
            // 
            // colReceived
            // 
            this.colReceived.DataPropertyName = "received";
            this.colReceived.HeaderText = "Received";
            this.colReceived.Name = "colReceived";
            this.colReceived.ReadOnly = true;
            this.colReceived.Width = 107;
            // 
            // colShipped
            // 
            this.colShipped.DataPropertyName = "shippedVia";
            this.colShipped.HeaderText = "Shipped Via";
            this.colShipped.Name = "colShipped";
            this.colShipped.ReadOnly = true;
            this.colShipped.Width = 112;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(26, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 46);
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
            this.btnNew.Location = new System.Drawing.Point(138, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 46);
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
            this.txtSearch.Location = new System.Drawing.Point(49, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 15);
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
            this.panel1.Location = new System.Drawing.Point(554, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 32);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search :";
            // 
            // ManageIncomingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.headerGrid);
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