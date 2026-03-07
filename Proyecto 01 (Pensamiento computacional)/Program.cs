Console.WriteLine("Proyecto 01 Plataforma de Streaming");
int opcion_menu = 0;
do
{
    Console.WriteLine("1. Evaluar nuevo contenido");
    Console.WriteLine("2. Mostrar reglas del sistema");
    Console.WriteLine("3. Mostrar estadísticas de la sesión");
    Console.WriteLine("4. Reiniciar estadísticas");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija una opción:");
    opcion_menu = int.Parse(Console.ReadLine());


    switch (opcion_menu)
    {
        case 1:
        Console.WriteLine("Evaluar nuevo contenido");
        break;

    case 2:
        Console.WriteLine("Mostrar reglas del contenido");
        break;

    case 3:
        Console.WriteLine("Mostrar estadísticas de la sesión ");
        break;

    case 4:
        Console.WriteLine("Reiniciar estadísticas ");
        break;

    case 5:
        Console.WriteLine("Salir");
        break;

    default:
        Console.WriteLine("Opción no válida, por favor ingrese una opción del 1 al 5.");
        break;
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
while (opcion_menu != 5);