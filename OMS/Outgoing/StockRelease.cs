using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Framework;

namespace OMS.Outgoing
{
    public partial class StockRelease : Form
    {
        public Outgoing.SalerProcessing sales = null;
        public Outgoing.Conversion conversion = null;
        public String status = "back";
        public StockRelease()
        {
            InitializeComponent();
        }
        public DataTable Unconverted { get; set; }
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            invoiceReport();
        }
        private void invoiceReport()
        {
            System.Data.DataTable results = new System.Data.DataTable();
            results.Columns.Add(new DataColumn("so", typeof(String)));
            results.Columns.Add(new DataColumn("product", typeof(String)));
            results.Columns.Add(new DataColumn("description", typeof(String)));
            results.Columns.Add(new DataColumn("uom", typeof(String)));
            results.Columns.Add(new DataColumn("qty", typeof(int)));
            DataRow resultRows = results.NewRow();
            resultRows = results.NewRow();
            resultRows["so"] = conversion.textBox1.Text;
            results.Rows.Add(resultRows);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                resultRows = results.NewRow();
                resultRows["product"] = row.Cells["colCode"].Value;
                resultRows["description"] = row.Cells["colDescription"].Value;
                resultRows["uom"] = row.Cells["colnewuom"].Value;
                resultRows["qty"] = row.Cells["colnewqty"].Value;
                results.Rows.Add(resultRows);
            }
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("SI", typeof(String)));
            result.Columns.Add(new DataColumn("Po", typeof(String)));
            result.Columns.Add(new DataColumn("SO", typeof(String)));
            result.Columns.Add(new DataColumn("Wcode", typeof(String)));
            result.Columns.Add(new DataColumn("PType", typeof(String)));
            result.Columns.Add(new DataColumn("date", typeof(DateTime)));
            result.Columns.Add(new DataColumn("terms", typeof(String)));
            result.Columns.Add(new DataColumn("sr", typeof(String)));
            result.Columns.Add(new DataColumn("terr", typeof(String)));
            result.Columns.Add(new DataColumn("TStock", typeof(String)));
            result.Columns.Add(new DataColumn("sold", typeof(String)));
            result.Columns.Add(new DataColumn("contact", typeof(String)));
            result.Columns.Add(new DataColumn("address", typeof(String)));
            result.Columns.Add(new DataColumn("tin", typeof(String)));
            result.Columns.Add(new DataColumn("instruction", typeof(String)));
            result.Columns.Add(new DataColumn("product", typeof(String)));
            result.Columns.Add(new DataColumn("description", typeof(String)));
            result.Columns.Add(new DataColumn("uom", typeof(String)));
            result.Columns.Add(new DataColumn("qty", typeof(int)));
            result.Columns.Add(new DataColumn("price", typeof(Decimal)));
            result.Columns.Add(new DataColumn("amount", typeof(Decimal)));
            result.Columns.Add(new DataColumn("disc1", typeof(String)));
            result.Columns.Add(new DataColumn("disc2", typeof(String)));
            result.Columns.Add(new DataColumn("disc3", typeof(String)));
            result.Columns.Add(new DataColumn("disc4", typeof(String)));
            result.Columns.Add(new DataColumn("disc5", typeof(String)));
            result.Columns.Add(new DataColumn("tolD1", typeof(String)));
            result.Columns.Add(new DataColumn("tolD2", typeof(String)));
            result.Columns.Add(new DataColumn("tolD3", typeof(String)));
            result.Columns.Add(new DataColumn("tolD4", typeof(String)));
            result.Columns.Add(new DataColumn("tolD5", typeof(String)));
            result.Columns.Add(new DataColumn("totalA", typeof(String)));
            result.Columns.Add(new DataColumn("vat", typeof(String)));
            result.Columns.Add(new DataColumn("totalDiscount", typeof(String)));
            result.Columns.Add(new DataColumn("totalD", typeof(String)));
            DataRow resultRow = result.NewRow();
            resultRow = result.NewRow();
            resultRow["SI"] = sales.txtSalesInvoice.Text;
            resultRow["sold"] = sales.txtSoldTo.Text;
            resultRow["contact"] = sales.txtCustNo.Text;
            resultRow["tin"] = sales.txtTin.Text;
            resultRow["address"] = sales.txtCustAddress.Text;
            resultRow["instruction"] = sales.txtInstruction.Text;
            resultRow["SO"] = sales.txtSoNo.Text;
            resultRow["Po"] = sales.txtPoNo.Text;
            resultRow["Wcode"] = sales.cbxWarehouse.Text;
            resultRow["terms"] = sales.cbxterms.Text;
            resultRow["sr"] = sales.txtSR.Text;
            result.Rows.Add(resultRow);
            foreach (DataGridViewRow dRow in sales.dataGridView1.Rows)
            {
                if (sales.dataGridView1.Rows.IndexOf(dRow) == sales.dataGridView1.Rows.Count - 1)
                    break;
                resultRow = result.NewRow();
                resultRow["product"] = dRow.Cells["colCode"].Value.ToString();
                resultRow["description"] = dRow.Cells["colDescription"].Value.ToString();
                resultRow["uom"] = dRow.Cells["colUnit"].Value.ToString();
                resultRow["qty"] = dRow.Cells["colQuantity"].Value.ToString();
                resultRow["price"] = dRow.Cells["colPrice"].Value.ToString();
                resultRow["amount"] = dRow.Cells["colAmount"].Value.ToString();
                result.Rows.Add(resultRow);
            }
            resultRow = result.NewRow();
            resultRow["disc1"] = sales.discount[0].ToString();
            resultRow["disc2"] = sales.discount[1].ToString();
            resultRow["disc3"] = sales.discount[2].ToString();
            resultRow["disc4"] = sales.discount[3].ToString();
            resultRow["disc5"] = sales.discount[4].ToString();
            resultRow["tolD1"] = sales.totaldisc[0].ToString();
            resultRow["tolD2"] = sales.totaldisc[1].ToString();
            resultRow["tolD3"] = sales.totaldisc[2].ToString();
            resultRow["tolD4"] = sales.totaldisc[3].ToString();
            resultRow["tolD5"] = sales.totaldisc[4].ToString();
            resultRow["totalA"] = sales.txtTotalA.Text;
            resultRow["totalDiscount"] = sales.txtDiscount.Text;
            resultRow["vat"] = sales.txtVat.Text;
            resultRow["totalD"] = sales.txtAmountD.Text;
            result.Rows.Add(resultRow);
            var viewer = new CrystalReport.invoiceReport();
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new CrystalReport.salesReport();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;

            ReportDocs = new CrystalReport.ConversionReport();
            ReportDocs.Database.Tables[0].SetDataSource(results);
            viewer.Viewer1.ReportSource = ReportDocs;
            viewer.ShowDialog();
            status = viewer._status;
            DialogResult = DialogResult.OK;
        }
        private void SOREPORT()
        {
           
            //var viewer = new CrystalReport.invoiceReport();
            //ReportDocument ReportDocs = new ReportDocument();
           
            //viewer.ShowDialog();
        }
        private void StockRelease_Load(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = Unconverted;
           
        }
    }
}
