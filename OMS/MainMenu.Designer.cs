namespace OMS
{
    partial class MainMenu
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
            this.btnDeclareIncoming = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recievingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTransferListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeclareIncoming
            // 
            this.btnDeclareIncoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclareIncoming.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclareIncoming.ForeColor = System.Drawing.Color.White;
            this.btnDeclareIncoming.Location = new System.Drawing.Point(131, 88);
            this.btnDeclareIncoming.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclareIncoming.Name = "btnDeclareIncoming";
            this.btnDeclareIncoming.Size = new System.Drawing.Size(119, 62);
            this.btnDeclareIncoming.TabIndex = 0;
            this.btnDeclareIncoming.Text = "Incoming ";
            this.btnDeclareIncoming.UseVisualStyleBackColor = false;
            this.btnDeclareIncoming.Click += new System.EventHandler(this.btnDeclareIncoming_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(272, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Outgoing (Orders)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recievingToolStripMenuItem,
            this.orderingToolStripMenuItem,
            this.transactionListToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12);
            this.menuStrip1.Size = new System.Drawing.Size(555, 51);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recievingToolStripMenuItem
            // 
            this.recievingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomingToolStripMenuItem,
            this.stockTransferToolStripMenuItem,
            this.returnsToolStripMenuItem});
            this.recievingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recievingToolStripMenuItem.Name = "recievingToolStripMenuItem";
            this.recievingToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.recievingToolStripMenuItem.Text = "Receiving";
            // 
            // incomingToolStripMenuItem
            // 
            this.incomingToolStripMenuItem.Name = "incomingToolStripMenuItem";
            this.incomingToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.incomingToolStripMenuItem.Text = "Incoming";
            this.incomingToolStripMenuItem.Click += new System.EventHandler(this.incomingToolStripMenuItem_Click);
            // 
            // stockTransferToolStripMenuItem
            // 
            this.stockTransferToolStripMenuItem.Name = "stockTransferToolStripMenuItem";
            this.stockTransferToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.stockTransferToolStripMenuItem.Text = "Stock Transfer";
            this.stockTransferToolStripMenuItem.Click += new System.EventHandler(this.stockTransferToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem
            // 
            this.returnsToolStripMenuItem.Name = "returnsToolStripMenuItem";
            this.returnsToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.returnsToolStripMenuItem.Text = "Returns";
            this.returnsToolStripMenuItem.Click += new System.EventHandler(this.returnsToolStripMenuItem_Click);
            // 
            // orderingToolStripMenuItem
            // 
            this.orderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOrderToolStripMenuItem,
            this.deliveryOrderToolStripMenuItem});
            this.orderingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orderingToolStripMenuItem.Name = "orderingToolStripMenuItem";
            this.orderingToolStripMenuItem.Size = new System.Drawing.Size(169, 27);
            this.orderingToolStripMenuItem.Text = "Order Processing";
            this.orderingToolStripMenuItem.Click += new System.EventHandler(this.orderingToolStripMenuItem_Click);
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.salesOrderToolStripMenuItem.Text = "Sales Processing";
            this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.salesOrderToolStripMenuItem_Click);
            // 
            // deliveryOrderToolStripMenuItem
            // 
            this.deliveryOrderToolStripMenuItem.Name = "deliveryOrderToolStripMenuItem";
            this.deliveryOrderToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.deliveryOrderToolStripMenuItem.Text = "Delivery Processing";
            this.deliveryOrderToolStripMenuItem.Click += new System.EventHandler(this.deliveryOrderToolStripMenuItem_Click);
            // 
            // transactionListToolStripMenuItem
            // 
            this.transactionListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockTransferListToolStripMenuItem,
            this.returnsToolStripMenuItem1});
            this.transactionListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transactionListToolStripMenuItem.Name = "transactionListToolStripMenuItem";
            this.transactionListToolStripMenuItem.Size = new System.Drawing.Size(159, 27);
            this.transactionListToolStripMenuItem.Text = "Transaction List";
            // 
            // stockTransferListToolStripMenuItem
            // 
            this.stockTransferListToolStripMenuItem.Name = "stockTransferListToolStripMenuItem";
            this.stockTransferListToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.stockTransferListToolStripMenuItem.Text = "Incoming";
            this.stockTransferListToolStripMenuItem.Click += new System.EventHandler(this.stockTransferListToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem1
            // 
            this.returnsToolStripMenuItem1.Name = "returnsToolStripMenuItem1";
            this.returnsToolStripMenuItem1.Size = new System.Drawing.Size(164, 28);
            this.returnsToolStripMenuItem1.Text = "Outgoing";
            this.returnsToolStripMenuItem1.Click += new System.EventHandler(this.returnsToolStripMenuItem1_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.masterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeclareIncoming);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeclareIncoming;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recievingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTransferListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}