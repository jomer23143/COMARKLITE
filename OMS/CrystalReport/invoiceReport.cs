using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OMS.CrystalReport
{
    public partial class invoiceReport : Form
    {
        private string _holder;
        public string _status = "back";
        public invoiceReport()
        {
            InitializeComponent();
        }
        public invoiceReport(String Action)
        {
            InitializeComponent();
            _holder = Action;
        }
        public CrystalReportViewer Viewer
        {
            get { return this.crystalReportViewer1; }
            set { this.crystalReportViewer1 = value; }
           
        }
        public CrystalReportViewer Viewer1
        {
            get { return this.crystalReportViewer2; }
            set { this.crystalReportViewer2 = value; }

        }
        private void invoiceReport_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            _status = "save";
            crystalReportViewer1.PrintReport();
            crystalReportViewer2.PrintReport();
            this.Close();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
