using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seadanya_testing
{
    internal class Admin
    {
        private string _idLogin;
        private string _password;

        public string IdLogin { get => _idLogin; set => _idLogin = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
