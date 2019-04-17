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

namespace OMS.Outgoing
{
    public partial class DeliveryProcessing : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        Dictionary<String, DataRow> getWarehouse = new Dictionary<String, DataRow>();
        public static String form;
        public DeliveryProcessing()
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
        private void DeliveryProcessing_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                foreach (DataRow row in dt.Rows)
                    colCode.Items.Add(row[0].ToString());
            }
            {
                var dt = DataSupport.RunDataSet("SELECT warehouse_id FROM Warehouses").Tables[0];
                foreach (DataRow row in dt.Rows)
                    cbxWarehouse.Items.Add(row[0].ToString());
            }
            {
                var dt = DataSupport.RunDataSet("SELECT  customer FROM TransportCustomers ").Tables[0];
                foreach (DataRow row in dt.Rows)
                    cbxCustName.Items.Add(row[0].ToString());
            }
            {
                var dt = DataSupport.RunDataSet("SELECT transport_id FROM TransportProviders").Tables[0];
                foreach (DataRow row in dt.Rows)
                    txtTransportProvider.Items.Add(row[0].ToString());
            }
            txtDrno.KeyPress += new KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);
          
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
            dialog.DR = this;
            dialog.mode = 3;
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
                result.Columns.Add(new DataColumn("drno", typeof(String)));
                result.Columns.Add(new DataColumn("custname", typeof(String)));
                result.Columns.Add(new DataColumn("custCode", typeof(String)));
                result.Columns.Add(new DataColumn("address", typeof(String)));
                result.Columns.Add(new DataColumn("refno", typeof(String)));
                result.Columns.Add(new DataColumn("refdate", typeof(DateTime)));
                result.Columns.Add(new DataColumn("warehouse", typeof(String)));
                result.Columns.Add(new DataColumn("code", typeof(String)));
                result.Columns.Add(new DataColumn("productcode", typeof(String)));
                result.Columns.Add(new DataColumn("description", typeof(String)));
                result.Columns.Add(new DataColumn("uom", typeof(String)));
                result.Columns.Add(new DataColumn("qty", typeof(String)));
                result.Columns.Add(new DataColumn("reason", typeof(String)));
                result.Columns.Add(new DataColumn("typestock", typeof(String)));
                DataRow resultRow = result.NewRow();
                resultRow = result.NewRow();
                resultRow["drno"] = txtDrno.Text;
                resultRow["custname"] = cbxCustName.Text;
                resultRow["custCode"] = txtCodeD.Text;
                resultRow["address"] = txtAddressD.Text;
                resultRow["refno"] = txtRefno.Text;
                resultRow["refdate"] = txtRefDate.Text;
                resultRow["warehouse"] = cbxWarehouse.Text;
                resultRow["code"] = txtCodeS.Text;
                resultRow["typestock"] = txtTypeStock.Text;
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
                resultRow["reason"] = txtReason.Text;
                result.Rows.Add(resultRow);
                var viewer = new CrystalReport.Report();
                ReportDocument ReportDocs = new ReportDocument();
                ReportDocs = new CrystalReport.Delivery();
                ReportDocs.Database.Tables[0].SetDataSource(result);
                viewer.Viewer.ReportSource = ReportDocs;
                viewer.ShowDialog();
                //dialog.ShowDialog();
                if (viewer._status == "save")
                {
                    saved();
                    clear();
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("uom is empty");
            }


        }
        private void clear()
        {
            txtDrno.Clear();
            cbxCustName.SelectedIndex = -1;
            cbxWarehouse.SelectedIndex = - 1;
            txtTypeStock.SelectedIndex = -1;
            txtAddressD.Text = null;
            txtCodeD.Text = null;
            txtCodeS.Text = null;
            txtReason.Clear();
            txtRefno.Clear();
            dataGridView1.Rows.Clear();
        }
        private void saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            String DrId;
            if (form == "STR")
            {
                DrId = DataSupport.GetNextMenuCodeInt("STR-DR");
                header.Add("outgoing_type", "Stock Transfer");
            }
            else
            {
                DrId = DataSupport.GetNextMenuCodeInt("DR");
                header.Add("outgoing_type", "Delivery");
            }
            header.Add("out_shipment_id", DrId);
            header.Add("warehouse", cbxWarehouse.Text);
            header.Add("typeStocks", txtTypeStock.Text);
            header.Add("datetime", DateTime.Now);
            header.Add("docNo", txtDrno.Text);
            header.Add("document_reference", txtRefno.Text);
            header.Add("document_reference_date", txtDateS.Text);
            header.Add("authorized_tms", txtTransportProvider.Text);
            header.Add("client", "COMARK");
            header.Add("terms", "");
            header.Add("poNo", "");
            header.Add("sr", "");
            header.Add("terrCode", "");
            header.Add("customer_id", txtCodeD.Text);
            header.Add("customer_name", cbxCustName.Text);
            header.Add("contactNo", "");
            header.Add("customer_invoice_address", txtAddressD.Text);
            header.Add("disc1", "");
            header.Add("disc2", "");
            header.Add("disc3", "");
            header.Add("disc4", "");
            header.Add("disc5", "");
            header.Add("shippingInstruction", txtReason.Text);
            header.Add("amountD", "");
            header.Add("status", "FOR STOCK CHECKING");

            sql.Append(DataSupport.GetInsert("OutgoingShipmentRequests", header));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;

                Dictionary<String, Object> detail = new Dictionary<String, Object>();
                detail.Add("out_shipment", DrId);
                detail.Add("product", row.Cells[colCode.Name].Value.ToString());
                detail.Add("uom", row.Cells[colUnit.Name].Value.ToString());
                if(string.IsNullOrEmpty(row.Cells[colQuantity.Name].Value as string))
                { detail.Add("expected_qty", "0"); }
                else
                { detail.Add("expected_qty", row.Cells[colQuantity.Name].Value.ToString()); }
                sql.Append(DataSupport.GetInsert("OutgoingShipmentRequestDetails", detail));
            }
            if (FAQ.InvoiceExist(txtDrno.Text))
            {
                MessageBox.Show("DR No is Exist");
            }
            else
            {
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
            }
        }
        private void cbxWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  warehouseCode  FROM Warehouses where warehouse_id = '" + cbxWarehouse.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCodeS.Text = row["warehouseCode"].ToString();
                  
                }
            }
            catch
            { }
        }

        private void cbxCustName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  custCode,address,contactNo,tinNo FROM TransportCustomers where customer = '" + cbxCustName.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCodeD.Text = row["custCode"].ToString();
                    txtAddressD.Text = row["address"].ToString();
                }
            }
            catch
            { }
        }

        private void txtTransportProvider_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDrno_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.INWrrNoExist(txtDrno.Text))
            {
                e.Cancel = true;
                txtDrno.Focus();
                errorProvider1.SetError(txtDrno, "DR No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDrno, null);
            }
        }

        private void txtDrno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
