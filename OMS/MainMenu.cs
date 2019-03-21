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
namespace OMS
{
    public partial class MainMenu : Form
    {
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
    }
}
