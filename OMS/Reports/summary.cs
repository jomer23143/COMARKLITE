using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS.Reports
{
    public partial class summary : Form
    {
        public summary()
        {
            InitializeComponent();
            design();
            DoubleBuffered(dataGridView1, true);
        }

        private void summary_Load(object sender, EventArgs e)
        {
            
          
        }
        private void design()
        {
            DataGridViewCellStyle style =
            dataGridView1.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.SteelBlue;
            style.ForeColor = Color.White;
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);

        }
        public new void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            if (comboBox1.Text == "Sales Invoice")
            {
                string sales = "Sales invoice";
                var dt = DataSupport.RunDataSet("Select docNo,document_reference_date,customer_name,amountD,zone,shippingInstruction from OutgoingShipmentRequests " +
                    "join TransportCustomers on customer_id = custCode where outgoing_type = '" + sales +"'").Tables[0];
                dataGridView1.DataSource = dt;
                
            }
            else if(comboBox1.Text == "Delivery")
            {
                string dr = "Delivery";
                var dt = DataSupport.RunDataSet("Select docNo,document_reference_date,customer_name,amountD,zone,shippingInstruction from OutgoingShipmentRequests " +
                    "join TransportCustomers on customer_id = custCode where outgoing_type = '" + dr + "'").Tables[0];
                dataGridView1.DataSource = dt;
            
            }
            else
            {
                string str = "Stock Transfer";
                var dt = DataSupport.RunDataSet("Select docNo,document_reference_date,customer_name,amountD,zone,shippingInstruction from OutgoingShipmentRequests " +
                    "join TransportCustomers on customer_id = custCode where outgoing_type = '" + str + "'").Tables[0];
                dataGridView1.DataSource = dt;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dialog = new Form1();
            dialog.summary = this;
            dialog.mode = 5;
            dialog.ShowDialog();
        }
    }
}
