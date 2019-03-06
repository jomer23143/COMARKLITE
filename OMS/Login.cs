using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace OMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Utils.SetConnectionDetails();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.F1)
                {
                    ConnectionSettings dialog = new ConnectionSettings();
                    dialog.ShowDialog();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    login();
                }
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            if (RegistrationSupport.IsCorrectUsernameAndPassword(txtuser.Text, (txtpass.Text)))
            {
                var dialog = new MainMenu();
                this.Visible = false;
                dialog.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                txtuser.Focus();
            }
            else
            {
                button1.Focus();
            }
        }
    }
}
