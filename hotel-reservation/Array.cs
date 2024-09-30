using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SIR_GELLO
{
    class Array
    {
        private static int i = 0, x = 0;
        private static string[,] info = new string[100, 26];
        private static string[,] payment = new string[100, 9];
        private static string[,] balance = new string[100, 7];

        public static string[,] getinfo
        {
            get { return info; }
            set { info = value; }
        }
        public static string[,] getpayment
        {
            get { return payment; }
            set { payment = value; }
        }
        public static string[,] getbalance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static int increment
        {
            get { return i; }
            set { i = value; }
        }
        public static int increment2
        {
            get { return x; }
            set { x = value; }
        }











    }
}
