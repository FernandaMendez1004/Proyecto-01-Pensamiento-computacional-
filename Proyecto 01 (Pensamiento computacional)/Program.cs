Console.ForegroundColor = ConsoleColor.Magenta;
Linea(32, "=");
Console.WriteLine("               Proyecto 01 - Plataforma Streaming ");
Linea(32, "=");
Console.WriteLine();
Console.ResetColor();

string tipo_contenido = "";
int duracion = 0;
string clasificacion = "";
int hora_programada = 0;
string nivel_produccion = "";
bool correcto;
int opcion_menu = 0;
int total = 0;
int publicados = 0;
int rechazados = 0;
int revision = 0;
bool duracionValida = false;
bool horarioValido = false;
bool produccionValida = false;
bool requiereAjuste = false;
bool cumpleTodo = false;
int impactoAlto = 0;
int impactoMedio = 0;
int impactoBajo = 0;



string PedirTipoContenido()
{
    string tipo;
    
    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.WriteLine("                       Tipo de Contenido ");
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"Ingrese tipo de contenido 
  Estas son las distintas opciones:
    - Película
    - Serie
    - Documental
    - Evento en vivo
 Elija una opción:");
        tipo = Console.ReadLine().ToLower()
       .Replace("í", "i");
       

        if (tipo != "pelicula" && tipo != "serie" && tipo != "documental" && tipo != "evento en vivo")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tipo de contenido no válido");
            Console.WriteLine("Intente de nuevo.........");
            Console.WriteLine();
            Console.ResetColor();
        }

    } while (tipo != "pelicula" && tipo != "serie" && tipo != "documental" && tipo != "evento en vivo");
    Console.ResetColor();
    return tipo;
}

string PedirNivelProduccion()
{
    string nivel;
    
    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.WriteLine("                   Nivel de Producción ");
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"Ingrese el nivel de producción
  Estas son las distintas opciones: 
    - Bajo
    - Medio
    - Alto
Elija una opción:");
        nivel = Console.ReadLine().ToLower()
        .Trim();

        if (nivel != "bajo" && nivel != "medio" && nivel != "alto")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nivel de producción no válido");
            Console.WriteLine("Intente de nuevo.........");
            Console.WriteLine();
            Console.ResetColor();
        }

    } while (nivel != "bajo" && nivel != "medio" && nivel != "alto");
    Console.ResetColor();
    return nivel;
}

string PedirClasificacion()
{
    string tipo;
    
    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.WriteLine("                 Clasificación de Contenido");
        Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
        Console.ResetColor(); 
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"Ingrese la clasificación del contenido 
  Estas son las distintas opciones: 
    - Todo público
    - +13
    - +18 
Elija una opción:");
        tipo = Console.ReadLine().ToLower()
        .Replace("ú", "u")
       .Trim();

        if (tipo != "todo publico" && tipo != "+13" && tipo != "+18")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tipo de contenido no válido");
            Console.WriteLine("Intente de nuevo.........");
            Console.WriteLine();
            Console.ResetColor();
        }
        
    } while (tipo != "todo publico" && tipo != "+13" && tipo != "+18");
    Console.ResetColor();
    return tipo;
}

static void Linea(int cantidad, string simbolo)
{
    for (int i = 0; i < cantidad; i++)
    {
        Console.Write(simbolo + " ");
    }
    Console.WriteLine();
}
int MenuInicio ()
{
    do { 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" 1. Evaluar nuevo contenido");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" 2. Mostrar reglas del sistema");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" 3. Mostrar estadísticas de la sesión");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" 4. Reiniciar estadísticas");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" 5. Salir");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("Elija una opcion ");
    correcto = int.TryParse(Console.ReadLine(), out opcion_menu);
    Console.WriteLine();
    Console.ResetColor();

    
        if (opcion_menu != 1 && opcion_menu != 2 && opcion_menu != 3 && opcion_menu != 4 && opcion_menu != 5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            correcto = false;
            Console.WriteLine("Opción inválida ");
            Console.WriteLine("Inserte cualquier tecla para continuar....");
            Console.WriteLine();
            Console.ResetColor();
        }
    
} while (opcion_menu != 1 && opcion_menu != 2 && opcion_menu != 3 && opcion_menu != 4 && opcion_menu != 5);
    return opcion_menu;
}


