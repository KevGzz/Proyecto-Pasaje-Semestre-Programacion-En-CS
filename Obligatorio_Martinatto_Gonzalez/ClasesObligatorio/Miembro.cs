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

        public Boolean AceptarSolicitud(int id)
        {
            Boolean solicitudEncontrada = false;
            foreach (Solicitud solicitud in this._solicitudes)
            {
                if (id == solicitud.Id)
                {
                    solicitud.EstadoSolicitud = Invitacion.APROBADA;
                    solicitudEncontrada = true;
                }
            }
            return solicitudEncontrada;
        }
        public Boolean RechazarSolicitud(int id)
        {
            Boolean solicitudEncontrada = false;
            foreach(Solicitud solicitud in this._solicitudes)
            {
                if(id == solicitud.Id)
                {
                    solicitud.EstadoSolicitud = Invitacion.RECHAZADA;
                    solicitudEncontrada = true;
                }
            }
            return solicitudEncontrada;
        }
    }
}

