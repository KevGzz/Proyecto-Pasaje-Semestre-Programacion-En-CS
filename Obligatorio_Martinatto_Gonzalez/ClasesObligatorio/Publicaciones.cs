using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Publicaciones
    {
        private int _id;
        private static int _ultimoId;
        private string _titulo;
        private Miembro _autor;
        private DateTime _fecha;
        private string _contenido;
        private Boolean _privacidad;
        public int Id { get { return _id; } set { _id = value; } }
        public int UltimoId { get { return _ultimoId; } set { _ultimoId = value; } }
        public string Titulo { get { return _titulo; } set {  _titulo = value; } }
        public Miembro Autor { get { return _autor; } set { _autor = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Contenido { get { return _contenido; } set { _contenido = value; } }
        public Boolean Privacidad { get { return _privacidad; } set { _privacidad = value; } }

        public Publicaciones()
        { 
            //aca va el constructor
        }
    }
}
