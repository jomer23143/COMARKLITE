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

namespace OMS.MAster
{
    public partial class ListCustomer : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public ListCustomer()
        {
            InitializeComponent();
            DoubleBuffered(dataGridView1,true);
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            display();
            design();
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
            style.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }
        public void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("Select [custCode],[customer],[address],[id] from TransportCustomers").Tables[0];
            dataGridView1.DataSource = _bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new MAster.Customer();
            dialog.txtAddress.ReadOnly = false;
            dialog.txtcustname.ReadOnly = false;
            dialog.txtCode.ReadOnly = false;
            dialog.ShowDialog();
            display();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            _bs.Filter = "custCode LIKE '%" + textBox1.Text + "%' or customer LIKE '%" +textBox1.Text+ "%'";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dialog = new MAster.Customer();
            dialog.Mode = "updated";
            Object id = dataGridView1.Rows[e.RowIndex].Cells[colID.Name].Value;
            var drow = DataSupport.RunDataSet("Select * from TransportCustomers where id = '" + id + "'").Tables[0];
            foreach(DataRow row in drow.Rows)
            {
                dialog.txtTransport.Text = row["transport"].ToString();
                dialog.txtcustname.Text = row["customer"].ToString();
                dialog.txtCode.Text = row["custCode"].ToString();
                dialog.txtAddress.Text = row["address"].ToString();
                dialog.txtcontact.Text = row["contactNo"].ToString();
                dialog.txtpostCode.Text = row["postalCode"].ToString();
                dialog.txtTin.Text = row["tinNo"].ToString();
                dialog.txtDis1.Text = row["discount1"].ToString();
                dialog.txtDis2.Text = row["discount2"].ToString();
                dialog.txtDis3.Text = row["discount3"].ToString();
                dialog.txtDis4.Text = row["discount4"].ToString();
                dialog.txtDis5.Text = row["discount5"].ToString();
                dialog.txtZone.Text = row["zone"].ToString();
                Customer.id = row["id"].ToString();
            }
            dialog.ShowDialog();        
            display();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
