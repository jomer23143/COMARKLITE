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
    public partial class Conversion : Form
    {
        public String status = "back";
        public Outgoing.SalerProcessing sales = null;
        public Conversion()
        {
            InitializeComponent();
            design();
            DoubleBuffered(dataGridView1, true);
            dataGridView2.Visible = false;
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            textBox2.Text = DataSupport.RunDataSet("Select ISNULL(max(conversionNo),0) + 1 from declarationofConversion").Tables[0].Rows[0][0].ToString();
                
        }

        private void Conversion_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult = DialogResult.OK;
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

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //System.Data.DataTable result = new System.Data.DataTable();
            //result.Columns.Add(new DataColumn("conversionNo", typeof(String)));
            //result.Columns.Add(new DataColumn("so", typeof(String)));
            //result.Columns.Add(new DataColumn("product", typeof(String)));
            //result.Columns.Add(new DataColumn("description", typeof(String)));
            //result.Columns.Add(new DataColumn("uom", typeof(String)));
            //result.Columns.Add(new DataColumn("qty", typeof(int)));
            //DataRow resultRow = result.NewRow();
            //resultRow = result.NewRow();
            //resultRow["so"] = textBox1.Text;
            //resultRow["conversionNo"] = textBox2.Text;
            //result.Rows.Add(resultRow);
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
            //        break;
            //    resultRow = result.NewRow();

            //    resultRow["product"] = row.Cells[colCode.Name].Value;
            //    resultRow["description"] = row.Cells[colDescription.Name].Value;
            //    resultRow["uom"] = row.Cells[colnewuom.Name].Value;
            //    resultRow["qty"] = row.Cells[colnewqty.Name].Value;
            //    result.Rows.Add(resultRow);
            //}
            //var viewer = new CrystalReport.Report();
            //ReportDocument ReportDocs = new ReportDocument();
            //ReportDocs = new CrystalReport.ConversionReport();
            //ReportDocs.Database.Tables[0].SetDataSource(result);
            //viewer.Viewer.ReportSource = ReportDocs;
            //viewer.ShowDialog();
            //status = viewer.di;
            //this.Close();
            stockrelease();


        }
        
        private void stockrelease()
        {
            var dialog = new Outgoing.StockRelease();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                String[] data = new String[dialog.dataGridView1.ColumnCount];
                data[0] = row.Cells[colCode.Name].Value.ToString();
                data[1] = row.Cells[colDescription.Name].Value.ToString();
                data[2] = row.Cells[colnewuom.Name].Value.ToString();
                data[3] = row.Cells[colnewqty.Name].Value.ToString();
                dialog.dataGridView1.Rows.Add(data);
            }
            foreach (DataGridViewRow rows in dataGridView2.Rows)
            {
                if (dataGridView2.Rows.IndexOf(rows) == dataGridView2.Rows.Count - 1)
                    break;
                String[] datas = new String[dialog.dataGridView1.ColumnCount];
                datas[0] = rows.Cells["prod"].Value.ToString();
                datas[1] = rows.Cells["des"].Value.ToString();
                datas[2] = rows.Cells["uom"].Value.ToString();
                datas[3] = rows.Cells["qty"].Value.ToString();
                dialog.dataGridView2.Rows.Add(datas);
            }
            //dialog.Unconverted = Unconverted;
            //dialog.sales = sales;
            //dialog.conversion = this;
            //dialog.ShowDialog();
            status = "save";
            DialogResult = DialogResult.OK;
        }
    }
}
