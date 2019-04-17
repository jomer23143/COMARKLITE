using OMS.Incoming;
using OMS.Outgoing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Reflection;

namespace OMS
{
    public partial class MainMenu : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnDeclareIncoming_Click(object sender, EventArgs e)
        {
            ManageIncomingWindow dialog = new ManageIncomingWindow();
            Openform(dialog);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageOutgoingWindow dialog = new ManageOutgoingWindow();
            Openform(dialog);
        }

        private void orderingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockTransfer dialog = new StockTransfer();
            Openform(dialog);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            btnDeclareIncoming.Visible = false;
            menuStrip1.Renderer = new Colors.RendererToolStrip();
            DoubleBuffered(headerGrid, true);
            DoubleBuffered(OutgoingDisplay, true);
            OutgoingDisplay.Visible = false;
            headerGrid.Visible = false;
            comboBox1.Visible = false;
        }
        public new void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void outgoing()
        {
            _bs.DataSource = DataSupport.RunDataSet("SELECT [out_shipment_id],[warehouse],[datetime]," +
                "[document_reference],[client],[authorized_tms],[remarks],[tms_trip_id],[tms_trip_date]," +
                "[wms_released_id],[wms_release_date],[customer_id],[customer_name],[customer_invoice_address]," +
                "[customer_delivery_address],[status],[document_reference_date],[outgoing_type],[docNo],[poNo]," +
                "[terms],[shippingInstruction],[amountD],[sr],[typeStocks]FROM [oms_db].[dbo].[OutgoingShipmentRequests]").Tables[0];
            OutgoingDisplay.DataSource = _bs;
        }
        private void incoming()
        {
            _bs.DataSource = DataSupport.RunDataSet("SELECT shipment_id,wrrNo,warehouse," +
                "datetime,document_reference,client,Nr,authorized_shipper,incoming_type," +
                "typeStocks,received,received_on,status,document_reference_date," +
                "custName,issued,dateIssued,pickUp,datePick,shippedVia FROM " +
                "IncomingShipmentRequests").Tables[0];
                headerGrid.DataSource = _bs;
        }
        private void design()
        {
            DataGridViewCellStyle style =
            headerGrid.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);

        }
        private void designs()
        {
            DataGridViewCellStyle style =
            OutgoingDisplay.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }
        private void incomingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIncomingWindow dialog = new NewIncomingWindow();
            Openform(dialog);
        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalerProcessing dialog = new SalerProcessing();
            Openform(dialog);
        }

        private void deliveryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryProcessing dialog = new DeliveryProcessing();
            DeliveryProcessing.form = "";
            Openform(dialog);
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returns dialog = new Returns();
            Openform(dialog);
        }

        private void stockTransferListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Incoming.ManageIncomingWindow();
            Openform(dialog);
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (RegistrationSupport.userType.ToLower().Trim() == "admin")
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.F12)
                {
                    var dialog = new Registration();
                    Openform(dialog);
                }
            }
          
        }

        private void returnsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new Outgoing.ManageOutgoingWindow();
            ManageOutgoingWindow.form = "MOP";
            Openform(dialog);
        }

        private void salesInvoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deliveryListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new MAster.ListProducts();
            Openform(dialog);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new MAster.ListCustomer();
            Openform(dialog);
        }
        private void Openform(Form form)
        {
            form.MdiParent = this;
            form.Activate();
            form.Show();
            Refresh();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialog = new Login();
            dialog.Show();
        }

        private void stockTransferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new Outgoing.DeliveryProcessing();
            dialog.Text = "Stock Transfer";
            dialog.label4.Text = "Str No:";
            DeliveryProcessing.form = "STR";
            dialog.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Reports.summary();
            Openform(dialog);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "INCOMING")
            {
                incoming();
                //design();
                headerGrid.Show();
                OutgoingDisplay.Hide();
            }
            else if(comboBox1.Text == "OUTGOING")
            {
                
                outgoing();
                //designs();
                OutgoingDisplay.Show();
                headerGrid.Hide();

            }
        }

        private void OutgoingDisplay_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void OutgoingDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                var dialog = new Outgoing.Conversion();
                String Code = OutgoingDisplay.Rows[e.RowIndex].Cells[coloutshipid.Name].Value.ToString();
                var dts = DataSupport.RunDataSet("Select docNo from OutgoingShipmentRequests where out_shipment_id = '"+Code+"'").Tables[0];
                foreach(DataRow rows in dts.Rows)
                {
                dialog.textBox1.Text = rows["docNo"].ToString();
                }
                var dt = DataSupport.RunDataSet("Select product,description,newqty,newuom,expected_qty,uom from OutgoingShipmentRequestDetails join Products on OutgoingShipmentRequestDetails.product = Products.product_id where OutgoingShipmentRequestDetails.out_shipment = '" + Code + "'").Tables[0];
                dialog.dataGridView1.DataSource = dt;
                dialog.ShowDialog();
        }

        private void invoicingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Outgoing.Invoicing();
            Openform(dialog);
        }
    }
}
