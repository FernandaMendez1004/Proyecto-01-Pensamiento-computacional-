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

            Console.WriteLine("Ingrese el tipo de contenido (pelicula, serie, documental, evento en vivo)");
            tipo_contenido = Console.ReadLine();
            Console.WriteLine("Ingrese la duración en minutos");
            duracion = int.Parse(Console.ReadLine()); // Validar duración según tipo de contenido 1 if

            if (tipo_contenido == "pelicula")
            {
                if (duracion < 60 || duracion > 180)
                { Console.WriteLine("Contenido rechezado"); }
                else
                { Console.WriteLine("Duración válida para película"); }
            }
            else if (tipo_contenido == "serie")
            {
                if (duracion < 20 || duracion > 90)
                { Console.WriteLine("Contenido rechezado"); }
                else
                { Console.WriteLine("Duración válida para serie"); }
            }
            else if (tipo_contenido == "documental")
            {
                if (duracion < 30 || duracion > 120)
                { Console.WriteLine("Contenido rechezado"); }
                else
                { Console.WriteLine("Duración válida para documental"); }
            }
            else if (tipo_contenido == "evento en vivo")
            {
                if (duracion < 30 || duracion > 240)
                { Console.WriteLine("Contenido rechezado"); }
                else
                { Console.WriteLine("Duración válida para evento en vivo"); }
            }
            else
            { Console.WriteLine("Tipo de contenido no válido"); }

            Console.WriteLine("Ingrese la clasificación (todo publico, +13, +18)");
            clasificacion = Console.ReadLine(); // Validar clasificación y horario 2 if               
            Console.WriteLine("Ingrese la hora programada (0-23)");
            hora_programada = int.Parse(Console.ReadLine());

            if (clasificacion == "todo publico")
            { Console.WriteLine("Clasificación válida para cualquier horario"); }
            else if (clasificacion == "+13")
            {
                if (hora_programada >= 6 && hora_programada <= 22)
                { Console.WriteLine("Horario válido para clasificación +13"); }
                else
                { Console.WriteLine("Rechazar: +13 solo se permite entre 6 y 22 horas"); }
            }
            else if (clasificacion == "+18")
            {
                if (hora_programada >= 22 || hora_programada <= 5)
                { Console.WriteLine("Horario válido para clasificación +18"); }
                else
                { Console.WriteLine("Rechazar: +18 solo se permite entre 22 y 5 horas"); }
            }
            else
            { Console.WriteLine("Clasificación no válida"); }

            Console.WriteLine("Ingrese el nivel de producción (bajo, medio, alto)");
            nivel_produccion = Console.ReadLine(); // Validar nivel de producción según clasificación 3 if

            if (nivel_produccion == "bajo")
            {
                if (clasificacion == "todo publico" || clasificacion == "+13")
                { Console.WriteLine("Producción baja válida para clasificación"); }
                else
                { Console.WriteLine("Rechazar: producción baja solo válida para todo público o +13"); }
            }
            else if (nivel_produccion == "medio" || nivel_produccion == "alto")
            { Console.WriteLine("Producción media o alta válida para cualquier clasificación"); }
            else
            { Console.WriteLine("Nivel de producción no válido"); }

            break;

    case 2:
        Console.WriteLine("Mostrar reglas del contenido");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("a) Validación técnica");
            Console.ResetColor();
            Console.WriteLine(" - Reglas de clasificación y horario\r\n    Todo público: cualquier hora \r\n    +13: entre 6 y 22 horas \r\n    +18: entre 22 y 5 horas ");
            Console.WriteLine(" - Reglas de duración por tipo \r\n    Película: 60–180 minutos \r\n    Serie: 20–90 minutos \r\n    Documental: 30–120 minutos \r\n    Evento en vivo: 30–240 minutos ");
            Console.WriteLine(" - Reglas de producción \r\n    Producción baja solo válida para Todo público o +13 \r\n   Producción media o alta válida para cualquier clasificación ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("b) Clasificación de impacto");
            Console.ResetColor();
            Console.WriteLine(" Impacto Alto: producción alta, o duración mayor a 120 minutos, o programado entre 20 y 23 horas. \r\n Impacto Medio: producción media o duración entre 60 y 120 minutos. \r\n Impacto Bajo: producción baja y duración menor a 60 minutos.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("c) Decisión final");
            Console.ResetColor();
            Console.WriteLine(" Publicar: cumple todas las reglas técnicas y su impacto es Bajo o Medio. \r\n Publicar con ajustes: cumple reglas técnicas, pero requiere modificación menor (ejemplo: ajustar horario permitido o duración dentro del rango). \r\n Enviar a revisión: cumple reglas técnicas, pero tiene impacto Alto. \r\n Rechazar: incumple alguna regla obligatoria. ");
            break;

    case 3:
            Console.WriteLine("Mostrar estadísticas de la sesión ");
            Console.WriteLine($"El tipo de contenido fue {tipo_contenido}");
            Console.WriteLine($"La duracion del contenido fue {duracion}");
            Console.WriteLine($"La clasificación del contenido fue {clasificacion}");
            Console.WriteLine($"La hora programada del contenido fue {hora_programada}");
            Console.WriteLine($"El nivel de producción del contenido fue {nivel_produccion}");
            break;

    case 4:
        Console.WriteLine("Reiniciar estadísticas ");
            opcion_menu = 0;
            tipo_contenido = "";
            duracion = 0;
            clasificacion = "";
            hora_programada = 0;
            nivel_produccion = "";
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
    Console.Clear();
}
while (opcion_menu != 5);
Console.WriteLine("Saliendo........");