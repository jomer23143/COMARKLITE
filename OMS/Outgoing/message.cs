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
    public partial class message : Form
    {
        public String status = "";
        //CrystalReport.Report dialog = new CrystalReport.Report();
        Outgoing.Invoicing invoice = new Outgoing.Invoicing();
        public message()
        {
            InitializeComponent();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printagain();
            DialogResult = DialogResult.OK;
        }

        public void printagain()
        {
            Dictionary<String, ReportDocument> viewer = new Dictionary<string, ReportDocument>();
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                System.Data.DataTable result = new System.Data.DataTable();
                result.Columns.Add(new DataColumn("SI", typeof(String)));
                result.Columns.Add(new DataColumn("Po", typeof(String)));
                result.Columns.Add(new DataColumn("SO", typeof(String)));
                //result.Columns.Add(new DataColumn("Wcode", typeof(String)));
                //result.Columns.Add(new DataColumn("PType", typeof(String)));
                //result.Columns.Add(new DataColumn("date", typeof(DateTime)));
                result.Columns.Add(new DataColumn("terms", typeof(String)));
                result.Columns.Add(new DataColumn("sr", typeof(String)));
                //result.Columns.Add(new DataColumn("terr", typeof(String)));
                //result.Columns.Add(new DataColumn("TStock", typeof(String)));
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
                result.Columns.Add(new DataColumn("total", typeof(String)));
                DataRow resultRow = result.NewRow();

                var dt = DataSupport.RunDataSet("select *,(SOtable.soqty * SOtable.price) as amount, (totalA - totalDis) as total from OutgoingShipmentRequests  join SOtable on OutgoingShipmentRequests.out_shipment_id = SOtable.out_shipment join TransportCustomers on OutgoingShipmentRequests.customer_id = TransportCustomers.custCode join Products on SOtable.product = Products.product_id where OutgoingShipmentRequests.docNo = '" + label2.Text + "'").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    resultRow = result.NewRow();
                    resultRow["SI"] = row["docNo"].ToString();
                    resultRow["Po"] = row["poNo"].ToString();
                    resultRow["SO"] = row["document_reference"].ToString();
                    //resultRow["Wcode"] = row[""].ToString();
                    resultRow["terms"] = row["terms"].ToString();
                    resultRow["sr"] = row["sr"].ToString();
                    resultRow["sold"] = row["customer"].ToString();
                    resultRow["contact"] = row["contactNo"].ToString();
                    resultRow["address"] = row["address"].ToString();
                    resultRow["tin"] = row["tinNo"].ToString();
                    resultRow["instruction"] = row["shippingInstruction"].ToString();
                    resultRow["totalD"] = row["amountD"].ToString();
                    resultRow["product"] = row["product_id"].ToString();
                    resultRow["description"] = row["description2"].ToString();
                    resultRow["uom"] = row["uom"].ToString();
                    resultRow["qty"] = row["soqty"].ToString();
                    resultRow["price"] = row["price"].ToString();
                    resultRow["amount"] = row["amount"].ToString();
                    resultRow["disc1"] = row["discount1"].ToString();
                    resultRow["disc2"] = row["discount2"].ToString();
                    resultRow["disc3"] = row["discount3"].ToString();
                    resultRow["disc4"] = row["discount4"].ToString();
                    resultRow["disc5"] = row["discount5"].ToString();
                    resultRow["tolD1"] = row["disc1"].ToString();
                    resultRow["tolD2"] = row["disc2"].ToString();
                    resultRow["tolD3"] = row["disc3"].ToString();
                    resultRow["tolD4"] = row["disc4"].ToString();
                    resultRow["tolD5"] = row["disc5"].ToString();
                    resultRow["totalA"] = row["totalA"].ToString();
                    resultRow["vat"] = row["vat"].ToString();
                    resultRow["totalDiscount"] = row["totalDis"].ToString();
                    resultRow["total"] = row["total"].ToString();
                    result.Rows.Add(resultRow);

                }
                //var viewer = new CrystalReport.Report();
                ReportDocument ReportDocs = new ReportDocument();
                ReportDocs = new CrystalReport.salesReport();
                ReportDocs.Database.Tables[0].SetDataSource(result);
                //viewer.Viewer.ReportSource = ReportDocs;
                viewer.Add(label2.Text, ReportDocs);
                //if (viewer._status == "save")
                //{
                //    updateCopies();
                //}
            }
            foreach (KeyValuePair<String, ReportDocument> name in viewer)
            {
                name.Value.PrintToPrinter(1, false, 1, 1);
                updateCopies();
            }
        }
        private void updateCopies()
        {
            StringBuilder sql = new StringBuilder();
            var primary = new List<string>();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("docNo", label2.Text);
            header.Add("copies", label3.Text);
            header.Add("printedDate", DateTime.Now);
            primary.Add("docNo");
            sql.Append(DataSupport.GetUpdate("OutgoingShipmentRequests", header, primary));
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void message_Load(object sender, EventArgs e)
        {

        }
    }
}
