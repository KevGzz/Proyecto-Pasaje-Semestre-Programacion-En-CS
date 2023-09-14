using ClasesObligatorio;

int opcion = -1;
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
            Console.WriteLine("");
            Console.WriteLine("Oi");
            break;
        default:
            break;
    }
}