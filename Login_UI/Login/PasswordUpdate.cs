using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Login
{
    public partial class PasswordUpdate : Form
    {
        public PasswordUpdate()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_Login dsh = new Dashboard_Login();
            dsh.Show();

        }

        private void BtnPasswordUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=LoginDB;Integrated Security=True");
                conn.Open();

                SqlCommand cmmd = new SqlCommand(@"insert into PasswordUpdate values ('" + textBoxPassUpdate1.Text +
                                                 "', " +
                                                 "'" + textBoxPassUpdate2.Text + "', '" + textBoxPassUpdate3.Text + "')", conn);

                cmmd.ExecuteNonQuery();
                conn.Close();
            }
            catch {
            }

            if (MessageBox.Show("Update registration complete") == DialogResult.OK)
            {
                this.Close();
                Dashboard_Login dsh = new Dashboard_Login();
                dsh.Show();
            }
                
          
        }
    }
}
