using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS.MAster
{
    public partial class ProductsList : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        Dictionary<String, DataRow> uom = new Dictionary<String, DataRow>();
        Dictionary<String, DataRow> pricetype = new Dictionary<String, DataRow>();
        public ProductsList()
        {
            InitializeComponent();
          
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            display();
            uomPriceType();
            design();
        }
        private void design()
        {
            DataGridViewCellStyle style =
            product.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("  Select p.product_id,p.description,p.category from products p ").Tables[0];
            product.DataSource = _bs;
            DoubleBuffered(dataGridView1, true);
        }
        public new void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void uomPriceType()
        {
            {
                colUom.DataSource = DataSupport.RunDataSet("SELECT * FROM Uom").Tables[0];
                colUom.DisplayMember = "uom";
                colUom.ValueMember = "uom";
            }

            {
                colPriceType.DataSource = DataSupport.RunDataSet("SELECT * FROM PriceType").Tables[0];
                colPriceType.DisplayMember = "priceType";
                colPriceType.ValueMember = "priceTypeID";
            }
        }
        private void product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String code = product.Rows[e.RowIndex].Cells[colProductCode.Name].Value.ToString();
            txtCode.Text = null;
            txtDescription.Text = null;
            txtCategory.Text = null;
            if (GetProduct(code))
            {

                if (String.IsNullOrEmpty(Codes.ToString()) || Codes.Equals(""))
                {
                    var dRow = DataSupport.RunDataSet("Select * from products where product_id ='" + code + "'").Tables[0];
                    foreach (DataRow row in dRow.Rows)
                    {
                        txtCode.Text = row["product_id"].ToString();
                        txtDescription.Text = row["description"].ToString();
                        txtCategory.Text = row["category"].ToString();
                    }
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                { 
                    tabControl1.SelectedTab = tabPage2;
                }
                label9.Visible = false;
                txtSearch.Visible = false;
            }

           
        }

        private void product_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                var primary = new List<string>();
                Dictionary<String, Object> header = new Dictionary<String, Object>();
                header.Add("productID", txtCode.Text);
                header.Add("uom", row.Cells[colUom.Name].Value.ToString());
                header.Add("priceTypeID", row.Cells[colPriceType.Name].Value.ToString());
                header.Add("unitPrice", row.Cells[colUnitPrice.Name].Value.ToString());
                header.Add("dateStamp", DateTime.Now);
                header.Add("qty", row.Cells[colQty.Name].Value.ToString());
                primary.Add("productID"); primary.Add("uom"); primary.Add("priceTypeID");
                if (FAQ.productPriceExist(Convert.ToInt32(txtCode.Text),row.Cells[colUom.Name].Value.ToString(),row.Cells[colPriceType.Name].Value.ToString()))
                { sql.Append(DataSupport.GetUpdate("itemPrice", header,primary)); }
                else
                { sql.Append(DataSupport.GetInsert("itemPrice", header)); }
                
            }
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
        String Codes = "";
        private bool GetProduct(String Pcode)
        {
            try
            {
                var dt = DataSupport.RunDataSet("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where i.productID = '" + Pcode + "'").Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        txtCode.Text = row["product_id"].ToString();
                        txtDescription.Text = row["description"].ToString();
                        txtCategory.Text = row["category"].ToString();
                        dataGridView1.DataSource = DataSupport.RunDataSet("select qty,unitPrice,i.uom,i.priceTypeId from itemPrice i join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where productId = '" + Pcode + "'").Tables[0];
                    }
                }
                else
                {
               
                    Codes = "";
                    uomPriceType();
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = DataSupport.RunDataSet("select qty,unitPrice,i.uom,i.priceTypeId from itemPrice i join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where productId = '" + Pcode + "'").Tables[0];
                }
            }
            catch
            { }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
            //        break;
            //    MessageBox.Show(row.Cells[colPriceType.Name].Value.ToString());
            //}

        }

        private void ProductsList_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder(); 
            Dictionary<String, Object> header = new Dictionary<String, Object>();
            header.Add("product_id", txtProductCode.Text);
            header.Add("description", txtDescription.Text);
            header.Add("description1", txtDescrip1.Text);
            header.Add("description2", txtdescription2.Text);
            header.Add("category", txtCat.Text);
            header.Add("pcs_per_case", "0");
            header.Add("default_owner","COMARK");
            sql.Append(DataSupport.GetInsert("products", header));
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            label9.Visible = true;
            txtSearch.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            label9.Visible = true;
            txtSearch.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            label9.Visible = false;
            txtSearch.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bs.Filter = "product_id LIKE '%" + txtSearch.Text + "%'";
        }

        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtProductCode_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.ProductCode(txtProductCode.Text))
            {
                e.Cancel = true;
                txtProductCode.Focus();
                errorProvider1.SetError(txtProductCode, "Invoice No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtProductCode, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
