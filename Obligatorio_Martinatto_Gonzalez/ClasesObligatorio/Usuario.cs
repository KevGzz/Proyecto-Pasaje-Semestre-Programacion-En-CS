using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Usuario
    {
        private string _email;
        private string _password;
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password;} set { _password = value; } }
        public Usuario() { }
    }
}
