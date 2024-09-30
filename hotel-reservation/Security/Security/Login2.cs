using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class Login2
    {
        private string username;
        private string password;

        public Login2()
        {
            username = "";
            password = "";
        }

        public Login2(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public string USERNAME
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

    }
}
