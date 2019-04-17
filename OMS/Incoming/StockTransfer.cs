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
    public partial class StockTransfer : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        public StockTransfer()
        {
            InitializeComponent();
            design();
        }

        private void StockTransfer_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                colCode.DataSource = dt;
                colCode.DisplayMember = "product_id";
                colCode.ValueMember = "product_id";
            }
            {
                var dt = DataSupport.RunDataSet("Select warehouse_id from Warehouses ").Tables[0];
                cbxSource.DataSource = dt;
                cbxSource.DisplayMember = "warehouse_id";
                cbxSource.ValueMember = "warehouse_id";
            }
            {
                var dt = DataSupport.RunDataSet("select customer from TransportCustomers ").Tables[0];
                cbxReceived.DataSource = dt;
                cbxReceived.DisplayMember = "customer";
                cbxReceived.ValueMember = "customer";
            }
            txtTypeStocks.SelectedIndex = 0;
        }

        private void design()
        {
            DataGridViewCellStyle style =
            dataGridView1.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataRow dRow = null;
                String Code = dataGridView1.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                GetProduct = Utils.BuildIndex("Select * from products", "product_id");
                if (GetProduct.TryGetValue(Code, out dRow))
                {

                    dataGridView1.Rows[e.RowIndex].Cells["colDescription"].Value = dRow["description"].ToString();
                }


            }
            catch
            { }
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            Form1 dialog = new Form1();
            dialog.STR = this;
            dialog.mode = 7;
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
                result.Columns.Add(new DataColumn("strno", typeof(String)));
                result.Columns.Add(new DataColumn("custname", typeof(String)));
                result.Columns.Add(new DataColumn("custcode", typeof(String)));
                result.Columns.Add(new DataColumn("custaddress", typeof(String)));
                result.Columns.Add(new DataColumn("refnr", typeof(String)));
                result.Columns.Add(new DataColumn("refdate", typeof(DateTime)));
                result.Columns.Add(new DataColumn("shipping", typeof(String)));
                result.Columns.Add(new DataColumn("warehouse", typeof(String)));
                result.Columns.Add(new DataColumn("warecode", typeof(String)));
                result.Columns.Add(new DataColumn("wareaddress", typeof(String)));
                result.Columns.Add(new DataColumn("productcode", typeof(String)));
                result.Columns.Add(new DataColumn("description", typeof(String)));
                result.Columns.Add(new DataColumn("uom", typeof(String)));
                result.Columns.Add(new DataColumn("qty", typeof(String)));
                result.Columns.Add(new DataColumn("reasons", typeof(String)));
                result.Columns.Add(new DataColumn("typestock", typeof(String)));
                result.Columns.Add(new DataColumn("issued", typeof(String)));
                result.Columns.Add(new DataColumn("idate", typeof(DateTime)));
                result.Columns.Add(new DataColumn("picked", typeof(String)));
                result.Columns.Add(new DataColumn("pdate", typeof(DateTime)));
                result.Columns.Add(new DataColumn("received", typeof(String)));
                result.Columns.Add(new DataColumn("rdate", typeof(DateTime)));
                DataRow resultRow = result.NewRow();
                resultRow = result.NewRow();
                resultRow["strno"] = txtStrNo.Text;
                resultRow["custname"] = cbxSource.Text;
                resultRow["custcode"] = txtWhseS.Text;
                resultRow["custaddress"] = txtAddressS.Text;
                resultRow["refnr"] = txtRefNR.Text;
                resultRow["refdate"] = txtDateRef.Text;
                resultRow["warehouse"] = cbxReceived.Text;
                resultRow["warecode"] = txtWhseR.Text;
                resultRow["wareaddress"] = txtAddressR.Text;
                resultRow["typestock"] = txtTypeStocks.Text;
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
                    result.Rows.Add(resultRow);
                }
                resultRow = result.NewRow();
                resultRow["reasons"] = txtReason.Text;
                resultRow["issued"] = txtIssued.Text;
                resultRow["idate"] = txtDateI.Text;
                resultRow["picked"] = txtPickUp.Text;
                resultRow["pdate"] = txtDateP.Text;
                resultRow["received"] = txtReceived.Text;
                resultRow["rdate"] = txtDateRe.Text;
                result.Rows.Add(resultRow);
                var viewer = new CrystalReport.Report();
                ReportDocument ReportDocs = new ReportDocument();
                ReportDocs = new CrystalReport.str();
                ReportDocs.Database.Tables[0].SetDataSource(result);
                viewer.Viewer.ReportSource = ReportDocs;
                viewer.ShowDialog();
                //dialog.ShowDialog();
                if (viewer._status == "save")
                {
                    saved();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("uom is empty");
            }
        }
        private void saved()
        {
            MessageBox.Show(WhsID.ToString());
            String transID = DataSupport.GetNextMenuCodeInt("STR");
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("shipment_id", transID);
            header.Add("warehouse", WhsID);
            header.Add("document_reference", txtStrNo.Text);
            header.Add("nr", txtRefNR.Text);
            header.Add("document_reference_date", txtDateRef.Text);
            //header.Add("client", "Null");
            //header.Add("authorized_shipper", "Null");
            header.Add("remarks", txtReason.Text);
            header.Add("incoming_type", "STOCK TRANSFER");
            header.Add("typeStocks", txtTypeStocks.Text);
            header.Add("received", txtReceived.Text);
            header.Add("received_on", txtDateRe.Text);
            header.Add("status", "FOR RECEIVING");
            header.Add("custName", cbxReceived.Text);
            header.Add("issued", txtIssued.Text);
            header.Add("dateIssued", txtDateI.Text);
            header.Add("pickUp", txtPickUp.Text);
            header.Add("datePick", txtDateP.Text);

            sql.Append(DataSupport.GetInsert("IncomingShipmentRequests", header));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;

                Dictionary<String, Object> detail = new Dictionary<string, object>();
                detail.Add("shipment", transID);
                detail.Add("product", row.Cells[colCode.Name].Value.ToString());
                detail.Add("uom", row.Cells[colUnit.Name].Value.ToString());
                detail.Add("expected_qty", row.Cells[colQuantity.Name].Value.ToString());
                detail.Add("lot_no", "Null");
                detail.Add("expiry", "12-12-2000");
                sql.Append(DataSupport.GetInsert("IncomingShipmentRequestDetails", detail));
            }

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;
        }
        String WhsID;
        private void Clear()
        {
            txtAddressR.Text = null;
            txtAddressS.Text = null;
            txtWhseR.Text = null;
            txtWhseS.Text = null;
            txtTypeStocks.SelectedIndex = -1;
            txtReceived.Clear();
            cbxReceived.SelectedIndex = -1;
            cbxSource.SelectedIndex = -1;
            txtPickUp.Clear();
            txtRefNR.Clear();
            txtAddressR.Text = null;
            txtAddressS.Text = null;
            txtReason.Clear();
            txtIssued.Clear();
            dataGridView1.Rows.Clear();

        }
        private void cbxSource_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                var dt = DataSupport.RunDataSet("Select warehouse_id,warehouseCode,address from Warehouses where warehouse_id = '" + cbxSource.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtWhseS.Text = row["warehouseCode"].ToString();
                    txtAddressS.Text = row["address"].ToString();
                    WhsID = row["warehouse_id"].ToString();
                }
                
            }
            catch
            { }
        }

        private void cbxReceived_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet(" select custCode,address from TransportCustomers where customer = '" + cbxReceived.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtWhseR.Text = row["custCode"].ToString();
                    txtAddressR.Text = row["address"].ToString();
                }
            }
            catch
            { }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
