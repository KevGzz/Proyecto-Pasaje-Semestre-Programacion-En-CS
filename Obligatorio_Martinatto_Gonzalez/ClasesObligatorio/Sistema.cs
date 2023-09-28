using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private static Sistema _instancia;
        public static Sistema GetInstancia()
        {
            if (_instancia == null) _instancia = new Sistema();
            return _instancia;
        }
        private Sistema() { }
        public Usuario UsuarioLogeado { get { return s_usuarioLogeado; } set { s_usuarioLogeado = value; } }
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

        public Boolean RealizarComentario(int idPost, string titulo, string texto, char privacidad)
        {
            
            Boolean esPublico;
            Boolean resultado = false;
            Publicacion laPublicacion = null;
            Miembro autor = (Miembro)s_usuarioLogeado;
            DateTime fecha = DateTime.Now;
            if (privacidad == 'S') esPublico = false;
            else esPublico = true;
            if (!autor.Bloqueado)
            {
                foreach (Publicacion publicacion in _publicaciones)
                {
                    if (publicacion is Post && publicacion.Id == idPost) 
                    {
                        laPublicacion = publicacion;
                    }
                }
                Comentario comentario = new Comentario(titulo, fecha, autor, texto, esPublico);
                AddPublicacion(comentario);
                (laPublicacion as Post).AddComentario(comentario);
                resultado = true;

            }
            return resultado;
        }
        public Boolean BloquearUsuario(string email)
        {
            Boolean resultado = false;
            if (s_usuarioLogeado == (Administrador)s_usuarioLogeado)
            {
                foreach (Miembro miembro in _usuarios)
                {
                    if (miembro.Email == email)
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
            foreach (Usuario usuario in _usuarios )
            {
                if (usuario is Miembro)
                {
                    if (emailReceptor == usuario.Email)
                    {
                        if (s_usuarioLogeado is Miembro miembroEmisor && !miembroEmisor.Bloqueado)
                        {
                            Solicitud solicitud = new Solicitud(s_usuarioLogeado.Email, emailReceptor);
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        public string RegisterAdmin(string email, string password)
        {
            string resultado = "";
            Administrador admin = new Administrador();
            Boolean emailValidado = admin.ValidarAdmin(email);
            if (!emailValidado) resultado = "| El email no es valido. No puede ser vacío. |";
            Boolean passwordValidada = admin.ValidarPassword(password);
            if (!passwordValidada) resultado += "| La contraseña no es valida. Recuerde que debe ser mayor que 8 caracteres y debe utilizar mayusculas y minusculas. |";
            if (emailValidado)
            {
                Administrador nuevoAdmin = new Administrador(email, password);
                AddUsuario(nuevoAdmin);
            }
            return resultado;
        }
        public string RegisterMiembro(string email, string password, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Miembro miembro = new Miembro();
            string resultado = "";
            Boolean emailValidado = miembro.ValidarMiembro(email);
            if (!emailValidado) resultado = "| El email no es valido. No puede ser vacío. |";
            Boolean passwordValidada = miembro.ValidarPassword(password);
            if (!passwordValidada) resultado += "| La contraseña no es valida. Recuerde que debe ser mayor que 8 caracteres y debe utilizar mayusculas y minusculas. |";
            Boolean nomYapeValidados = miembro.ValidarNomYapellido(nombre, apellido);
            if (!nomYapeValidados) resultado += "| Su nombre y/o apellido no son validos. No pueden contener numeros o ser vacíos. |";
            if (emailValidado && passwordValidada && nomYapeValidados)
            {
                Miembro nuevoMiembro = new Miembro(email, password, nombre, apellido, fechaNacimiento);
                resultado = "El miembro fue registrado exitosamente.";
                AddUsuario(nuevoMiembro);
            }
            return resultado;
        }
        public Boolean Login(string email, string password)
        {
            Boolean resultado = false;
            foreach (Usuario usuario in _usuarios)
            {
                if (usuario.Email == email && usuario.Password == password)
                {
                    resultado = true;
                    s_usuarioLogeado = usuario;
                }
            }
            return resultado;
        }
        public List<string> BuscarPorEmail(string email)
        {
            List<string> lista = new List<string>();
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.Autor.Email == email) lista.Add(publicacion.ToString());
            }
            return lista;
        }
        public Boolean AceptarSolicitud(int id)
        {
            Boolean solicitudEncontrada = false;
            Miembro miembro = new Miembro();
            foreach (Solicitud solicitud in miembro.GetSolicitudes())
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
            Miembro miembro = new Miembro();
            foreach (Solicitud solicitud in miembro.GetSolicitudes())
            {
                if (id == solicitud.Id)
                {
                    solicitud.EstadoSolicitud = Invitacion.RECHAZADA;
                    solicitudEncontrada = true;
                }
            }
            return solicitudEncontrada;
        }

        public void Reaccionar(string tipoReaccion, int id)
        {
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.Id == id)
                {
                    if (tipoReaccion == "like")
                    {
                        Reaccion unaReaccion = new Reaccion(TipoReaccion.like, (Miembro)UsuarioLogeado);
                        publicacion.AddReaccion(unaReaccion);
                    }
                    else
                    {
                        Reaccion unaReaccion = new Reaccion(TipoReaccion.dislike, (Miembro)UsuarioLogeado);
                        publicacion.AddReaccion(unaReaccion);
                    }
                }
            }
        }
    }
}

