using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.Close();
            Dashboard_Login dsh = new Dashboard_Login();
            dsh.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LoginDB;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand(@"insert into Registration values ('" + textBoxName.Text + "', '" +textBoxVorname.Text+ "', '" + textBoxBirthdate.Text + "', '" 
                                                + textBoxEmail.Text + "', '" + textBoxTelephone.Text + "', '" + textBoxPassword1.Text + "', '" + textBoxPassword2.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            MessageBox.Show("registration complete");
        }
    }
}
