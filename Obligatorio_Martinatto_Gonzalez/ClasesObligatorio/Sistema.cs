using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Sistema
    {
        private List<Usuario> _usuarios;
        private List<Publicacion> _publicaciones;
        private static Usuario _usuarioLogeado;
        public Usuario UsuarioLogeado { get { return _usuarioLogeado;} set {  _usuarioLogeado = value; } }
        public Boolean RealizarPost(string titulo, string texto, string imagen, char privacidad)
        {
            Boolean esPublico;
            Boolean resultado = false;
            Miembro autor = (Miembro)_usuarioLogeado;
            DateTime fecha = DateTime.Now;
            if (privacidad == 'S') esPublico = false; 
            else esPublico = true;
            if (!autor.Bloqueado)
            {
                Post post = new Post(titulo, fecha, autor, texto, esPublico, imagen);
                resultado = true;
            }
            return resultado;
        }
        public Boolean RealizarComentario(string titulo, string texto, char privacidad)
        {
            Boolean esPublico;
            Boolean resultado = false;
            Miembro autor = (Miembro)_usuarioLogeado;
            DateTime fecha = DateTime.Now;
            if (privacidad == 'S') esPublico = false;
            else esPublico = true;
            if (!autor.Bloqueado)
            {
                Comentario comentario = new Comentario(titulo, fecha, autor, texto, esPublico);
                resultado = true;
            }
            return resultado;
        }
        public Boolean BloquearUsuario(string email)
        {
            Boolean resultado = false;
            if(_usuarioLogeado == (Administrador)_usuarioLogeado)
            {
                foreach(Miembro miembro in _usuarios)
                {
                    if(miembro.Email == email) 
                    {
                        miembro.Bloqueado = true;
                        resultado = true;
                    } 
                }
            }
            return resultado;
        }
        public Boolean EnviarSolicitud(string emailReceptor)
        {
            Boolean resultado = false;
            foreach (Miembro miembro in _usuarios)
            {
                if(emailReceptor == miembro.Email)
                {
                    if (_usuarioLogeado is Miembro miembroEmisor && !miembroEmisor.Bloqueado) { 
                        Solicitud solicitud = new Solicitud(_usuarioLogeado.Email, emailReceptor);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
    }
}
