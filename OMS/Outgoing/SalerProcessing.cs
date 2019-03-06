using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Drawing.Printing;

namespace OMS.Outgoing
{
    public partial class SalerProcessing : Form
    {
        Dictionary<String, DataRow> GetProduct = new Dictionary<String, DataRow>();
        Dictionary<String, DataRow> GetProducts1 = new Dictionary<String, DataRow>();
        Dictionary<String, DataRow> UOMs = new Dictionary<String, DataRow>();
        private readonly BindingSource bs = new BindingSource();
        public SalerProcessing()
        {
            InitializeComponent();
        }

        private void SalerProcessing_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("SELECT  customer FROM TransportCustomers ").Tables[0];
                txtSoldTo.DataSource = dt;
                txtSoldTo.DisplayMember = "customer";
                txtSoldTo.ValueMember = "customer";
            }
            {
                var dt = DataSupport.RunDataSet("SELECT product_id FROM Products").Tables[0];
                colCode.DataSource = dt;
                colCode.DisplayMember = "product_id";
                colCode.ValueMember = "product_id";
            }
            {
                var dt = DataSupport.RunDataSet("SELECT transport_id FROM TransportProviders").Tables[0];
                cbxWarehouse.DataSource = dt;
                cbxWarehouse.DisplayMember = "transport_id";
                cbxWarehouse.ValueMember = "transport_id";
            }
            {
                var dt = DataSupport.RunDataSet("SELECT warehouse_id FROM Warehouses").Tables[0];
                txtWarehouse.DataSource = dt;
                txtWarehouse.DisplayMember = "warehouse_id";
                txtWarehouse.ValueMember = "warehouse_id";
            }
            priceType();
            uom();
            txtSalesInvoice.KeyPress += new KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);

          
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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
        public Double[] discount = new Double[5] { 0, 0, 0, 0, 0 };

        private new bool Validating()
        {
            bool result = true;

            var dt = DataSupport.RunDataSet("Select * from TransportCustomers where customer = '" + txtSoldTo.Text + "'").Tables[0];
            foreach (DataRow drow in dt.Rows)
            {
                discount[0] = Convert.ToDouble(drow["discount1"].ToString());
                discount[1] = Convert.ToDouble(drow["discount2"].ToString());
                discount[2] = Convert.ToDouble(drow["discount3"].ToString());
                discount[3] = Convert.ToDouble(drow["discount4"].ToString());
                discount[4] = Convert.ToDouble(drow["discount5"].ToString());
            }
            return result;
        }

        Double amountD =  0;
        public Double[] totaldisc = new Double[6] { 0, 0, 0, 0, 0, 0 };
        private Double compute()
        {
           
            Double total = 0.00;
            Double sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total = Convert.ToDouble(row.Cells[colQuantity.Name].Value) * Convert.ToDouble(row.Cells[colPrice.Name].Value);
                row.Cells[colAmount.Name].Value = total;
                sum += Convert.ToDouble(row.Cells[colAmount.Name].Value.ToString());
            }

            Double[] totalD = new Double[6] {0,0,0,0,0,0};
            totalD[0] = (discount[0] / 100) * -sum + sum;
            //disccount 1
            totaldisc[0] = (discount[0] / 100) * sum;
            totalD[1] = (totalD[0] -(discount[1] / 100) * totalD[0]);
            //discount 2
            totaldisc[1] = (discount[1] / 100) * totalD[0];
            totalD[2] = (totalD[1] -(discount[2] / 100) * totalD[1]);
            //discount 3
            totaldisc[2] = (discount[2] / 100) * totalD[1];
            totalD[3] = (totalD[2] -(discount[3] / 100) * totalD[2]) ;
            //discount 4
            totaldisc[3] = (discount[3] / 100) * totalD[2];
            totalD[4] = (totalD[3] -(discount[4] / 100) * totalD[3]);
            //discount4
            totaldisc[4] = (discount[4] / 100) * totalD[3];
            //add to total discount
            totaldisc[5] = totaldisc[0] + totaldisc[1] + totaldisc[2] + totaldisc[3] + totaldisc[4];
            //vat
            Double vat = 0;
            vat = totalD[4] * .12;
            totalD[5] = (totalD[4] * .12) + totalD[4];
            //total amount
            txtTotalA.Text = String.Format("Total Amount : " + sum.ToString("C2"));
            //total discount
            txtDiscount.Text = String.Format("Discount : " + totaldisc[5].ToString("C2"));
            //total vat
            txtVat.Text =  String.Format("VAT : " + vat.ToString("C2"));
            //total amount due
            amountD = totalD[5];
            txtAmountD.Text = totalD[5].ToString("C2");

            return totalD[5];
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            Form1 dialog = new Form1();
            dialog.parent = this;
            dialog.mode = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(Form1.status == true)
                { saved(); clear(); }
            }
          
        }
        private void saved()
        {
            String siId = DataSupport.GetNextMenuCodeInt("INVOICE");
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("out_shipment_id", siId);
            header.Add("warehouse", "CEB1");
            header.Add("datetime", DateTime.Now);
            header.Add("outgoing_type", "SALES INVOICE");
            header.Add("docNo", txtSalesInvoice.Text);
            header.Add("document_reference", txtSoNo.Text);
            header.Add("document_reference_date", txtDateS.Text);
            header.Add("authorized_tms", cbxWarehouse.Text);
            header.Add("client", "COMARK");
            header.Add("terms", txtTerms.Text);
            header.Add("poNo", txtPoNo.Text);
            header.Add("sr", txtSR.Text);
            header.Add("terrCode", txtTerrCode.Text);
            header.Add("customer_id", custCode);
            header.Add("customer_name", txtSoldTo.Text);
            header.Add("contactNo", txtCustNo.Text);
            header.Add("customer_invoice_address", txtCustAddress.Text);
            header.Add("disc1", "");
            header.Add("disc2", "");
            header.Add("disc3", "");
            header.Add("disc4", "");
            header.Add("disc5", "");
            header.Add("shippingInstruction", txtInstruction.Text);
            header.Add("amountD", amountD);
            header.Add("typeStocks", txtTypeStock.Text);
            header.Add("status", "FOR STOCK CHECKING");

            sql.Append(DataSupport.GetInsert("OutgoingShipmentRequests", header));
            //String TransId = FAQ.GetNextReturnID(0);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;

                Dictionary<String, Object> detail = new Dictionary<String, Object>();
                detail.Add("out_shipment", siId);
                detail.Add("product", row.Cells[colCode.Name].Value.ToString());
                detail.Add("uom", row.Cells[colUnit.Name].Value.ToString());
                if (string.IsNullOrEmpty(row.Cells[colQuantity.Name].Value as string))
                { detail.Add("expected_qty", "0"); }
                else
                { detail.Add("expected_qty", row.Cells[colQuantity.Name].Value.ToString()); } 
                detail.Add("price", row.Cells[colPrice.Name].Value.ToString());
                sql.Append(DataSupport.GetInsert("OutgoingShipmentRequestDetails", detail));
            }
            if (FAQ.InvoiceExist(txtSalesInvoice.Text))
            { MessageBox.Show("Invoice No is Exist"); }
            else
            {
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
            }
        }
        private void clear()
        {
            txtSalesInvoice.Clear();
            txtSoNo.Clear();
            txtPoNo.Clear();
            cbxWarehouse.SelectedIndex = -1;
            cbxpriceType.SelectedIndex = -1;
            txtTerms.Clear();
            txtTerrCode.Clear();
            txtSR.Clear();
            txtTypeStock.SelectedIndex = -1;
            txtSoldTo.SelectedIndex = -1;
            txtInstruction.Clear();
            dataGridView1.Rows.Clear();
            txtTotalA.Text = String.Format("Total Amount : 0.00");
            txtDiscount.Text = String.Format("Discount : 0.00");
            txtVat.Text = String.Format("VAT : 0.00");
            txtAmountD.Clear();
            txtCustNo.Text = null;
            txtCustAddress.Text = null;
            txtTin.Text = null;
        }
        String custCode;
        private bool GetProducts(String Pcode)
        {
       
                var dt = DataSupport.RunDataSet("select * from itemPrice i join products p on i.productID = p.product_id join uom U on i.uom = u.uom join priceType t on i.priceTypeId = t.priceTypeId where i.productID = '" + Pcode + "'").Tables[0];
                if (dt.Rows.Count > 0)
               
   
            return true;
            return false;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtSoldTo_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtSoldTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalesInvoice_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(cbxpriceType.SelectedValue.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoldTo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  custCode,address,contactNo,tinNo FROM TransportCustomers where customer = '" + txtSoldTo.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCustAddress.Text = row["address"].ToString();
                    txtCustNo.Text = row["contactNo"].ToString();
                    txtTin.Text = row["tinNo"].ToString();
                    custCode = row["custCode"].ToString();
                }
                Validating();
            }
            catch
            { }
        }

        private void txtSalesInvoice_Validating_1(object sender, CancelEventArgs e)
        {
            if (FAQ.InvoiceExist(txtSalesInvoice.Text))
            {
                e.Cancel = true;
                txtSalesInvoice.Focus();
                errorProvider1.SetError(txtSalesInvoice, "Invoice No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSalesInvoice, null);
            }
        }

        private void cbxpriceType_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
