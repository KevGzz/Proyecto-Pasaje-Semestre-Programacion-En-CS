using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Administrador : Usuario
    {
        private static Usuario _instancia;
        public Administrador(string email, string password) 
        {
            Email = email;
            Password = password;
        }
        public Administrador() { }
        Sistema miSistema = Sistema.GetInstancia();

        public Boolean ValidarAdmin(string email)
        {
            Boolean resultado = true;
            foreach (Usuario usuario in miSistema.GetUsuarios())
            {
                if (usuario.Email == email) resultado = false;
            }
            return resultado;
        }
        public Boolean ValidarPassword(string password)
        {
            Boolean resultado = false;
            Boolean tieneMayus = false;
            Boolean tieneMinus = false;
            string mayus = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string minus = "abcdefghijklnmopqrstuvwxyz";
            if (password.Length >= 8)
            {
                for (int i = 0; i <= mayus.Length; i++)
                {
                    string letra = mayus.Substring(i);
                    if (password.Contains(letra)) tieneMayus = true;
                }
                for (int i = 0; i <= minus.Length; i++)
                {
                    string letra = minus.Substring(i);
                    if (password.Contains(letra)) tieneMinus = true;
                }
                if (tieneMayus && tieneMinus) resultado = true;
            }
            return resultado;
        }
    }
}
