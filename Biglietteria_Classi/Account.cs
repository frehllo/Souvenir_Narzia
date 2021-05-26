using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biglietteria_Classi
{
    public class Account
    {
        public string Username { get;private set; }
        public string Password { get; private set; }

        public Account(string u, string p)
        {
            Username = u;
            Password = p;
        }
    }
}
