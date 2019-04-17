using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Framework;

namespace OMS.Outgoing
{
    public partial class Invoicing : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public String Code = "";
        String customercode = "";
        String status = "";
        String no = "";
        String so = "";
        
        public Invoicing()
        {
            InitializeComponent();
            display();
            design();
            DoubleBuffered(dataGridView1, true);
        }

        private void Invoicing_Load(object sender, EventArgs e)
        {

        }
        public new void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void design()
        {
            DataGridViewCellStyle style =
            dataGridView1.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Calibri", 11F, FontStyle.Bold);
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("SELECT [document_reference],[docNo],[status],[copies],[printedDate],[customer_id] FROM OutgoingShipmentRequests").Tables[0];
            dataGridView1.DataSource = _bs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bs.Filter = "status LIKE '%" + textBox1.Text +"%'";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Dictionary<String, ReportDocument> viewer = new Dictionary<string, ReportDocument>();
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(rows.Cells[colchecked.Name].Value) == true)
                {
                    Code = rows.Cells[colinvoice.Name].Value.ToString();
                    copies = DataSupport.RunDataSet("Select isnull(max(copies),0) + 1 from OutgoingShipmentRequests where docNo ='"+ Code + "'").Tables[0].Rows[0][0].ToString();
                    if (status == "FOR STOCK CHECKING")
                    { }
                    else
                    {
                        //if (Convert.ToInt32(no) > 0)
                        //{
                        //    var dialog = new Outgoing.message();
                        //    dialog.label2.Text = Code;
                        //    foreach (DataGridViewRow data in dataGridView1.Rows)
                        //    {

                        //            if (dataGridView1.Rows.IndexOf(data) == dataGridView1.Rows.Count - 1)
                        //                break;
                        //            //this.dataGridView1.Rows[e.RowIndex].Selected = true;
                        //            //String[] datas = new String[dialog.dataGridView1.ColumnCount];
                        //            //data.Cells["colchecked"].Value.ToString();
                        //            data.Cells["colso"].Value.ToString();
                        //            data.Cells["colstatus"].Value.ToString();
                        //            data.Cells["colinvoice"].Value.ToString();
                        //            data.Cells["colcopies"].Value.ToString();
                        //            data.Cells["colprintlast"].Value.ToString();
                        //            dialog.dataGridView1.Rows.Add(data);
                        //    }
                        //    //dialog.label3.Text = copies;
                        //    dialog.ShowDialog();
                        //        display();
                        //}
                        //else
                        //{
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

                            var dt = DataSupport.RunDataSet("select *,(SOtable.soqty * SOtable.price) as amount, (totalA - totalDis) as total from OutgoingShipmentRequests  join SOtable on OutgoingShipmentRequests.out_shipment_id = SOtable.out_shipment join TransportCustomers on OutgoingShipmentRequests.customer_id = TransportCustomers.custCode join Products on SOtable.product = Products.product_id where OutgoingShipmentRequests.docNo = '" + Code + "'").Tables[0];
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

                            ReportDocument ReportDocs = new ReportDocument();
                            ReportDocs = new CrystalReport.salesReport();
                            ReportDocs.Database.Tables[0].SetDataSource(result);
                            viewer.Add(Code, ReportDocs);
                            //viewer.Viewer.ReportSource = ReportDocs;
                            //viewer.ShowDialog();     
                            //if (viewer._status == "save")
                            //{
                            //    updateCopies();
                            //    display();
                            //}
                            //}
                        }
                    }
                //}
                else
                {
                }
            }
            foreach (KeyValuePair<String, ReportDocument> name in viewer)
            {
                //name.Value.PrintToPrinter(1, false, 1, 1);
                updateCopies();
                display();
            }
        }
        String copies = "";
        private void updateCopies()
        {
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(rows) == dataGridView1.Rows.Count-1)
               break;
                Code = rows.Cells[colinvoice.Name].Value.ToString();
                copies = DataSupport.RunDataSet("Select isnull(max(copies),0) + 1 from OutgoingShipmentRequests where docNo ='" + Code + "'").Tables[0].Rows[0][0].ToString();
                StringBuilder sql = new StringBuilder();
                var primary = new List<string>();
                Dictionary<String, Object> header = new Dictionary<string, object>();
                header.Add("docNo", Code);
                header.Add("copies", copies);
                header.Add("printedDate", DateTime.Now);
                primary.Add("docNo");
                sql.Append(DataSupport.GetUpdate("OutgoingShipmentRequests", header, primary));
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            }
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //so = dataGridView1.Rows[e.RowIndex].Cells[colso.Name].Value.ToString();
                //Code = dataGridView1.Rows[e.RowIndex].Cells[colinvoice.Name].Value.ToString();
                customercode = dataGridView1.Rows[e.RowIndex].Cells[colcustcode.Name].Value.ToString();
                
                status = dataGridView1.Rows[e.RowIndex].Cells[colstatus.Name].Value.ToString();
                no = dataGridView1.Rows[e.RowIndex].Cells[colcopies.Name].Value.ToString();
               
                    var dialog = new Outgoing.message();
                    dialog.dataGridView1.Rows.Clear();
                   

            }
            catch
            { }
        }
        public void printagain()
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

            var dt = DataSupport.RunDataSet("select *,(SOtable.soqty * SOtable.price) as amount, (totalA - totalDis) as total from OutgoingShipmentRequests  join SOtable on OutgoingShipmentRequests.out_shipment_id = SOtable.out_shipment join TransportCustomers on OutgoingShipmentRequests.customer_id = TransportCustomers.custCode join Products on SOtable.product = Products.product_id where OutgoingShipmentRequests.docNo = '" + Code + "'").Tables[0];
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
            var viewer = new CrystalReport.Report();
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new CrystalReport.salesReport();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.ShowDialog();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ALL")
            {
                _bs.Filter = "status LIKE '%" +"FOR SCHEDULING"+ "%' or status LIKE '%"+"FOR STOCK CHECKING"+"%' or status LIKE '%"+"FOR RELEASING"+"'";
            }
            else if (comboBox1.Text == "FOR SCHEDULING")
            {
                dataGridView1.Refresh();
                _bs.Filter = "status LIKE '%" + "FOR SCHEDULING" + "%'";
            }
            else
            {
                dataGridView1.Refresh();
                _bs.Filter = "status LIKE '%" + "FOR STOCK CHECKING" + "%'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, ReportDocument> viewer = new Dictionary<string, ReportDocument>();
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(rows) == dataGridView1.Rows.Count - 1)
                    break;
                if (Convert.ToBoolean(rows.Cells[colchecked.Name].Value) == true)
                {
                    Code = rows.Cells[colinvoice.Name].Value.ToString();
                  
                    so = rows.Cells[colso.Name].Value.ToString();
                    System.Data.DataTable result = new System.Data.DataTable();
                    result.Columns.Add(new DataColumn("so", typeof(String)));
                    result.Columns.Add(new DataColumn("product", typeof(String)));
                    result.Columns.Add(new DataColumn("description", typeof(String)));
                    result.Columns.Add(new DataColumn("uom", typeof(String)));
                    result.Columns.Add(new DataColumn("qty", typeof(int)));
                    DataRow resultRow = result.NewRow();
                    var dt = DataSupport.RunDataSet(" select * from OutgoingShipmentRequests join SOtable on OutgoingShipmentRequests.out_shipment_id = SOtable.out_shipment join Products on SOtable.product = Products.product_id where document_reference = '" + so + "'").Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        resultRow = result.NewRow();
                        resultRow["so"] = row["document_reference"].ToString();
                        resultRow["product"] = row["product"].ToString();
                        resultRow["description"] = row["description"].ToString();
                        resultRow["uom"] = row["uom"].ToString();
                        resultRow["qty"] = row["soqty"].ToString();
                        result.Rows.Add(resultRow);
                    }
                    ReportDocument ReportDocs = new ReportDocument();
                    ReportDocs = new CrystalReport.ConversionReport();
                    ReportDocs.Database.Tables[0].SetDataSource(result);
                    //viewer1.Viewer.ReportSource = ReportDocs;
                    viewer.Add(so, ReportDocs);
                    
                }
            }
            foreach (KeyValuePair<String, ReportDocument> name in viewer)
            {
                name.Value.PrintToPrinter(1, false, 1, 1);
                updateCopies();
                display();
            }
        }
    }
}
