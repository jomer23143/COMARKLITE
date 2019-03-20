using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace OMS.Outgoing
{
    public partial class ManageOutgoingWindow : Form
    {

        private readonly BindingSource _bs = new BindingSource();
        public ManageOutgoingWindow()
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
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("SELECT [out_shipment_id],[warehouse],[datetime],[document_reference],[client],[authorized_tms],[remarks],[tms_trip_id],[tms_trip_date],[wms_released_id],[wms_release_date],[customer_id],[customer_name],[customer_invoice_address],[customer_delivery_address],[status],[document_reference_date],[outgoing_type],[docNo],[poNo],[terms],[shippingInstruction],[amountD],[sr],[typeStocks]FROM [oms_db].[dbo].[OutgoingShipmentRequests]").Tables[0];
            headerGrid.DataSource = _bs;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NewOutgoingWindow dialog = new NewOutgoingWindow();
            dialog.ShowDialog();
            display();
        }

        private void ManageOutgoingWindow_Load(object sender, EventArgs e)
        {
            //headerGrid.DataSource = DataSupport.RunDataSet("SELECT * FROM OutgoingShipmentRequests").Tables[0];
            display();
            btnNew.Visible = false;
            DoubleBuffered(headerGrid, true);

        }
        public void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ///* headerGrid.DataSource = DataSupport.RunDataSet("SELECT * FROM OutgoingShipmentRequests").Tables[0]*/;
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            _bs.Filter = "out_shipment_id LIKE '%" + txtSearch.Text + "%' OR document_reference LIKE '%" + txtSearch.Text + "%' OR docNo LIKE '%" + txtSearch.Text +"%'";
        }

        private void salesProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOutgoingWindow dialog = new NewOutgoingWindow();
            dialog.ShowDialog();
            display();
        }

        private void headerGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }

        private void headerGrid_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void headerGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
