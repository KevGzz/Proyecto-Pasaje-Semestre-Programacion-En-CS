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
            Id = S_UltimoId;
            S_UltimoId++;
            Titulo = titulo;
            Autor = (Miembro)autor;
            Fecha = fecha;
            Contenido = contenido;
            Privacidad = privacidad;
        }
        public Comentario() { }
        public Boolean ValidarTitulo(string titulo) // Valida que el titulo no sea vacío
        {
            Boolean result = false;
            if (titulo != null)
            {
                result = true;
            }
            return result;
        }
        public Boolean ValidarContenido(string contenido) // Valida que el contenido no sea vacío.
        {
            Boolean result = false;
            if (contenido != null)
            {
                result = true;
            }
            return result;
        }
        public override string ToString()
        {
            return "Tipo: Comentario | Titulo: " + Titulo + "| Autor: " + Autor.ToString()
                + "| Fecha: " + Fecha + "| Contenido: " + Contenido;
        }
    }
}
