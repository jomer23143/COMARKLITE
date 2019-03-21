namespace OMS.MAster
{
    partial class products
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
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesc2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesc3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colUOM = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colPrice = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(146, 356);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 46);
            this.button5.TabIndex = 25;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(24, 356);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(109, 46);
            this.btnDeclare.TabIndex = 24;
            this.btnDeclare.Text = "Declare";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUOM,
            this.colQty,
            this.colPriceType,
            this.colPrice});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(29, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 207);
            this.dataGridView1.TabIndex = 23;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Location = new System.Drawing.Point(227, 42);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(178, 21);
            this.txtCategory.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(224, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Category :";
            // 
            // txtdesc1
            // 
            this.txtdesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc1.Location = new System.Drawing.Point(419, 43);
            this.txtdesc1.Name = "txtdesc1";
            this.txtdesc1.Size = new System.Drawing.Size(263, 21);
            this.txtdesc1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(418, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description 1 :";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(30, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(178, 21);
            this.txtCode.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Code :";
            // 
            // txtdesc2
            // 
            this.txtdesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc2.Location = new System.Drawing.Point(28, 91);
            this.txtdesc2.Name = "txtdesc2";
            this.txtdesc2.Size = new System.Drawing.Size(263, 21);
            this.txtdesc2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description 2 :";
            // 
            // txtdesc3
            // 
            this.txtdesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc3.Location = new System.Drawing.Point(303, 91);
            this.txtdesc3.Name = "txtdesc3";
            this.txtdesc3.Size = new System.Drawing.Size(263, 21);
            this.txtdesc3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(302, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Description 3:";
            // 
            // colUOM
            // 
            this.colUOM.DataPropertyName = "uom";
            this.colUOM.DisplayMember = "Text";
            this.colUOM.DropDownHeight = 106;
            this.colUOM.DropDownWidth = 121;
            this.colUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUOM.HeaderText = "UOM";
            this.colUOM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colUOM.ItemHeight = 15;
            this.colUOM.Items.AddRange(new object[] {
            "PCS",
            "CASES"});
            this.colUOM.Name = "colUOM";
            this.colUOM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "qty";
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPriceType
            // 
            this.colPriceType.DataPropertyName = "priceTypeID";
            this.colPriceType.DisplayMember = "Text";
            this.colPriceType.DropDownHeight = 106;
            this.colPriceType.DropDownWidth = 121;
            this.colPriceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colPriceType.HeaderText = "Price Type";
            this.colPriceType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colPriceType.ItemHeight = 15;
            this.colPriceType.Items.AddRange(new object[] {
            "LP WITH VAT",
            "LP WITHOUT VAT"});
            this.colPriceType.Name = "colPriceType";
            this.colPriceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.colPrice.DataPropertyName = "unitPrice";
            this.colPrice.HeaderText = "Unit Price";
            this.colPrice.Increment = 1D;
            this.colPrice.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.colPrice.Name = "colPrice";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(705, 415);
            this.Controls.Add(this.txtdesc3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdesc2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdesc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtCategory;
        public System.Windows.Forms.TextBox txtdesc1;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtdesc2;
        public System.Windows.Forms.TextBox txtdesc3;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colPriceType;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colPrice;
    }
}