﻿namespace OMS.Outgoing
{
    partial class ManageOutgoingWindow
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.headerGrid = new System.Windows.Forms.DataGridView();
            this.coloutshipid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorizedtms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTripDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWmsReleasedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWmsReleasedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustInvoiceAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustDeliveryAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentReferenceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutgoingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSIntruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnNew.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(148, 26);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 46);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(23, 26);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 46);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // headerGrid
            // 
            this.headerGrid.AllowUserToAddRows = false;
            this.headerGrid.AllowUserToDeleteRows = false;
            this.headerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.headerGrid.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.headerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coloutshipid,
            this.colDocNo,
            this.colwarehouse,
            this.colDateTime,
            this.colDocumentReference,
            this.colClient,
            this.colAuthorizedtms,
            this.colRemarks,
            this.coltripID,
            this.colTripDate,
            this.colWmsReleasedID,
            this.colWmsReleasedDate,
            this.colCustID,
            this.colCustname,
            this.colCustInvoiceAddress,
            this.colCustDeliveryAddress,
            this.colStatus,
            this.colDocumentReferenceDate,
            this.colOutgoingType,
            this.colPoNo,
            this.colTerms,
            this.colSIntruction,
            this.colAmountd,
            this.colSr,
            this.colType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.headerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.headerGrid.Location = new System.Drawing.Point(25, 75);
            this.headerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.headerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.headerGrid.RowTemplate.Height = 28;
            this.headerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.headerGrid.Size = new System.Drawing.Size(815, 296);
            this.headerGrid.TabIndex = 28;
            this.headerGrid.VirtualMode = true;
            this.headerGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.headerGrid_CellValidating);
            this.headerGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.headerGrid_RowPrePaint);
            this.headerGrid.Validating += new System.ComponentModel.CancelEventHandler(this.headerGrid_Validating);
            // 
            // coloutshipid
            // 
            this.coloutshipid.DataPropertyName = "out_shipment_id";
            this.coloutshipid.HeaderText = "Out Shipment ID";
            this.coloutshipid.Name = "coloutshipid";
            this.coloutshipid.ReadOnly = true;
            this.coloutshipid.Width = 102;
            // 
            // colDocNo
            // 
            this.colDocNo.DataPropertyName = "docNo";
            this.colDocNo.HeaderText = "Doc No";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.ReadOnly = true;
            this.colDocNo.Width = 66;
            // 
            // colwarehouse
            // 
            this.colwarehouse.DataPropertyName = "warehouse";
            this.colwarehouse.HeaderText = "Warehouse";
            this.colwarehouse.Name = "colwarehouse";
            this.colwarehouse.ReadOnly = true;
            this.colwarehouse.Width = 94;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "datetime";
            this.colDateTime.HeaderText = "Date and Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 101;
            // 
            // colDocumentReference
            // 
            this.colDocumentReference.DataPropertyName = "document_reference";
            this.colDocumentReference.HeaderText = "Document Reference";
            this.colDocumentReference.Name = "colDocumentReference";
            this.colDocumentReference.ReadOnly = true;
            this.colDocumentReference.Width = 133;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 66;
            // 
            // colAuthorizedtms
            // 
            this.colAuthorizedtms.DataPropertyName = "authorized_tms";
            this.colAuthorizedtms.HeaderText = "Authorized Tms";
            this.colAuthorizedtms.Name = "colAuthorizedtms";
            this.colAuthorizedtms.ReadOnly = true;
            this.colAuthorizedtms.Width = 110;
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "remarks";
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            this.colRemarks.Width = 83;
            // 
            // coltripID
            // 
            this.coltripID.DataPropertyName = "tms_trip_id";
            this.coltripID.HeaderText = "Tms Trip ID";
            this.coltripID.Name = "coltripID";
            this.coltripID.ReadOnly = true;
            this.coltripID.Width = 78;
            // 
            // colTripDate
            // 
            this.colTripDate.DataPropertyName = "tms_trip_date";
            this.colTripDate.HeaderText = "Tms Trip Date";
            this.colTripDate.Name = "colTripDate";
            this.colTripDate.ReadOnly = true;
            this.colTripDate.Width = 101;
            // 
            // colWmsReleasedID
            // 
            this.colWmsReleasedID.DataPropertyName = "wms_released_id";
            this.colWmsReleasedID.HeaderText = "Wms Released ID";
            this.colWmsReleasedID.Name = "colWmsReleasedID";
            this.colWmsReleasedID.ReadOnly = true;
            this.colWmsReleasedID.Width = 106;
            // 
            // colWmsReleasedDate
            // 
            this.colWmsReleasedDate.DataPropertyName = "wms_release_date";
            this.colWmsReleasedDate.HeaderText = "Wms Released Date";
            this.colWmsReleasedDate.Name = "colWmsReleasedDate";
            this.colWmsReleasedDate.ReadOnly = true;
            this.colWmsReleasedDate.Width = 129;
            // 
            // colCustID
            // 
            this.colCustID.DataPropertyName = "customer_id";
            this.colCustID.HeaderText = "Customer ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.Width = 94;
            // 
            // colCustname
            // 
            this.colCustname.DataPropertyName = "customer_name";
            this.colCustname.HeaderText = "Customer Name";
            this.colCustname.Name = "colCustname";
            this.colCustname.ReadOnly = true;
            this.colCustname.Width = 110;
            // 
            // colCustInvoiceAddress
            // 
            this.colCustInvoiceAddress.DataPropertyName = "customer_invoice_address";
            this.colCustInvoiceAddress.HeaderText = "Customer Invoice Address";
            this.colCustInvoiceAddress.Name = "colCustInvoiceAddress";
            this.colCustInvoiceAddress.ReadOnly = true;
            this.colCustInvoiceAddress.Width = 119;
            // 
            // colCustDeliveryAddress
            // 
            this.colCustDeliveryAddress.DataPropertyName = "customer_delivery_address";
            this.colCustDeliveryAddress.HeaderText = "Customer Delivery Address";
            this.colCustDeliveryAddress.Name = "colCustDeliveryAddress";
            this.colCustDeliveryAddress.ReadOnly = true;
            this.colCustDeliveryAddress.Width = 126;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 67;
            // 
            // colDocumentReferenceDate
            // 
            this.colDocumentReferenceDate.DataPropertyName = "document_reference_date";
            this.colDocumentReferenceDate.HeaderText = "Document Reference Date";
            this.colDocumentReferenceDate.Name = "colDocumentReferenceDate";
            this.colDocumentReferenceDate.ReadOnly = true;
            this.colDocumentReferenceDate.Width = 136;
            // 
            // colOutgoingType
            // 
            this.colOutgoingType.DataPropertyName = "outgoing_type";
            this.colOutgoingType.HeaderText = "Outgoing Type";
            this.colOutgoingType.Name = "colOutgoingType";
            this.colOutgoingType.ReadOnly = true;
            this.colOutgoingType.Width = 103;
            // 
            // colPoNo
            // 
            this.colPoNo.DataPropertyName = "poNo";
            this.colPoNo.HeaderText = "PO No";
            this.colPoNo.Name = "colPoNo";
            this.colPoNo.ReadOnly = true;
            this.colPoNo.Width = 50;
            // 
            // colTerms
            // 
            this.colTerms.DataPropertyName = "terms";
            this.colTerms.HeaderText = "Terms";
            this.colTerms.Name = "colTerms";
            this.colTerms.ReadOnly = true;
            this.colTerms.Width = 67;
            // 
            // colSIntruction
            // 
            this.colSIntruction.DataPropertyName = "shippingInstruction";
            this.colSIntruction.HeaderText = "Shipment Instruction";
            this.colSIntruction.Name = "colSIntruction";
            this.colSIntruction.ReadOnly = true;
            this.colSIntruction.Width = 135;
            // 
            // colAmountd
            // 
            this.colAmountd.DataPropertyName = "amountD";
            this.colAmountd.HeaderText = "Amount Due";
            this.colAmountd.Name = "colAmountd";
            this.colAmountd.ReadOnly = true;
            this.colAmountd.Width = 92;
            // 
            // colSr
            // 
            this.colSr.DataPropertyName = "sr";
            this.colSr.HeaderText = "Sales Representative";
            this.colSr.Name = "colSr";
            this.colSr.ReadOnly = true;
            this.colSr.Width = 133;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "typeStocks";
            this.colType.HeaderText = "Type of Stocks";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 102;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(573, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 31);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(51, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 15);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ManageOutgoingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.headerGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageOutgoingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Outgoing Window";
            this.Load += new System.EventHandler(this.ManageOutgoingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView headerGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloutshipid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorizedtms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTripDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWmsReleasedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWmsReleasedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustInvoiceAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustDeliveryAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentReferenceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutgoingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSIntruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    }
}