using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCode
{
    public abstract class Login
    {
        
        private string username;
        private int password;

        public Login()
        {
            username = "";
            password = 0;
        }

        public Login(string user, int pass)
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

        public int PASSWORD
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
