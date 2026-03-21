Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
Console.WriteLine("            PROYECTO 01 - PLATAFORMA STREAMING");
Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
Console.WriteLine();
Console.ResetColor();

string tipo_contenido = "";
int duracion = 0;
string clasificacion = "";
int hora_programada = 0;
string nivel_produccion = "";
bool correcto;
int opcion_menu = 0;

string razon = "";
bool duracionValida = false;
bool horarioValido = false;
string PedirTipoContenido()
{
    string tipo;

    do
    {
        Console.WriteLine("Ingrese tipo de contenido (pelicula, serie, documental, evento en vivo):");
        tipo = Console.ReadLine().ToLower();

        if (tipo != "pelicula" && tipo != "serie" && tipo != "documental" && tipo != "evento en vivo")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: tipo de contenido no válido");
            Console.WriteLine("Intente de nuevo.........");
            Console.ResetColor();
        }

    } while (tipo != "pelicula" && tipo != "serie" && tipo != "documental" && tipo != "evento en vivo");

    return tipo;
}

string PedirClasificacion()
{
    string tipo;

    do
    {
        Console.WriteLine("Ingrese la clasificación (todo publico, +13, +18): ");
        tipo = Console.ReadLine().ToLower();

        if (tipo != "todo publico" && tipo != "+13" && tipo != "+18")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: clasificación no válida");
            Console.WriteLine("Intente de nuevo.........");
            Console.ResetColor();
        }

    } while (tipo != "todo publico" && tipo != "+13" && tipo != "+18");

    return tipo;
}

int MenuInicio ()
{
    do { 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" 1. Evaluar nuevo contenido");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" 2. Mostrar reglas del sistema");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" 3. Mostrar estadísticas de la sesión");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" 4. Reiniciar estadísticas");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" 5. Salir");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("Elija una opcion ");
    correcto = int.TryParse(Console.ReadLine(), out opcion_menu);
    Console.WriteLine();
    Console.ResetColor();

    if (correcto)
    {
        if (opcion_menu < 1 || opcion_menu > 5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            correcto = false;
            Console.WriteLine("Opción inválida");
                Console.WriteLine();
            Console.ResetColor();
        }
    }
} while (!correcto || opcion_menu <1 || opcion_menu >5);
    return opcion_menu;
}



do
{
    opcion_menu = MenuInicio();

    switch (opcion_menu)
        {
            case 1:
                Console.WriteLine("Evaluar nuevo contenido");
                tipo_contenido = PedirTipoContenido(); // Validar tipo de contenido
                
            do
            {
                Console.WriteLine("Ingrese la duración en minutos");
                correcto = int.TryParse(Console.ReadLine(), out duracion); // Validar duración según tipo de contenido 1 if
                Console.WriteLine();
                Console.ResetColor();

                if (!correcto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: debe ingresar un número");
                    Console.ResetColor();
                }

                if ( duracion < 0 || duracion > 240)
                {
                      Console.ForegroundColor = ConsoleColor.Red;
                      correcto = false;
                      Console.WriteLine("Opción inválida");
                      Console.WriteLine();
                      Console.ResetColor();
                }
              
            }
            while (!correcto || duracion < 0 || duracion > 240  || (tipo_contenido == "pelicula" && (duracion < 60 || duracion > 180)) || (tipo_contenido == "serie" && (duracion < 20 || duracion > 90)) || (tipo_contenido == "documental" && (duracion < 30 || duracion > 120)) || (tipo_contenido == "evento en vivo" && (duracion < 30 || duracion > 240)));

                if (tipo_contenido == "pelicula")
                {
                if (duracion < 60 || duracion > 180)
                {
                    Console.WriteLine("Contenido rechazado");
                    duracionValida = false;
                }
                else
                {
                    Console.WriteLine("Duración válida para película");
                    duracionValida = true;
                }
                }
                else if (tipo_contenido == "serie")
                {
                if (duracion < 20 || duracion > 90)
                {
                    Console.WriteLine("Contenido rechazado");
                    duracionValida = false;
                }
                else
                {
                    Console.WriteLine("Duración válida para serie");
                    duracionValida = true;
                }
                }
                else if (tipo_contenido == "documental")
                {
                    if (duracion < 30 || duracion > 120)
                { Console.WriteLine("Contenido rechazado");
                    duracionValida = false;
                }
                    else
                    { Console.WriteLine("Duración válida para documental");
                    duracionValida = true;
                    }
                }
                else if (tipo_contenido == "evento en vivo")
                {
                    if (duracion < 30 || duracion > 240)
                    { Console.WriteLine("Contenido rechazado");
                    duracionValida = false;
                }
                    else
                { 
                    Console.WriteLine("Duración válida para evento en vivo");
                    duracionValida = true;
                }
                }
                else
                { Console.WriteLine("Tipo de contenido no válido"); 
                razon = razon + "Tipo de contenido no válido";
            }

                Console.WriteLine();
                Console.WriteLine("Evaluar clasificacion");
                clasificacion = PedirClasificacion(); // Validar clasificación y horario 2 if

            do
            {
                Console.WriteLine("Ingrese la hora programada (0-23)");
                correcto = int.TryParse(Console.ReadLine(), out hora_programada); // Validar duración según tipo de contenido 1 if
                Console.WriteLine();
                if (!correcto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Ingrese un valor numerico");
                    Console.WriteLine();
                    Console.ResetColor();
                }

                if (hora_programada < 0 || hora_programada > 23)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Opción inválida");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            while (!correcto || hora_programada < 0 || hora_programada > 23);

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


                Console.WriteLine();
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
                Console.WriteLine(" - Reglas de producción \r\n    Producción baja solo válida para Todo público o +13 \r\n    Producción media o alta válida para cualquier clasificación ");
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
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
    while (opcion_menu != 5);
    Console.WriteLine("Saliendo........");