using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OMS.Incoming
{
    public partial class ManageIncomingWindow : Form
    {
        private readonly BindingSource _bs = new BindingSource();

        public ManageIncomingWindow()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NewIncomingWindow dialog = new NewIncomingWindow();
            dialog.ShowDialog();
            display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //headerGrid.DataSource = DataSupport.RunDataSet("SELECT * FROM IncomingShipmentRequests").Tables[0];
            display();
        }

        private void ManageIncomingWindow_Load(object sender, EventArgs e)
        {
            display();
            //btnRefresh.Visible = false;
            btnNew.Visible = false;
           
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("SELECT [shipment_id],[wrrNo],[warehouse],[datetime],[document_reference],[client],[authorized_shipper],[incoming_type],[typeStocks],[received],[received_on],[status],[document_reference_date],[custName],[issued],[dateIssued],[pickUp],[datePick],[shippedVia] FROM [oms_db].[dbo].[IncomingShipmentRequests]").Tables[0];
            headerGrid.DataSource = _bs;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bs.Filter = "shipment_id LIKE '%" + txtSearch.Text + "%' OR warehouse LIKE'%" + txtSearch.Text + "%' OR document_reference LIKE'%" + txtSearch.Text + "%' or wrrno LIKE '%" + txtSearch.Text +"%'";
        }

        private void incomingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIncomingWindow dialog = new NewIncomingWindow();
            dialog.ShowDialog();
            display();
        }

        private void headerGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
