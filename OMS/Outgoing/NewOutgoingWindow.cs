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

namespace OMS.Outgoing
{
    public partial class NewOutgoingWindow : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        public NewOutgoingWindow()
        {
            InitializeComponent();
        }

        private void NewOutgoingWindow_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                foreach (DataRow row in dt.Rows)
                    product.Items.Add(row[0].ToString());
            }
            {
                var dt = DataSupport.RunDataSet("SELECT transport_id FROM TransportProviders").Tables[0];
                foreach (DataRow row in dt.Rows)
                    txtTransportProvider.Items.Add(row[0].ToString());
            }
            {
                var dt = DataSupport.RunDataSet("SELECT warehouse_id FROM Warehouses").Tables[0];
                foreach (DataRow row in dt.Rows)
                    txtWarehouse.Items.Add(row[0].ToString());
            }
        }

        private void txtTransportProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            String transporter_id = txtTransportProvider.Text;
            DataTable dt = DataSupport.RunDataSet("SELECT customer FROM TransportCustomers WHERE transport = '"+transporter_id+"'").Tables[0];

            txtCustomer.Items.Clear();
            foreach (DataRow row in dt.Rows)
                txtCustomer.Items.Add(row[0].ToString());
        } 

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            String outgoing_id = DataSupport.GetNextMenuCodeInt("DR");
            StringBuilder sql = new StringBuilder();


            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("out_shipment_id", outgoing_id);
            header.Add("warehouse", txtWarehouse.Text);
            header.Add("datetime", DateTime.Now);
            header.Add("document_reference", txtReference.Text);
            header.Add("client", txtClient.Text);
            header.Add("authorized_tms", txtTransportProvider.Text);
            header.Add("customer_id", txtCustomer.Text);
            header.Add("remarks", txtRemarks.Text);
            header.Add("outgoing_type", txOutgoingType.Text);
            header.Add("document_reference_date", txtDocDate.Text);
            header.Add("status", "FOR STOCK CHECKING");

            sql.Append(DataSupport.GetInsert("OutgoingShipmentRequests", header));

            foreach (DataGridViewRow row in headerGrid.Rows)
            {
                if (headerGrid.Rows.IndexOf(row) == headerGrid.Rows.Count - 1)
                    break;

                Dictionary<String, Object> detail = new Dictionary<string, object>();
                detail.Add("out_shipment", outgoing_id);
                detail.Add("product", row.Cells[product.Name].Value.ToString());
                detail.Add("uom", row.Cells[uom.Name].Value.ToString());
                detail.Add("expected_qty", row.Cells[qty.Name].Value.ToString());
                sql.Append(DataSupport.GetInsert("OutgoingShipmentRequestDetails", detail));
            }
            if (string.IsNullOrEmpty(txtWarehouse.Text) || string.IsNullOrEmpty(txtReference.Text))
            {
                MessageBox.Show("Please input all fields");
            }
            else
            {
                if (FAQ.OutDocumentReferenceExist(txtReference.Text))
                {
                    MessageBox.Show("Exist Document Reference");
                }
                else
                {
                    DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }

        private void headerGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow dRow = null;
                String Code = headerGrid.Rows[e.RowIndex].Cells["product"].Value.ToString();
                GetProduct = Utils.BuildIndex("Select * from products", "product_id");
                if (GetProduct.TryGetValue(Code, out dRow))
                {
                    
                    headerGrid.Rows[e.RowIndex].Cells["colDescription"].Value = dRow["description"].ToString();

                }
            }
            catch
            { }
          
        }
    }
}
