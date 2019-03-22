using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;

namespace ReportGeneratorPortal_v2
{
    public partial class RegisteredUser : Form
    {
        public RegisteredUser(Dictionary<String, Dictionary<String, String>> DBConnection)
        {
            InitializeComponent();
            cboauthlevel.SelectedIndex = 0;
            cbousertype.SelectedIndex = 0;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.RunWorkerAsync();
                progressBar1.MarqueeAnimationSpeed = 80;
                progressBar1.Visible = true;
            }

        }

        public void DataView()
        {
            try
            {
                //GridPanel panel = grdUser.PrimaryGrid;
                //panel.Rows.Clear();
                //while (dbReader.Read())
                //{
                //    GridRow grow = new GridRow(dbReader["username"].ToString(),
                //                   dbReader["usertype"].ToString(),
                //                   dbReader["status"].ToString(),
                //                   dbReader["_userindex"].ToString());
                //    panel.Rows.Add(grow);
                //}
            }
            catch (Exception)
            { MessageBox.Show("Unable to connect!"); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //if (backgroundWorker1.IsBusy)
            //    return;
            //if (txtusername.Text.Trim().Length == 0)
            //    return;
            //else if (txtpassword.Text.Trim().Length == 0)
            //    return;
            //try
            //{
            //    Dictionary<String, String> param = new Dictionary<String, String>();
            //    MySqlConnection dbConn = new MySqlConnection();
            //    dbConn.ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //    dbConn.Open();
            //    MySqlCommand dbCommand = new MySqlCommand("select * from base_user WHERE username = '" + txtusername.Text + "'", dbConn);
            //    MySqlDataReader dbReader = dbCommand.ExecuteReader();
            //    bool found = false;

            //    while (dbReader.Read())
            //    {
            //        userindex = dbReader["_userindex"].ToString();
            //        found = true;
            //        break;
            //    }
            //    dbReader.Close();

            //    if (!found)
            //    {
            //        string sql = "INSERT INTO `base_user`(`username`,`password`,`authlevel`,`usertype`,`status`,`datestamp`) VALUES('" + txtusername.Text + "','" + SecuritySupport.Encrypt(txtpassword.Text) + "','" + cboauthlevel.Text + "','" + cbousertype.Text + "',1,NOW())";
            //        dbCommand = new MySqlCommand(sql, dbConn);
            //        dbCommand.CommandType = CommandType.Text;
            //        dbCommand.CommandTimeout = 6000;
            //        dbCommand.ExecuteNonQuery();
            //    }
            //    else
            //    {
            //        if (MessageBox.Show("Username", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            string sql = "UPDATE `base_user` SET `username` = '" + txtusername.Text + "',`password`='" + SecuritySupport.Encrypt(txtpassword.Text) + "',`authlevel`='" + cboauthlevel.Text + "',`usertype` = '" + cbousertype.Text + "' WHERE _userindex = " + userindex;
            //            dbCommand = new MySqlCommand(sql, dbConn);
            //            dbCommand.CommandType = CommandType.Text;
            //            dbCommand.CommandTimeout = 6000;
            //            dbCommand.ExecuteNonQuery();
            //        }
            //    }
            //    if (!backgroundWorker1.IsBusy)
            //    {
            //        backgroundWorker1.WorkerReportsProgress = true;
            //        backgroundWorker1.RunWorkerAsync();
            //        progressBar1.MarqueeAnimationSpeed = 80;
            //        progressBar1.Visible = true;
            //    }
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataView();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }

}
