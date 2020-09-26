using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Dashbord;

namespace Login
{
    public partial class Dashboard_Login : Form
    {
        
        public Dashboard_Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProductRegister propro = new ProductRegister();
            propro.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();

            txtBoxUsername.Focus();
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginRegister log = new LoginRegister();
            log.Show();
        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PasswordUpdate upd = new PasswordUpdate();
            upd.Show();
        }
    }
}
