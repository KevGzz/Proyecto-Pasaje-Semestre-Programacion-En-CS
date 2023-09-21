using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObligatorio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>(); 
        private static Usuario s_usuarioLogeado;
        public Usuario UsuarioLogeado { get { return s_usuarioLogeado;} set {  s_usuarioLogeado = value; } }
        public List<Usuario> GetUsuarios() { return _usuarios; }
        public void AddUsuario(Usuario unUsuario) { _usuarios.Add(unUsuario); }
        public List<Publicacion> GetPublicaciones() { return _publicaciones; }
        public void AddPublicacion(Publicacion unaPublicacion) { _publicaciones.Add(unaPublicacion); }
        public Boolean RealizarPost(string titulo, string texto, string imagen, char privacidad)
        {
            Boolean esPublico;
            Boolean resultado = false;
            Miembro autor = (Miembro)s_usuarioLogeado;
            DateTime fecha = DateTime.Now;
            if (privacidad == 'S') esPublico = false; 
            else esPublico = true;
            if (!autor.Bloqueado)
            {
                Post post = new Post(titulo, fecha, autor, texto, esPublico, imagen);
                AddPublicacion(post);
                resultado = true;
            }
            return resultado;
        }
        public Boolean RealizarComentario(string titulo, string texto, char privacidad)
        {
            Boolean esPublico;
            Boolean resultado = false;
            Miembro autor = (Miembro)s_usuarioLogeado;
            DateTime fecha = DateTime.Now;
            if (privacidad == 'S') esPublico = false;
            else esPublico = true;
            if (!autor.Bloqueado)
            {
                Comentario comentario = new Comentario(titulo, fecha, autor, texto, esPublico);
                AddPublicacion(comentario);
                resultado = true;
            }
            return resultado;
        }
        public Boolean BloquearUsuario(string email)
        {
            Boolean resultado = false;
            if(s_usuarioLogeado == (Administrador)s_usuarioLogeado)
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
                    if (s_usuarioLogeado is Miembro miembroEmisor && !miembroEmisor.Bloqueado) { 
                        Solicitud solicitud = new Solicitud(s_usuarioLogeado.Email, emailReceptor);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
        public Boolean ValidarUsuario(string email)
        {
            Boolean resultado = true;
            foreach(Usuario usuario in _usuarios)
            {
                if (usuario.Email == email) resultado = false;
            }
            return resultado;
        }
        public void RegisterAdmin(string email, string password)
        {
            Boolean emailValidado = ValidarUsuario(email);
            if (emailValidado)
            {
                Administrador admin = new Administrador(email, password);
                AddUsuario(admin);
            } 
        }
        public void RegisterMiembro(string email, string password, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Boolean emailValidado = ValidarUsuario(email);
            if (emailValidado)
            {
                Miembro miembro = new Miembro(email, password, nombre, apellido, fechaNacimiento);
                AddUsuario(miembro);
            }
        }
        public Boolean Login(string email, string password)
        {
            Boolean resultado = false;
            foreach(Usuario usuario in _usuarios)
            {
                if (usuario.Email == email && usuario.Password == password)
                {
                    resultado = true;
                    s_usuarioLogeado = usuario;
                }
            }
            return resultado;
        }
    }
}
