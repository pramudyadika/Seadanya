using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seadanya_testing
{
    internal class Pengguna
    {
        private string _idLogin;
        private string _password;

        public string IdLogin { set => _idLogin = value; }
        public string Password { set => _password = value; }
    }
}
