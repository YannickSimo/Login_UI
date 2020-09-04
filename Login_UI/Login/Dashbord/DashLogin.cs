using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Dashbord
{
    public class DashLogin
    {
        string Username;
        string Password;

        public DashLogin(string User_name, string Pass_word)
        {
            this.Username = User_name;
            this.Password = Pass_word;
        }

        public string Pass
        {
            get { return Password; }
            set { Password = value; }
        }

        public string User
        {
            get { return Username; }
            set { Username = value; }
        }
    }
}
