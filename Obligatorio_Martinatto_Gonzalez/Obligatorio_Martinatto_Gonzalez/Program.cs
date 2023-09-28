using ClasesObligatorio;
using System.Globalization;

int opcion = -1;
Sistema miSistema = Sistema.GetInstancia();
#region precarga de datos

miSistema.RegisterMiembro("email1@example.com", "Password1", "Xiomara", "Sandoval", new DateTime(1990, 5, 15));
miSistema.RegisterMiembro("email2@example.com", "Password2", "Zephyr", "Montenegro", new DateTime(2003, 3, 2));
miSistema.RegisterMiembro("email3@example.com", "Password3", "Kai", "López", new DateTime(1993, 11, 10));
miSistema.RegisterMiembro("email4@example.com", "Password4", "Cleopatra", "González", new DateTime(2003, 3, 7));
miSistema.RegisterMiembro("email5@example.com", "Password5", "Osiris", "Pérez", new DateTime(1998, 7, 30));
miSistema.RegisterMiembro("email6@example.com", "Password6", "Thalía", "Ramírez", new DateTime(1996, 1, 5));
miSistema.RegisterMiembro("email7@example.com", "Password7", "Anubis", "Silva", new DateTime(2005, 9, 18));
miSistema.RegisterMiembro("email8@example.com", "Password8", "Isis", "Hernández", new DateTime(1991, 12, 3));
miSistema.RegisterMiembro("email9@example.com", "Password9", "Mohammed", "Torres", new DateTime(2001, 9, 11));
miSistema.RegisterMiembro("email10@example.com", "Password10", "Horus", "Martínez", new DateTime(1995, 6, 12));

miSistema.RegisterAdmin("elAdmin@gmail.com", "laMejorPassword325XD");

miSistema.Login("email1@example.com", "Password1");
    miSistema.EnviarSolicitud("email2@example.com");
    miSistema.EnviarSolicitud("email3@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.EnviarSolicitud("email5@example.com");
    miSistema.EnviarSolicitud("email6@example.com");
    miSistema.EnviarSolicitud("email7@example.com");
    miSistema.EnviarSolicitud("email8@example.com");
    miSistema.EnviarSolicitud("email9@example.com");
    miSistema.EnviarSolicitud("email10@example.com");
miSistema.Login("email2@example.com", "Password2");
    miSistema.AceptarSolicitud(0);
    miSistema.EnviarSolicitud("email1@example.com");
    miSistema.EnviarSolicitud("email3@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.EnviarSolicitud("email5@example.com");
    miSistema.EnviarSolicitud("email6@example.com");
    miSistema.EnviarSolicitud("email7@example.com");
    miSistema.EnviarSolicitud("email8@example.com");
    miSistema.EnviarSolicitud("email9@example.com");
    miSistema.EnviarSolicitud("email10@example.com");

miSistema.Login("email3@example.com", "Password3");
    miSistema.AceptarSolicitud(1);
    miSistema.AceptarSolicitud(10);
    miSistema.EnviarSolicitud("email10@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(0, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(1, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email4@example.com", "Password4");
    miSistema.AceptarSolicitud(2);
    miSistema.AceptarSolicitud(11);
    miSistema.EnviarSolicitud("email9@example.com");
    miSistema.EnviarSolicitud("email5@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(2, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(3, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email5@example.com", "Password5");
    miSistema.AceptarSolicitud(3);
    miSistema.AceptarSolicitud(12);
    miSistema.EnviarSolicitud("email8@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(4, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(7, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email6@example.com", "Password6");
    miSistema.AceptarSolicitud(4);
    miSistema.AceptarSolicitud(13);
    miSistema.EnviarSolicitud("email7@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(8, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(9, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email7@example.com", "Password7");
    miSistema.AceptarSolicitud(5);
    miSistema.AceptarSolicitud(14);
    miSistema.EnviarSolicitud("email6@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(10, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(11, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email8@example.com", "Password8");
    miSistema.AceptarSolicitud(6);
    miSistema.AceptarSolicitud(15);
    miSistema.EnviarSolicitud("email5@example.com");
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(14, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(15, "Comentario 2", "Este es el segundo comentario", 'N');


miSistema.Login("email9@example.com", "Password9");
    miSistema.AceptarSolicitud(7);
    miSistema.AceptarSolicitud(16);
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.EnviarSolicitud("email3@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(16, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(17, "Comentario 2", "Este es el segundo comentario", 'N');

miSistema.Login("email10@example.com", "Password10");
    miSistema.AceptarSolicitud(8);
    miSistema.AceptarSolicitud(17);
    miSistema.EnviarSolicitud("email4@example.com");
    miSistema.EnviarSolicitud("email3@example.com");
    miSistema.RealizarPost("Título del primer post", "Texto del primer post", "imagen1.jpg", 'N');
    miSistema.RealizarPost("Título del segundo post", "Texto del segundo post", "imagen2.png", 'S');
    miSistema.RealizarPost("Título del tercer post", "Texto del tercer post", "imagen3.jpg", 'N');
    miSistema.RealizarPost("Título del cuarto post", "Texto del cuarto post", "imagen4.png", 'S');
    miSistema.RealizarPost("Título del quinto post", "Texto del quinto post", "imagen5.jpg", 'N');
    miSistema.RealizarComentario(18, "Comentario 1", "Este es el primer comentario", 'S');
    miSistema.RealizarComentario(21, "Comentario 2", "Este es el segundo comentario", 'N');
    miSistema.Reaccionar("like", 0);
    miSistema.Reaccionar("dislike", 1);
    miSistema.Reaccionar("like", 5);
    miSistema.Reaccionar("dislike", 6);

#endregion


while (opcion != 6)
{
    Console.WriteLine("");
    Console.WriteLine("1 - Alta de miembro.");
    Console.WriteLine("");
    Console.WriteLine("2 - Listar publicaciones (dado un email).");
    Console.WriteLine("");
    Console.WriteLine("3 - Listar Posts comentados (dado un email).");
    Console.WriteLine("");
    Console.WriteLine("4 - Listar Posts realizado entre fechas.");
    Console.WriteLine("");
    Console.WriteLine("5 - Listar todos los miembros que hayan posteado.");
    Console.WriteLine("");
    Console.WriteLine("6 - Salir del programa.");
    int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese su email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña (Debe ser de más de 8 caracteres y deber tener mayúsculas y minúsculas: ");
            string password = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento (Debe ser en el formato Mes/Día/Año): ");
            string format = "MM/dd/yyyy";
            string fechaSinFor = Console.ReadLine();
            DateTime fecha = DateTime.ParseExact(fechaSinFor, format, CultureInfo.InvariantCulture);
            Console.WriteLine(miSistema.RegisterMiembro(email, password, nombre, apellido, fecha));
            break;
        case 2:
            //placeholder para testing
            fecha = new DateTime(1996, 07, 18);
            miSistema.RegisterMiembro("elCoso", "coSo1234", "Kevin", "Gonzalez", fecha);
            miSistema.Login("elCoso", "coSo1234");
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            miSistema.RealizarPost("hola", "este es mi post", "poronga.png", 'S');
            //fin del placeholder
            Console.WriteLine("Ingrese un email: ");
            email = Console.ReadLine();
            List<string> lista = miSistema.BuscarPorEmail(email);
            foreach(string publicacion in lista)
            {
                Console.WriteLine(publicacion);
            }
            break;
        default:
            Console.WriteLine("Por favor elija una opcion de las que se muestran en el menu.");
            break;
    }
}