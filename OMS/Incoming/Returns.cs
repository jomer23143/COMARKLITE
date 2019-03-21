using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS.Incoming
{
    public partial class Returns : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        public Returns()
        {
            InitializeComponent();
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
        private void Returns_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT  custCode FROM TransportCustomers ").Tables[0];
                txtCustCode.DataSource = dt;
                txtCustCode.DisplayMember = "custCode";
                txtCustCode.ValueMember = "custCode";

            }
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                colCode.DataSource = dt;
                colCode.DisplayMember = "product_id";
                colCode.ValueMember = "product_id";
            }
            {
                cbxSalesman.DataSource = DataSupport.RunDataSet("Select * from employees").Tables[0];
                cbxSalesman.ValueMember = "employee_id";
                cbxSalesman.DisplayMember = "name";
            }
            {
                cbxwarehouse.DataSource = DataSupport.RunDataSet("Select * from [TransportProviders]").Tables[0];
                cbxwarehouse.ValueMember = "transport_id";
                cbxwarehouse.DisplayMember = "description";
                
            }

            //priceType();
            //uom();
        }
        private void uom()
        {
            {
                colUnit.DataSource = DataSupport.RunDataSet("SELECT * FROM UOm").Tables[0];
                colUnit.DisplayMember = "uom";
                colUnit.ValueMember = "uom";
                dataGridView1.Rows.Clear();
            }
        }
        private void priceType()
        {
            {
                cbxpriceType.DataSource = DataSupport.RunDataSet("SELECT * FROM Pricetype").Tables[0];
                cbxpriceType.DisplayMember = "priceType";
                cbxpriceType.ValueMember = "priceTypeID";
            }
        }
        private Double compute()
        {
            Double total = 0.00;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total = Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[4].Value);
                row.Cells[5].Value = total;
            }
            return total;
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            //    DataRow dRow = null;
            //    String Code = dataGridView1.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
            //    GetProduct = Utils.BuildIndex("Select * from products", "product_id");
            //    if (GetProduct.TryGetValue(Code, out dRow))
            //    {

            //        dataGridView1.Rows[e.RowIndex].Cells["colDescription"].Value = dRow["description"].ToString();
            //        compute();
            //    }


            //}
            //catch
            //{ }
            try
            {
                String code = dataGridView1.Rows[e.RowIndex].Cells[colCode.Name].Value.ToString();
                int rows1 = dataGridView1.Rows.Count;
                if (rows1 <= 13)
                {
                    if (GetProducts(code))
                    {
                        DataRow dRow = null;
                        String Code = dataGridView1.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                        if (e.ColumnIndex == dataGridView1.Columns["colUnit"].Index)
                        {
                            String uom = dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value.ToString();
                            var dt = DataSupport.RunDataSet("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where productID = '" + Code + "'and i.uom = '" + uom + "'and i.priceTypeID  = '" + cbxpriceType.SelectedValue.ToString() + "'").Tables[0];
                            dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = "0";
                            foreach (DataRow rows in dt.Rows)
                            {

                                dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = rows["unitPrice"].ToString();

                            }
                        }
                        else if (e.ColumnIndex == dataGridView1.Columns["colCode"].Index)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value = "";
                            GetProduct = Utils.BuildIndex("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId", "productID");
                            if (GetProduct.TryGetValue(Code, out dRow))
                            {

                                dataGridView1.Rows[e.RowIndex].Cells[colDescription.Name].Value = dRow["description"].ToString();

                            }
                        }

                    }
                    else
                    {
                        if (e.ColumnIndex == dataGridView1.Columns["colCode"].Index)
                        {
                            DataRow Row = null;
                            String Code = dataGridView1.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                            GetProduct = Utils.BuildIndex("Select * from products", "product_id");
                            if (GetProduct.TryGetValue(Code, out Row))
                            {
                                dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value = "";
                                dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = "";
                                dataGridView1.Rows[e.RowIndex].Cells["colDescription"].Value = Row["description"].ToString();
                            }
                        }
                    }
                    compute();
                    return;
                }
                else
                {
                    MessageBox.Show("Only 12 rows are permited to insert");
                    dataGridView1.Rows.RemoveAt(12);
                }
            }

            catch
            { }
        }
        private bool GetProducts(String Pcode)
        {

            var dt = DataSupport.RunDataSet("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where i.productID = '" + Pcode + "'").Tables[0];
            if (dt.Rows.Count > 0)


                return true;
            return false;

        }
        private void txtCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  customer,address,postalCode FROM TransportCustomers where custCode = '" + txtCustCode.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    lblCustname.Text = row["customer"].ToString();
                    lblAddress.Text = row["address"].ToString();
                    lblArea.Text = row["postalCode"].ToString();
                }
            }
            catch
            { }
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            saved();
            clear();
        }
        private void saved()
        {
            String returnID = DataSupport.GetNextMenuCodeInt("RETURNS");
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("shipment_id", returnID);
            header.Add("custCode", txtCustCode.Text);
            header.Add("custName", lblCustname.Text);
            header.Add("codeS", cbxSalesman.Text);
            header.Add("document_reference", txtInvoiceRef.Text);
            header.Add("document_reference_date", txtInvoiceDate.Text);
            header.Add("warehouse", cbxwarehouse.Text);
            header.Add("incoming_type", "RETURN STOCKS");
            header.Add("typeStocks", cbxTypeS.Text);
            header.Add("remarks", txtRemarks.Text);
            header.Add("received", txtReceived.Text);
            header.Add("received_on", txtDateR.Text);
            header.Add("transCode", txtTransCode.Text);
            header.Add("wrrNo", txtRgsNo.Text);
            header.Add("status", "FOR RECEIVING");

            sql.Append(DataSupport.GetInsert("IncomingShipmentRequests", header));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                Dictionary<String, Object> detail = new Dictionary<string, object>();
                detail.Add("shipment", returnID);
                detail.Add("product", row.Cells[colCode.Name].Value.ToString());
                detail.Add("uom", row.Cells[colUnit.Name].Value.ToString());
                if (string.IsNullOrEmpty(row.Cells[colQuantity.Name].Value as string))
                { detail.Add("received_qty", "0"); }
                else
                { detail.Add("received_qty", row.Cells[colQuantity.Name].Value.ToString()); }
                if (String.IsNullOrEmpty(row.Cells[colPrice.Name].Value.ToString()) || row.Cells[colPrice.Name].Value.ToString() == null)
                { detail.Add("price", "0.00"); }
                else
                { detail.Add("price", row.Cells[colPrice.Name].Value.ToString()); }
                if (String.IsNullOrEmpty(row.Cells[colTotal.Name].Value.ToString()) || row.Cells[colTotal.Name].Value.ToString() == null)
                { detail.Add("total", "0.00"); }
                else
                { detail.Add("total", row.Cells[colTotal.Name].Value.ToString()); }
                detail.Add("lot_no", "Null");
                detail.Add("expiry", "12-12-2000");
                sql.Append(DataSupport.GetInsert("IncomingShipmentRequestDetails", detail));
            }

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;
        }
        private void clear()
        {
            txtCustCode.SelectedIndex = -1;
            lblCustname.Text = null;
            cbxSalesman.SelectedIndex = -1;
            txtInvoiceRef.Clear();
            cbxwarehouse.SelectedIndex = -1;
            cbxTypeS.SelectedIndex = -1;
            txtReceived.Clear();
            txtTransCode.Clear();
            txtRgsNo.Clear();
            lblArea.Text = null;
            cbxpriceType.SelectedIndex = -1;
            txtReceived.Clear();
            txtRemarks.Clear();
            dataGridView1.Rows.Clear();
            lblWcode.Text = null;
            lblAddress.Text = null;
        }
        private void cbxwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxwarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  transport_id FROM [TransportProviders] where description = '" + cbxwarehouse.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    lblWcode.Text = row["transport_id"].ToString();
                }
            }
            catch
            { }
        }

        private void cbxpriceType_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
