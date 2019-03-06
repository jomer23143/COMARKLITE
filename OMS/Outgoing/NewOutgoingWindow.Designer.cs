namespace OMS.Outgoing
{
    partial class NewOutgoingWindow
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
            this.btnDeclare = new System.Windows.Forms.Button();
            this.headerGrid = new System.Windows.Forms.DataGridView();
            this.product = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocDate = new System.Windows.Forms.DateTimePicker();
            this.txOutgoingType = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransportProvider = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWarehouse = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtClient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(25, 485);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 37;
            this.btnDeclare.Text = "Declare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // headerGrid
            // 
            this.headerGrid.AllowUserToDeleteRows = false;
            this.headerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.headerGrid.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.headerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.colDescription,
            this.uom,
            this.qty});
            this.headerGrid.Location = new System.Drawing.Point(25, 259);
            this.headerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.headerGrid.Name = "headerGrid";
            this.headerGrid.RowTemplate.Height = 28;
            this.headerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.headerGrid.Size = new System.Drawing.Size(550, 217);
            this.headerGrid.TabIndex = 36;
            this.headerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.headerGrid_CellValueChanged);
            // 
            // product
            // 
            this.product.DisplayMember = "Text";
            this.product.DropDownHeight = 106;
            this.product.DropDownWidth = 121;
            this.product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product.Frozen = true;
            this.product.HeaderText = "Product";
            this.product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.product.IntegralHeight = false;
            this.product.ItemHeight = 20;
            this.product.Name = "product";
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 250;
            // 
            // uom
            // 
            this.uom.HeaderText = "Uom";
            this.uom.Items.AddRange(new object[] {
            "PIECES",
            "CASES"});
            this.uom.Name = "uom";
            this.uom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uom.Width = 80;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 80;
            // 
            // txtDocDate
            // 
            this.txtDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDocDate.Location = new System.Drawing.Point(100, 8);
            this.txtDocDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocDate.Name = "txtDocDate";
            this.txtDocDate.Size = new System.Drawing.Size(124, 20);
            this.txtDocDate.TabIndex = 35;
            // 
            // txOutgoingType
            // 
            this.txOutgoingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txOutgoingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txOutgoingType.FormattingEnabled = true;
            this.txOutgoingType.Items.AddRange(new object[] {
            "Sale Order",
            "Delivery Order",
            "Stock Transfer",
            "Pickup",
            "Disposal"});
            this.txOutgoingType.Location = new System.Drawing.Point(97, 8);
            this.txOutgoingType.Margin = new System.Windows.Forms.Padding(2);
            this.txOutgoingType.Name = "txOutgoingType";
            this.txOutgoingType.Size = new System.Drawing.Size(125, 21);
            this.txOutgoingType.TabIndex = 34;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemarks.Location = new System.Drawing.Point(77, 13);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(188, 13);
            this.txtRemarks.TabIndex = 33;
            // 
            // txtReference
            // 
            this.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReference.Location = new System.Drawing.Point(134, 12);
            this.txtReference.Margin = new System.Windows.Forms.Padding(2);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(133, 13);
            this.txtReference.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Remarks :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Outgoing Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Document Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reference Document :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer :";
            // 
            // txtTransportProvider
            // 
            this.txtTransportProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTransportProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTransportProvider.FormattingEnabled = true;
            this.txtTransportProvider.Location = new System.Drawing.Point(108, 9);
            this.txtTransportProvider.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransportProvider.Name = "txtTransportProvider";
            this.txtTransportProvider.Size = new System.Drawing.Size(125, 21);
            this.txtTransportProvider.TabIndex = 41;
            this.txtTransportProvider.SelectedIndexChanged += new System.EventHandler(this.txtTransportProvider_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Transport Provider :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Warehouse :";
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtWarehouse.FormattingEnabled = true;
            this.txtWarehouse.Location = new System.Drawing.Point(93, 9);
            this.txtWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(140, 21);
            this.txtWarehouse.TabIndex = 43;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.Location = new System.Drawing.Point(70, 9);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(125, 21);
            this.txtCustomer.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtReference);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 38);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDocDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(25, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 38);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txOutgoingType);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(25, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 38);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtCustomer);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(25, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 38);
            this.panel4.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtRemarks);
            this.panel5.Location = new System.Drawing.Point(25, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 38);
            this.panel5.TabIndex = 51;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtTransportProvider);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(324, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 38);
            this.panel6.TabIndex = 52;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtWarehouse);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(324, 116);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 38);
            this.panel7.TabIndex = 53;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtClient);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(324, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 38);
            this.panel8.TabIndex = 54;
            // 
            // txtClient
            // 
            this.txtClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtClient.FormattingEnabled = true;
            this.txtClient.Items.AddRange(new object[] {
            "Dong-a Abbot",
            "Dong-a Others",
            "Comark"});
            this.txtClient.Location = new System.Drawing.Point(52, 9);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(181, 21);
            this.txtClient.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Client :";
            // 
            // NewOutgoingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 534);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewOutgoingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOutgoingWindow";
            this.Load += new System.EventHandler(this.NewOutgoingWindow_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeclare;
        public System.Windows.Forms.DataGridView headerGrid;
        private System.Windows.Forms.DateTimePicker txtDocDate;
        private System.Windows.Forms.ComboBox txOutgoingType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTransportProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtWarehouse;
        private System.Windows.Forms.ComboBox txtCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox txtClient;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
    }
}