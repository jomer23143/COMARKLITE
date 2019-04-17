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
    public partial class ListProducts : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public static string code;
        public ListProducts()
        {
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            display();
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
            _bs.DataSource = DataSupport.RunDataSet("  Select p.product_id,p.description,p.category,p.id from products p order by description ASC").Tables[0];
            product.DataSource = _bs;
            DoubleBuffered(product, true);
        }
        public new void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _bs.Filter = "product_id LIKE '%" + txtSearch.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dialog = new products();
            products.mode = "Saved";
            dialog.ShowDialog();
            display();
        }

        private void product_DoubleClick(object sender, EventArgs e)
        {

        }

        private void product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dialog = new MAster.products();
                code = product.Rows[e.RowIndex].Cells[colId.Name].Value.ToString();
                var dRow = DataSupport.RunDataSet(String.Format("select * from itemPrice join products on itemprice.productID = products.id where products.id = '{0}' ", code)).Tables[0];
                if (dRow.Rows.Count > 0)
                {
                    foreach (DataRow rows in dRow.Rows)
                    {
                        dialog.txtCode.Text = rows["product_id"].ToString();
                        dialog.txtdesc1.Text = rows["description"].ToString();
                        dialog.txtdesc2.Text = rows["description1"].ToString();
                        dialog.txtdesc3.Text = rows["description2"].ToString();
                        products.id = Convert.ToInt32(rows["productID"].ToString());
                        dialog.dataGridView1.DataSource = DataSupport.RunDataSet("select qty,unitPrice,uom,priceTypeId from itemPrice  where productId = '" + code + "' ").Tables[0];
                    }
                }
                else
                {
                    var dt = DataSupport.RunDataSet("Select * from Products where id = '" + code + "'").Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        dialog.txtCode.Text = row["product_id"].ToString();
                        dialog.txtdesc1.Text = row["description"].ToString();
                        dialog.txtdesc2.Text = row["description1"].ToString();
                        dialog.txtdesc3.Text = row["description2"].ToString();
                        products.id = Convert.ToInt32(row["id"].ToString());
                    }
                }
                dialog.ShowDialog();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
