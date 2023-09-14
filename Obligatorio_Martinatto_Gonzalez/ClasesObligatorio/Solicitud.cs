using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    internal class Solicitud
    {
        private int _id;
        private static int UltimoId;
        private string _emisor;
        private string _receptor;
        private Invitacion _estadoSolicitud;
        public int Id { get { return _id; } set { _id = value; } }
        public Invitacion EstadoSolicitud { get { return _estadoSolicitud; } set { _estadoSolicitud = value; } }
        public Solicitud(string emisor, string receptor)
        {
            this._id = UltimoId;
            UltimoId++;
            this._emisor = emisor;
            this._receptor = receptor;
            this._estadoSolicitud = Invitacion.PENDIENTE_APROBACION;
        }
    }
}
