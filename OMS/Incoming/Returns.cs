using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
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
                cbxwarehouse.DataSource = DataSupport.RunDataSet("Select * from [Warehouses]").Tables[0];
                cbxwarehouse.ValueMember = "warehouse_id";
                cbxwarehouse.DisplayMember = "warehouse_id";
                
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
           
            try
            {
                Object code = dataGridView1.Rows[e.RowIndex].Cells[colCode.Name].Value;
                int rows1 = dataGridView1.Rows.Count;
                if (rows1 <= 13)
                {
                        //if (e.ColumnIndex == dataGridView1.Columns["colUnit"].Index)
                        //{
                        //    String uom = dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value.ToString();
                        //    var dt = DataSupport.RunDataSet("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where productID = '" + Code + "'and i.uom = '" + uom + "'and i.priceTypeID  = '" + cbxpriceType.SelectedValue.ToString() + "'").Tables[0];
                        //    dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = "0";
                        //    foreach (DataRow rows in dt.Rows)
                        //    {

                        //        dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = rows["unitPrice"].ToString();

                        //    }
                        //}
                        //else 
                    if (e.ColumnIndex == dataGridView1.Columns[colCode.Name].Index)
                    {
                        var dt = DataSupport.RunDataSet("Select * from Products where product_id ='"+code+"'").Tables[0];
                        foreach (DataRow rows in dt.Rows)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[colDescription.Name].Value = rows["description"].ToString();
                        }
                           
                    }
                    compute();
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
            Form1 dialog = new Form1();
            dialog.Retrns = this;
            dialog.mode = 6;
            bool status = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (String.IsNullOrWhiteSpace(row.Cells[colUnit.Name].Value as String))
                {               
                    status = true;
                }

            }
            if (!status)
            {
                System.Data.DataTable result = new System.Data.DataTable();
                result.Columns.Add(new DataColumn("rgsno", typeof(String)));
                result.Columns.Add(new DataColumn("custname", typeof(String)));
                result.Columns.Add(new DataColumn("custCode", typeof(String)));
                result.Columns.Add(new DataColumn("address", typeof(String)));
                result.Columns.Add(new DataColumn("salesman", typeof(String)));
                result.Columns.Add(new DataColumn("invoiceref", typeof(string)));
                result.Columns.Add(new DataColumn("invoicedate", typeof(DateTime)));
                result.Columns.Add(new DataColumn("instruction", typeof(String)));
                result.Columns.Add(new DataColumn("warehouse", typeof(String)));
                result.Columns.Add(new DataColumn("code", typeof(String)));
                result.Columns.Add(new DataColumn("productcode", typeof(String)));
                result.Columns.Add(new DataColumn("description", typeof(String)));
                result.Columns.Add(new DataColumn("uom", typeof(String)));
                result.Columns.Add(new DataColumn("qty", typeof(String)));
                result.Columns.Add(new DataColumn("price", typeof(String)));
                result.Columns.Add(new DataColumn("amount", typeof(String)));
                result.Columns.Add(new DataColumn("reason", typeof(String)));
                result.Columns.Add(new DataColumn("typestock", typeof(String)));
                result.Columns.Add(new DataColumn("received", typeof(String)));
                result.Columns.Add(new DataColumn("receiveddate", typeof(String)));
                result.Columns.Add(new DataColumn("transcode", typeof(String)));
                DataRow resultRow = result.NewRow();
                resultRow = result.NewRow();
                resultRow["custname"] = lblCustname.Text;
                resultRow["custCode"] = txtCustCode.Text;
                resultRow["address"] = lblAddress.Text;
                resultRow["salesman"] = cbxSalesman.Text;
                resultRow["invoiceref"] = txtInvoiceRef.Text;
                resultRow["invoicedate"] = txtInvoiceDate.Text;
                resultRow["warehouse"] = cbxwarehouse.Text;
                resultRow["code"] = lblWcode.Text;
                resultRow["typestock"] = cbxTypeS.Text;
                result.Rows.Add(resultRow);
                foreach (DataGridViewRow dRow in dataGridView1.Rows)
                {
                    if (dataGridView1.Rows.IndexOf(dRow) == dataGridView1.Rows.Count - 1)
                        break;
                    resultRow = result.NewRow();
                    resultRow["productcode"] = dRow.Cells[colCode.Name].Value;
                    resultRow["description"] = dRow.Cells[colDescription.Name].Value;
                    resultRow["uom"] = dRow.Cells[colUnit.Name].Value;
                    resultRow["qty"] = dRow.Cells[colQuantity.Name].Value;
                    resultRow["price"] = dRow.Cells[colPrice.Name].Value;
                    resultRow["amount"] = dRow.Cells[colTotal.Name].Value;
                    result.Rows.Add(resultRow);
                }
                resultRow = result.NewRow();
                resultRow["rgsno"] = txtRgsNo.Text;
                resultRow["reason"] = txtRemarks.Text;
                resultRow["transcode"] = txtTransCode.Text;
                resultRow["received"] = txtReceived.Text;
                resultRow["receiveddate"] = txtDateR.Text;
                result.Rows.Add(resultRow);
                var viewer = new CrystalReport.Report();
                ReportDocument ReportDocs = new ReportDocument();
                ReportDocs = new CrystalReport.returns();
                ReportDocs.Database.Tables[0].SetDataSource(result);
                viewer.Viewer.ReportSource = ReportDocs;
                viewer.ShowDialog();
                //dialog.ShowDialog();
                if (viewer._status == "save")
                {
                    saved();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("uom is empty");
            }
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
                var dt = DataSupport.RunDataSet("SELECT  warehouseCode FROM [Warehouses] where warehouse_id = '" + cbxwarehouse.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    lblWcode.Text = row["warehouseCode"].ToString();
                }
            }
            catch
            { }
        }

        private void cbxpriceType_SelectedValueChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
        }
    }
}
