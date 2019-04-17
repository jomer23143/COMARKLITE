using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace OMS.Incoming
{
    public partial class NewIncomingWindow : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        public NewIncomingWindow()
        {
            InitializeComponent();
            design();
        }
        private void design()
        {
            DataGridViewCellStyle style =
            headerGrid.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }
        private void NewIncomingWindow_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                colCode.DataSource = dt;
                colCode.DisplayMember = "product_id";
                colCode.ValueMember = "product_id";
            }
            {
                var dt = DataSupport.RunDataSet("SELECT warehouse_id FROM Warehouses").Tables[0];
                txtWarehouse.DataSource = dt;
                txtWarehouse.DisplayMember ="warehouse_id";
                txtWarehouse.ValueMember = "warehouse_id";
            }
            txtwrrNo.KeyPress += new KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);
        }
        private void btnDeclare_Click(object sender, EventArgs e)
        {
            Form1 dialog = new Form1();
            dialog.INC = this;
            dialog.mode = 2;
            bool status = false;
            foreach (DataGridViewRow row in headerGrid.Rows)
            {
                if (row.IsNewRow) continue;
                if (String.IsNullOrWhiteSpace(row.Cells[uom.Name].Value as String))
                {
                    status = true;
                }

            }
            if (!status)
            {
                dialog.ShowDialog();
                if(Form1.status == true)
                {
                    saved();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Uom is empty");
            }
        }
        private void clear()
        {
            txtwrrNo.Clear();
            txtShipper.Clear();
            txtCodeS.Clear();
            txtAddressS.Clear();
            txtReference.Clear();
            txtReceived.Clear();
            txtTypeStocks.SelectedIndex = -1;
            txtWarehouse.SelectedIndex = -1;
            txtCodeR.Text = null;
            txtAddressR.Text = null;
            txtIncomingType.SelectedIndex = -1;
            txtClient.SelectedIndex = -1;
            txtShipped.Clear();
            headerGrid.Rows.Clear();
        }
        private void saved()
        {
            String incoming_id = "";
            StringBuilder sql = new StringBuilder();
            if(txtIncomingType.Text.ToLower().Trim() == "replenishment")
            { incoming_id = DataSupport.GetNextMenuCodeInt("INCOMING"); }
            else if(txtIncomingType.Text.ToLower().Trim() == "return from trade")
            { incoming_id = DataSupport.GetNextMenuCodeInt("RETURNS"); }
            else if(txtIncomingType.Text.ToLower().Trim() == "return from delivery")
            { incoming_id = DataSupport.GetNextMenuCodeInt("RETURNS"); }
            else if (txtIncomingType.Text.ToLower().Trim() == "stock transfer")
            { incoming_id = DataSupport.GetNextMenuCodeInt("STR-OUT"); }
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("shipment_id", incoming_id);
            header.Add("typeStocks", txtTypeStocks.Text);
            header.Add("wrrNo", txtwrrNo.Text);
            header.Add("warehouse", txtWarehouse.Text);
            header.Add("authorized_shipper", txtShipper.Text);
            header.Add("codeS", txtCodeS.Text);
            header.Add("address", txtAddressS.Text);
            header.Add("datetime", DateTime.Now);
            header.Add("document_reference", txtReference.Text);
            header.Add("document_reference_date", txtDocDate.Text);
            header.Add("incoming_type", txtIncomingType.Text);
            header.Add("client", "Comark");
            header.Add("received", txtReceived.Text);
            header.Add("shippedVia", txtShipped.Text);
            header.Add("transCode", transcode.Text);
            header.Add("status", "FOR RECEIVING");

            sql.Append(DataSupport.GetInsert("IncomingShipmentRequests", header));

            foreach (DataGridViewRow row in headerGrid.Rows)
            {
                if (headerGrid.Rows.IndexOf(row) == headerGrid.Rows.Count - 1)
                    break;

                Dictionary<String, Object> detail = new Dictionary<string, object>();
                detail.Add("shipment", incoming_id);
                detail.Add("product", row.Cells[colCode.Name].Value.ToString());
                detail.Add("uom", row.Cells[uom.Name].Value.ToString());
                detail.Add("lot_no", row.Cells[lot_no.Name].Value.ToString());
                detail.Add("expiry", row.Cells[expiry.Name].Value.ToString());
                detail.Add("expected_qty", row.Cells[qty.Name].Value.ToString());
                sql.Append(DataSupport.GetInsert("IncomingShipmentRequestDetails", detail));
            }
            if (FAQ.INWrrNoExist(txtwrrNo.Text))
            { MessageBox.Show("WRR NO Exist"); }
            else
            {
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
        }
        private void headerGrid_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void headerGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataRow dRow = null;
                String Code = headerGrid.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                GetProduct = Utils.BuildIndex("Select * from products", "product_id");
                if (GetProduct.TryGetValue(Code, out dRow))
                {

                    headerGrid.Rows[e.RowIndex].Cells[colDescription.Name].Value = dRow["description"].ToString();
                }


            }
            catch
            { }
        }

        private void headerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  warehouseCode,address  FROM Warehouses where warehouse_id = '" + txtWarehouse.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCodeR.Text = row["warehouseCode"].ToString();
                    txtAddressR.Text = row["address"].ToString();

                }
            }
            catch
            { }
        }

        private void txtwrrNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void headerGrid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtwrrNo_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.INWrrNoExist(txtwrrNo.Text))
            {
                e.Cancel = true;
                txtwrrNo.Focus();
                errorProvider1.SetError(txtwrrNo, "WRR No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtwrrNo, null);
            }
        }
    }
}
