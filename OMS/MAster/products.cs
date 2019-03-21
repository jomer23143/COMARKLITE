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
    public partial class products : Form
    {
        public static string mode = "";
        public static int id;
        public products()
        {
            InitializeComponent();
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            if (mode == "Saved")
            {
                saved();
            }
            else
            {
                update();
            }
        }
     
        private void saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<String, Object>();
            header.Add("product_id", txtCode.Text);
            header.Add("description", txtdesc1.Text);
            header.Add("description1", txtdesc2.Text);
            header.Add("description2", txtdesc3.Text);
            header.Add("category", txtCategory.Text);
            header.Add("pcs_per_case", "0");
            header.Add("default_owner", "COMARK");
            sql.Append(DataSupport.GetInsert("products", header));
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            saveUOM();
        }
        private void saveUOM()
        {
            StringBuilder sql = new StringBuilder();
            String id = DataSupport.RunDataSet("Select max(id) from Products").Tables[0].Rows[0][0].ToString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                Dictionary<String, Object> details = new Dictionary<String, Object>();
                details.Add("productID", id);
                details.Add("prodCode", txtCode.Text);
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("uom", ""); }
                else
                { details.Add("uom", row.Cells[colUOM.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("qty", ""); }
                else
                { details.Add("qty", row.Cells[colQty.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("priceTypeID", ""); }
                else
                { details.Add("priceTypeID", row.Cells[colPriceType.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("unitPrice", ""); }
                else
                { details.Add("unitPrice", row.Cells[colPrice.Name].Value.ToString()); }
                details.Add("dateStamp", DateTime.Now);
                sql.Append(DataSupport.GetInsert("itemPrice", details));

            }
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;

        }
        private void update()
        {
            
            StringBuilder sql = new StringBuilder();
            var primary = new List<string>();
            Dictionary<String, Object> header = new Dictionary<String, Object>();
            header.Add("id", id);
            header.Add("product_id", txtCode.Text);
            header.Add("description", txtdesc1.Text);
            header.Add("description1", txtdesc2.Text);
            header.Add("description2", txtdesc3.Text);
            header.Add("category", txtCategory.Text);
            primary.Add("id");
            sql.Append(DataSupport.GetUpdate("products", header,primary));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                var primarys = new List<string>();
                Dictionary<String, Object> details = new Dictionary<String, Object>();
                details.Add("productID", id);
                details.Add("prodCode",txtCode.Text );
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                {
                    details.Add("uom", "");
                }
                else
                {
                    details.Add("uom", row.Cells[colUOM.Name].Value.ToString());
                }
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                {
                    details.Add("qty", "");
                }
                else
                {
                    details.Add("qty", row.Cells[colQty.Name].Value.ToString());
                }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                {
                    details.Add("priceTypeID", "");
                }
                else
                {
                    details.Add("priceTypeID", row.Cells[colPriceType.Name].Value.ToString());
                }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                {
                    details.Add("unitPrice", "");
                }
                else
                {
                    details.Add("unitPrice", row.Cells[colPrice.Name].Value.ToString());
                }
                details.Add("dateStamp", DateTime.Now);
                primarys.Add("productID");primarys.Add("uom");primarys.Add("priceTypeID");
                if (FAQ.productPriceExist(Convert.ToInt32(id), row.Cells[colUOM.Name].Value.ToString(), row.Cells[colPriceType.Name].Value.ToString()))
                { sql.Append(DataSupport.GetUpdate("itemPrice", details, primarys)); }
                else
                { sql.Append(DataSupport.GetInsert("itemPrice", details)); }
            }
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("saved");
            DialogResult = DialogResult.OK;
        }
        private void products_Load(object sender, EventArgs e)
        {
            design();
        }
        private void design()
        {
            DataGridViewCellStyle style =
            dataGridView1.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
