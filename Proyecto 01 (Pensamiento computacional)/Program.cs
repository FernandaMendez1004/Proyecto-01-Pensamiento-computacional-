Console.WriteLine("Proyecto 01 Plataforma de Streaming");
int opcion_menu = 0;
string tipo_contenido = "";
int duracion = 0;
string clasificacion = "";
int hora_programada = 0;
string nivel_produccion = "";

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
            Console.WriteLine("Ingrese el tipo de contenido (película, serie, documental, evento en vivo) ");
            tipo_contenido = Console.ReadLine();
            Console.WriteLine("Ingrese la duración en minutos");
            duracion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la clasificación (todo público, +13, +18) ");
            clasificacion = Console.ReadLine();
            Console.WriteLine("Ingrese la hora programada");
            hora_programada = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de producción (bajo, medio, alto) ");
            nivel_produccion = Console.ReadLine();
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