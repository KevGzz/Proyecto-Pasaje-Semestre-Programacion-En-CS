using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Post : Publicacion
    {
        private string _imagen;
        private Boolean _censurado;
        private List<Comentario> _comentarios;

        public Post(string titulo, DateTime fecha, Usuario autor, string contenido, Boolean privacidad, string imagen)
        {
            Id = UltimoId;
            UltimoId++;
            Titulo = titulo;
            Autor = (Miembro)autor;
            Fecha = fecha;
            Contenido = contenido;
            Privacidad = privacidad;
            this._imagen = imagen;
            this._censurado = false;
            this._comentarios = null;
        }
    }
}
