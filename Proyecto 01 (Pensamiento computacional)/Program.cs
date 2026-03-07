Console.WriteLine("Proyecto 01 Plataforma de Streaming");
int opcion_menu = 0;
do
{
    switch (opcion_menu)
     {
        Console.WriteLine("1. Evaluar nuevo contenido \r 2. Mostrar reglas del sistema \r 3. Mostrar  estadísticas de la sesión \r4. Reiniciar  estadísticas \r 5.Salir");
        opcion_menu = int.Parse(Console.ReadLine());
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
}
while (opcion_menu != 5);