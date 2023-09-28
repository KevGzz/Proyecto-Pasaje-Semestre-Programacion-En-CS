using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Miembro : Usuario
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private Boolean _bloqueado;
        private List<Miembro> _amigos = new List<Miembro>();
        private List<Solicitud> _solicitudes = new List<Solicitud>();  

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public DateTime FechaNacimiento { get { return _fechaNacimiento; } set { _fechaNacimiento = value; } }
        public Boolean Bloqueado { get { return _bloqueado;  } set {  _bloqueado = value; } }
        public List<Miembro> GetAmigos() {  return _amigos; }
        public void AddAmigo(Miembro unAmigo) { _amigos.Add(unAmigo); }
        public List<Solicitud> GetSolicitudes() { return _solicitudes; }
        public void AddSolicitud(Solicitud unaSolicitud) { _solicitudes.Add(unaSolicitud); }
        public Miembro(string email, string password, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.Email = email;
            this.Password = password;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNacimiento;
            this._bloqueado = false;
        }
        public Miembro(){ }
        private static Usuario _instancia;
        Sistema miSistema = Sistema.GetInstancia();

        public Boolean ValidarMiembro(string email)
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
            if(password.Length >= 8)
            {
                for(int i = 0; i <= mayus.Length; i++)
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
        public Boolean ValidarNomYapellido(string nombre, string apellido)
        {
            Boolean resultado = false;
            if(nombre != "" && apellido != "") resultado = true;
            return resultado;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + " Apellido: " + Apellido + " Email: " + Email;
        }
    }
}

