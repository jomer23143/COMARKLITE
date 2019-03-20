using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS.Outgoing
{
    public partial class DeliveryProcessing : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        Dictionary<String, DataRow> getWarehouse = new Dictionary<String, DataRow>();
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
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(Form1.status == true)
                { saved(); clear(); }
                else
                { }
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
            String DrId = DataSupport.GetNextMenuCodeInt("DR");
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("out_shipment_id", DrId);
            header.Add("warehouse", cbxWarehouse.Text);
            header.Add("typeStocks", txtTypeStock.Text);
            header.Add("datetime", DateTime.Now);
            header.Add("outgoing_type", "Delivery");
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