do
{
    Console.ForegroundColor= ConsoleColor.Yellow;
    Linea(32, "=");
    Console.ResetColor(); 
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("                    MENÚ PRINCIPAL");
    Console.ForegroundColor = ConsoleColor.Yellow;  Linea(32, "="); Console.ResetColor();
    opcion_menu = MenuInicio();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Linea(32, "=");
    Console.ResetColor();

    switch (opcion_menu)
        {
            case 1:
            tipo_contenido = PedirTipoContenido(); // Validar tipo de contenido
            Console.ForegroundColor = ConsoleColor.Green;
            Linea(32, "*");
            Console.ResetColor();
            do
            {
                Console.WriteLine("Ingrese la duración en minutos (0 - 240)");
                correcto = int.TryParse(Console.ReadLine(), out duracion); // Validar duración según tipo de contenido 1 if
                Console.ResetColor();

                if (!correcto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Ingrese un valor numerico");
                    Console.WriteLine("Inserte cualquier tecla para continuar....");
                    Console.WriteLine();
                    Console.ResetColor();
                }

                if (duracion < 0 || duracion > 240)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Opción inválida");
                    Console.WriteLine("Inserte cualquier tecla para continuar....");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            while (!correcto || duracion < 0 || duracion > 240);

                if (tipo_contenido == "pelicula")
                {
                if (duracion < 60 || duracion > 180)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Contenido rechazado");
                    Console.WriteLine("La duración no es válida para una película");
                    Console.WriteLine();
                    duracionValida = false;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Duración válida para película");
                    Console.WriteLine();
                    duracionValida = true;
                    Console.ResetColor();
                }
                }
                else if (tipo_contenido == "serie")
                {
                if (duracion < 20 || duracion > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Contenido rechazado");
                    Console.WriteLine("La duración no es válida para una serie");
                    duracionValida = false;
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Duración válida para serie");
                    Console.WriteLine();
                    duracionValida = true;
                    Console.ResetColor();
                }
                }
                else if (tipo_contenido == "documental")
                {
                    if (duracion < 30 || duracion > 120)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Contenido rechazado");
                    Console.WriteLine("La duración no es válida para un documental");
                    duracionValida = false;
                    Console.WriteLine();
                    Console.ResetColor();
                }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Duración válida para documental");
                    Console.WriteLine();
                    duracionValida = true;
                    Console.ResetColor();
                }
                }
                else if (tipo_contenido == "evento en vivo")
                {
                    if (duracion < 30 || duracion > 240)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Contenido rechazado");
                    Console.WriteLine("La duración no es válida para un evento en vivo");
                    duracionValida = false;
                    Console.WriteLine();
                    Console.ResetColor();
                }
                    else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Duración válida para evento en vivo");
                    Console.WriteLine();
                    duracionValida = true;
                    Console.ResetColor();
                }
                }
                else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Contenido rechazado");
                duracionValida = false;
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Linea(32, "*");
            Console.ResetColor();
            clasificacion = PedirClasificacion(); // Validar clasificación y horario 2 if
            Console.ForegroundColor = ConsoleColor.Green;
            Linea(32, "*");
            Console.ResetColor();
            do
            {
                Console.WriteLine("Ingrese la hora programada (0-23)");
                Console.WriteLine("Escribe solo la hora en formato 24 horas");
                correcto = int.TryParse(Console.ReadLine(), out hora_programada); // Validar duración según tipo de contenido 1 if
                Console.WriteLine();
                if (!correcto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Ingrese un valor numerico");
                    Console.WriteLine("Inserte cualquier tecla para continuar....");
                    Console.WriteLine();
                    Console.ResetColor();
                }

                if (hora_programada < 0 || hora_programada > 23)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    correcto = false;
                    Console.WriteLine("Opción inválida");
                    Console.WriteLine("Inserte cualquier tecla para continuar....");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            while (!correcto || hora_programada < 0 || hora_programada > 23);

            if (clasificacion == "todo publico")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Clasificación válida para cualquier horario");
           
                Console.ResetColor();
                horarioValido = true;
            }
            else if (clasificacion == "+13")
            {
                if (hora_programada >= 6 && hora_programada <= 22)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Horario válido para clasificación +13");
                  
                    Console.ResetColor();
                    horarioValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rechazar: En la clasificación +13 solo se permite el horario entre 6 y 22 horas");
                   
                    Console.ResetColor();
                    horarioValido = false;
                }
            }
            else if (clasificacion == "+18")
            {
                if (hora_programada >= 22 || hora_programada <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Horario válido para clasificación +18");
                   Console.ResetColor();
                    horarioValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rechazar: +18 solo se permite entre 22 y 5 horas");
                   
                    Console.ResetColor();
                    horarioValido = false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Linea(32, "*");
            Console.ResetColor();
            Console.WriteLine();
            nivel_produccion = PedirNivelProduccion().ToLower().Trim();

            if (nivel_produccion == "bajo")
            {
                if (clasificacion == "todo publico" || clasificacion == "+13")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Producción baja válida para clasificación");
                    Console.WriteLine();
                    Console.ResetColor();
                    produccionValida = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rechazar: producción baja solo válida para todo público o +13");
                    Console.WriteLine();
                    Console.ResetColor();
                    produccionValida = false;
                }
            }
            else if (nivel_produccion == "medio" || nivel_produccion == "alto")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Producción válida");
                Console.WriteLine();
                Console.ResetColor();
                produccionValida = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nivel de producción no válido");
                Console.WriteLine();
                produccionValida = false;
            }
           cumpleTodo = duracionValida && horarioValido && produccionValida;
            if (!cumpleTodo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RECHAZAR  - No cumple las reglas técnicas");
               Console.WriteLine("Duración: " + duracionValida);
                Console.WriteLine("Horario: " + horarioValido);
                Console.WriteLine("Producción: " + produccionValida);
                Console.WriteLine("Inserte cualquier tecla para continuar....");
                Console.ResetColor();
                return; 
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Linea(32, "*");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            string impacto = "Bajo";
            if (nivel_produccion == "alto" || duracion > 120 || (hora_programada >= 20 && hora_programada <= 23))
            {
                impacto = "Alto";
            }
            else if (nivel_produccion == "medio" || (duracion >= 60 && duracion <= 120))
            {
                impacto = "Medio";
            }
            else if (nivel_produccion == "bajo" && duracion < 60)
            {
                impacto = "Bajo";
            }

            if (cumpleTodo)
            {
                if (impacto == "Alto")
                    impactoAlto++;
                else if (impacto == "Medio")
                    impactoMedio++;
                else if (impacto == "Bajo")
                    impactoBajo++;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Clasificación de impacto: " + impacto);
            Console.ResetColor();

         
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Linea(32, "=");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                DECISIÓN FINAL "); 
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Linea(32, "=");
            Console.WriteLine();
            Console.ResetColor();

            if (!cumpleTodo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RECHAZAR ");

                if (!duracionValida)
                    Console.WriteLine("Duración inválida");

                if (!horarioValido)
                    Console.WriteLine("Horario no permitido");

                if (!produccionValida)
                    Console.WriteLine("Producción no válida");
                Console.ResetColor();
                total++;
                rechazados++;
            }
            else
            {
                requiereAjuste = false;

                if (duracion == 60 || duracion == 120 || hora_programada == 6 || hora_programada == 22)
                {
                    requiereAjuste = true;
                }

                if (impacto == "Alto")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enviar a revisión ");
                    revision++;
                }
                else if (requiereAjuste)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Publicar con ajustes");
                    publicados++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Publicar");
                    publicados++;
                }

                Console.ResetColor();
                total++;
            }
            break;

        case 2:
            Console.WriteLine("Mostrar reglas del contenido");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("a) Validación técnica");
                Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" - Reglas de clasificación y horario\r\n    Todo público: cualquier hora \r\n    +13: entre 6 y 22 horas \r\n    +18: entre 22 y 5 horas ");
                Console.WriteLine(" - Reglas de duración por tipo \r\n    Película: 60–180 minutos \r\n    Serie: 20–90 minutos \r\n    Documental: 30–120 minutos \r\n    Evento en vivo: 30–240 minutos ");
                Console.WriteLine(" - Reglas de producción \r\n    Producción baja solo válida para Todo público o +13 \r\n    Producción media o alta válida para cualquier clasificación ");
                Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("b) Clasificación de impacto");
                Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Impacto Alto: producción alta, o duración mayor a 120 minutos, o programado entre 20 y 23 horas. \r\n Impacto Medio: producción media o duración entre 60 y 120 minutos. \r\n Impacto Bajo: producción baja y duración menor a 60 minutos.");
                Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("c) Decisión final");
                Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Publicar: cumple todas las reglas técnicas y su impacto es Bajo o Medio. \r\n Publicar con ajustes: cumple reglas técnicas, pero requiere modificación menor (ejemplo: ajustar horario permitido o duración dentro del rango). \r\n Enviar a revisión: cumple reglas técnicas, pero tiene impacto Alto. \r\n Rechazar: incumple alguna regla obligatoria. ");
            Console.ResetColor();
            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Linea(32, "=");
            Console.WriteLine("           ESTADÍSTICAS DE LA SESIÓN");
            Linea(32, "=");
            Console.ResetColor(); 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total evaluados: " + total);
            Console.WriteLine("Publicados: " + publicados);
            Console.WriteLine("Rechazados: " + rechazados);
            Console.WriteLine("En revisión: " + revision);
            double porcentaje = total > 0 ? (publicados * 100.0 / total) : 0;
            Console.WriteLine("Porcentaje de aprobación: " + porcentaje + "%");
            string predominante = "Ninguno";
            if (impactoAlto >= impactoMedio && impactoAlto >= impactoBajo)
            {
                predominante = "Alto";
            }
            else if (impactoMedio >= impactoAlto && impactoMedio >= impactoBajo)
            {
                predominante = "Medio";
            }
            else
            {
                predominante = "Bajo";
            }
            Console.WriteLine("Impacto predominante: " + predominante);
            Console.ResetColor();
            break;

        case 4:
            Console.WriteLine("Reiniciar estadísticas ");
            total = 0;
            publicados = 0;
            rechazados = 0;
            revision = 0;
            impactoAlto = 0;
            impactoMedio = 0;
            impactoBajo = 0;
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