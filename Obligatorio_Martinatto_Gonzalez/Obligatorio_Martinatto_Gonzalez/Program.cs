using ClasesObligatorio;
using System.Globalization;

int opcion = -1;
Sistema miSistema = Sistema.GetInstancia();
while (opcion != 0)
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

    opcion = int.Parse(Console.ReadLine());
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
        default:
            break;
    }
}