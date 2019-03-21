using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS.MAster
{
    public partial class Customer : Form
    {
        public String Mode = "";
        public Customer()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
           if(Mode == "updated")
            {
                updated();
            }
           else
            {
                saved();
            }
        }
        private void saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("transport", txtTransport.Text);
            header.Add("customer", txtcustname.Text);
            header.Add("custCode", txtCode.Text);
            header.Add("address", txtAddress.Text);
            header.Add("contactNo", txtcontact.Text);
            header.Add("postalCode", txtpostCode.Text);
            header.Add("tinNo", txtTin.Text);
            header.Add("terms", txtTerms.Text);
            header.Add("discount1", txtDis1.Text);
            header.Add("discount2", txtDis2.Text);
            header.Add("discount3", txtDis3.Text);
            header.Add("discount4", txtDis4.Text);
            header.Add("discount5", txtDis5.Text);
            header.Add("zone", txtZone.Text);
            header.Add("dateStamp", DateTime.Now);
            header.Add("status", 1);
            sql.Append(DataSupport.GetInsert("[TransportCustomers]", header));

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;
        }
        private void updated()
        {
            StringBuilder sql = new StringBuilder();
            var primary = new List<string>();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("transport", txtTransport.Text);
            header.Add("customer", txtcustname.Text);
            header.Add("custCode", txtCode.Text);
            header.Add("address", txtAddress.Text);
            header.Add("contactNo", txtcontact.Text);
            header.Add("postalCode", txtpostCode.Text);
            header.Add("tinNo", txtTin.Text);
            header.Add("terms", txtTerms.Text);
            header.Add("discount1", txtDis1.Text);
            header.Add("discount2", txtDis2.Text);
            header.Add("discount3", txtDis3.Text);
            header.Add("discount4", txtDis4.Text);
            header.Add("discount5", txtDis5.Text);
            header.Add("dateStamp", DateTime.Now);
            primary.Add("custCode");
            sql.Append(DataSupport.GetUpdate("TransportCustomers", header, primary));

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            {
                var dt = DataSupport.RunDataSet("Select transport_id from TransportProviders").Tables[0];
                foreach (DataRow row in dt.Rows)
                    txtTransport.Items.Add(row[0].ToString());
            }
        }
    }
}
