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
    public partial class Form1 : Form
    {
        public Outgoing.SalerProcessing parent = null;
        public Incoming.NewIncomingWindow INC = null;
        public Outgoing.DeliveryProcessing DR = null;
        public static bool status = false;
        public int mode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrintPreview.Select();
            if (mode == 1)
            {
                Sales();
            }
            else if (mode == 2)
            {
                Incoming();
            }
            else if (mode == 3)
            {
                DRSales();
            }
            else if (mode == 4)
            {
                SalesReport();
            }



        }
        private void Sales()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table'>");

            sb.Append("<thead>");
            sb.Append("<tr>");

            {
                foreach (DataGridViewColumn col in parent.dataGridView1.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(col.HeaderText);
                    sb.Append("</th>");
                }
            }

            sb.Append("</tr>");
            sb.Append("</thead>");
            {
                foreach (DataGridViewRow row in parent.dataGridView1.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataGridViewColumn col in parent.dataGridView1.Columns)
                    {
                        sb.Append("<td>");
                        sb.Append(row.Cells[parent.dataGridView1.Columns.IndexOf(col)].Value);
                        sb.Append("</td>");
                    }

                    sb.Append("</tr>");
                }
            }

            sb.Append("</table>");

            webBrowser1.DocumentText = Properties.Resources.Sales
               .Replace("[Invoice]", parent.txtSalesInvoice.Text)
               .Replace("[run_datetime]", DateTime.Now.ToString())
               .Replace("[Sold_To]", parent.txtSoldTo.Text)
               .Replace("[cust_no]", parent.txtCustNo.Text)
               .Replace("[Address]", parent.txtCustAddress.Text)
               .Replace("[Tin]", parent.txtTin.Text)
               .Replace("[Shipping]", parent.txtInstruction.Text)
               .Replace("[SoNo]", parent.txtSoNo.Text)
               .Replace("[Terms]", parent.txtTerms.Text)
               .Replace("[PoNo]", parent.txtPoNo.Text)
               .Replace("[SR]", parent.txtSR.Text)
               .Replace("[WHSE]", parent.cbxWarehouse.Text)
               .Replace("[TERR]", parent.txtTerrCode.Text)
               .Replace("[Sales_table]", sb.ToString())
               .Replace("[discount1]", parent.discount[0].ToString())
               .Replace("[discount2]", parent.discount[1].ToString())
               .Replace("[discount3]", parent.discount[2].ToString())
               .Replace("[discount4]", parent.discount[3].ToString())
               .Replace("[discount5]", parent.discount[4].ToString())
               .Replace("[dicsValue1]", parent.totaldisc[0].ToString())
               .Replace("[dicsValue2]", parent.totaldisc[1].ToString())
               .Replace("[dicsValue3]", parent.totaldisc[2].ToString())
               .Replace("[dicsValue4]", parent.totaldisc[3].ToString())
               .Replace("[dicsValue5]", parent.totaldisc[4].ToString())
               .Replace("[totalAmount]", parent.txtTotalA.Text)
               .Replace("[Discount]", parent.txtDiscount.Text)
               .Replace("[VAT]", parent.txtVat.Text)
               .Replace("[Amount]", parent.txtAmountD.Text)

               ;
        }
        private void SalesReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table'>");

            //sb.Append("<thead>");
            //sb.Append("<tr>");

            //{
            //    foreach (DataGridViewColumn col in parent.dataGridView1.Columns)
            //    {
            //        sb.Append("<th>");
            //        sb.Append(col.HeaderText);
            //        sb.Append("</th>");
            //    }
            //}

            //sb.Append("</tr>");
            //sb.Append("</thead>");
            {
                foreach (DataGridViewRow row in parent.dataGridView1.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataGridViewColumn col in parent.dataGridView1.Columns)
                    {
                        sb.Append("<td>");
                        sb.Append(row.Cells[parent.dataGridView1.Columns.IndexOf(col)].Value);
                        sb.Append("</td>");
                    }

                    sb.Append("</tr>");
                }
            }

            sb.Append("</table>");

            webBrowser1.DocumentText = Properties.Resources.salesReport
               .Replace("[Invoice]", parent.txtSalesInvoice.Text)
               .Replace("[run_datetime]", DateTime.Now.ToString())
               .Replace("[Sold_To]", parent.txtSoldTo.Text)
               .Replace("[cust_no]", parent.txtCustNo.Text)
               .Replace("[Address]", parent.txtCustAddress.Text)
               .Replace("[Tin]", parent.txtTin.Text)
               .Replace("[Shipping]", parent.txtInstruction.Text)
               .Replace("[SoNo]", parent.txtSoNo.Text)
               .Replace("[Terms]", parent.txtTerms.Text)
               .Replace("[PoNo]", parent.txtPoNo.Text)
               .Replace("[SR]", parent.txtSR.Text)
               .Replace("[WHSE]", parent.cbxWarehouse.Text)
               .Replace("[TERR]", parent.txtTerrCode.Text)
               .Replace("[Sales_table]", sb.ToString())
               .Replace("[discount1]", parent.discount[0].ToString())
               .Replace("[discount2]", parent.discount[1].ToString())
               .Replace("[discount3]", parent.discount[2].ToString())
               .Replace("[discount4]", parent.discount[3].ToString())
               .Replace("[discount5]", parent.discount[4].ToString())
               .Replace("[dicsValue1]", parent.totaldisc[0].ToString())
               .Replace("[dicsValue2]", parent.totaldisc[1].ToString())
               .Replace("[dicsValue3]", parent.totaldisc[2].ToString())
               .Replace("[dicsValue4]", parent.totaldisc[3].ToString())
               .Replace("[dicsValue5]", parent.totaldisc[4].ToString())
               .Replace("[totalAmount]", parent.txtTotalA.Text)
               .Replace("[Discount]", parent.txtDiscount.Text)
               .Replace("[VAT]", parent.txtVat.Text)
               .Replace("[Amount]", parent.txtAmountD.Text)

               ;
        }
        private void Incoming()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table'>");

            sb.Append("<thead>");
            sb.Append("<tr>");

            {
                foreach (DataGridViewColumn col in INC.headerGrid.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(col.HeaderText);
                    sb.Append("</th>");
                }
            }

            sb.Append("</tr>");
            sb.Append("</thead>");
            {
                foreach (DataGridViewRow row in INC.headerGrid.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataGridViewColumn col in INC.headerGrid.Columns)
                    {
                        sb.Append("<td>");
                        sb.Append(row.Cells[INC.headerGrid.Columns.IndexOf(col)].Value);
                        sb.Append("</td>");
                    }

                    sb.Append("</tr>");
                }
            }

            sb.Append("</table>");

            webBrowser1.DocumentText = Properties.Resources.incoming
                .Replace("[typeStocks]", INC.txtTypeStocks.Text)
                .Replace("[WRR]", INC.txtwrrNo.Text)
                .Replace("[source]",INC.txtShipper.Text)
                .Replace("[Scode]",INC.txtCodeS.Text)
                .Replace("[SAddress]",INC.txtAddressS.Text)
                .Replace("[warehouse]", INC.txtShipper.Text)
                .Replace("[rcode]", INC.txtCodeS.Text)
                .Replace("[rAddress]", INC.txtAddressS.Text)
                .Replace("[document]",INC.txtReference.Text)
                .Replace("[date]",INC.txtDocDate.Text)
                .Replace("[Shipped_Via]",INC.txtShipped.Text)
                .Replace("[Incoming_table]",sb.ToString())
                .Replace("[type]",INC.txtIncomingType.Text)
                .Replace("[Received]",INC.txtReceived.Text)
                .Replace("[run_date]", DateTime.Now.ToString())
                ;
        }
        private void DRSales()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table'>");

            sb.Append("<thead>");
            sb.Append("<tr>");

            {
                foreach (DataGridViewColumn col in DR.dataGridView1.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(col.HeaderText);
                    sb.Append("</th>");
                }
            }

            sb.Append("</tr>");
            sb.Append("</thead>");
            {
                foreach (DataGridViewRow row in DR.dataGridView1.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataGridViewColumn col in DR.dataGridView1.Columns)
                    {
                        sb.Append("<td>");
                        sb.Append(row.Cells[DR.dataGridView1.Columns.IndexOf(col)].Value);
                        sb.Append("</td>");
                    }

                    sb.Append("</tr>");
                }
            }

            sb.Append("</table>");

            webBrowser1.DocumentText = Properties.Resources.drReport
                .Replace("[DRNo]",DR.txtDrno.Text)
                .Replace("[TypeofStock]",DR.txtTypeStock.Text)
                .Replace("[Destination]",DR.cbxCustName.Text)
                .Replace("[custCode]",DR.txtCodeD.Text)
                .Replace("[custAddress]",DR.txtAddressD.Text)
                .Replace("[refNo]",DR.txtRefno.Text)
                .Replace("[source]",DR.cbxWarehouse.Text)
                .Replace("[sourceCode]",DR.txtCodeS.Text)
                .Replace("[refDate]",DR.txtRefDate.Text)
                .Replace("[run_date]", DateTime.Now.ToString())
                .Replace("[Dr_Tables]",sb.ToString())
                .Replace("[reason]",DR.txtReason.Text)
                ;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            
            //webBrowser1.ShowPrintPreviewDialog();
            webBrowser1.ShowPrintDialog();
            DialogResult = DialogResult.OK;
            status = true;
        }
    }
}
