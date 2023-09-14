using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Comentario : Publicacion
    {
        public Comentario(string titulo, DateTime fecha, Usuario autor, string contenido, Boolean privacidad)
        {
            Id = UltimoId;
            UltimoId++;
            Titulo = titulo;
            Autor = (Miembro)autor;
            Fecha = fecha;
            Contenido = contenido;
            Privacidad = privacidad;
        }
    }
}
