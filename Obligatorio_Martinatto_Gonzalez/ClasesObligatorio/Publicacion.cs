using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public abstract class Publicacion : IComparable<Publicacion>
    {
        public int Id { get; set; }
        public static int S_UltimoId { get; set; }
        public string Titulo { get; set; }
        public Miembro Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string Contenido { get; set; }
        public Boolean Privacidad { get; set; }
        public Publicacion() { }
        private List<Reaccion> _reacciones = new List<Reaccion>();
        public List<Reaccion> GetReacciones()
        {
            return _reacciones;
        }
        public void AddReaccion(Reaccion unaReaccion)
        {
            _reacciones.Add(unaReaccion);
        }
        public int CompareTo(Publicacion? other)
        {
            return Titulo.CompareTo(other.Titulo);
        }
    }
}
