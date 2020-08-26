using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool test = true;
            if(textBoxName.Text == @"value"  && textBoxVorname.Text != null && textBoxTelephone.Text != null &&
                textBoxEmail.Text != null && textBoxPassword1.Text  == textBoxPassword2.Text )
            {
                MessageBox.Show("registration complete");
            }

            else
            {
                MessageBox.Show("Check the entry Again");
            }
        }
    }
}
