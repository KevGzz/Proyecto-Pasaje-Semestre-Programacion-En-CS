using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Post : Publicaciones
    {
        private string _imagen;
        private Boolean _censurado;
        private List<Comentario> _comentarios;

        public Post(string titulo, DateTime fecha, Miembro autor, string contenido, Boolean privacidad, string imagen, bool censurado, List<Comentario> comentarios)
        {
            Id = UltimoId;
            UltimoId++;
            Titulo = titulo;
            Autor = autor;
            Fecha = fecha;
            Contenido = contenido;
            Privacidad = privacidad;
            this._imagen = imagen;
            this._censurado = censurado;
            this._comentarios = comentarios;
        }
    }
}
