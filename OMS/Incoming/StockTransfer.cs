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
                var dt = DataSupport.RunDataSet("Select description from Warehouses ").Tables[0];
                cbxSource.DataSource = dt;
                cbxSource.DisplayMember = "description";
                cbxSource.ValueMember = "description";
            }
            {
                var dt = DataSupport.RunDataSet("select customer from TransportCustomers ").Tables[0];
                cbxReceived.DataSource = dt;
                cbxReceived.DisplayMember = "customer";
                cbxReceived.ValueMember = "customer";
            }
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
            saved();
            Clear();
        }
        private void saved()
        {
            MessageBox.Show(WhsID.ToString());
            String transID = DataSupport.GetNextMenuCodeInt("STR-OUT");
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("shipment_id", transID);
            header.Add("warehouse", WhsID);
            header.Add("document_reference", txtRefNR.Text);
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
            dataGridView1.Rows.Clear();

        }
        private void cbxSource_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                var dt = DataSupport.RunDataSet("Select warehouse_id,warehouseCode,address from Warehouses where description = '" + cbxSource.Text + "' ").Tables[0];
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
