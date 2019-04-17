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
    public partial class Report : Form
    {
        private string _holder;
        public string _status = "back";
        public Report()
        {
            InitializeComponent();
        }
       
        public Report(String Action)
        {
            InitializeComponent();
            _holder = Action;
        }
        public CrystalReportViewer Viewer
        {
            get { return this.crystalReportViewer1; }
            set { this.crystalReportViewer1 = value; }
        }
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            _status = "save";
            crystalReportViewer1.PrintReport();
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void Report_Load_1(object sender, EventArgs e)
        {

        }
    }
}
