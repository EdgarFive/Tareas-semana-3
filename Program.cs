//Inicio del programa ============================================================
for (int ii =0; ii != -1;)
{
try
{
Console.Clear();
Console.WriteLine("Bienvenido a \"Tarea Semana 3\".");
Console.WriteLine("Elija una opción:\n1. Calcular el Mayor de Tres Números.\n2. Validar Edad para Ingresar a un Club.\n3. Calcular el Precio Final de un Producto\n4. Validar Usuario y Contraseña\n5. Determinar si un Número es Par o Impar.\n6. Mostrar un Mensaje de Aprobación o Rechazo de Préstamo.\n7. Calcular el Área de una Figura Geométrica\n8. VARIOS EJERCICIOS USANDO SWITCH.\n-1. Cerrar programa.");
int eemenu = int.Parse(Console.ReadLine());
    switch (eemenu)
    {
        case 1:
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese tres números.\nIngrese el primer numero:");
                int enum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                int enum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero:");
                int enum3 = int.Parse(Console.ReadLine());
                if (enum1 > enum2 && enum2 > enum3)
                {
                    Console.WriteLine("El numero mayor es " + enum1);
                }
                else if (enum2 > enum1 && enum1 > enum3)
                {
                    Console.WriteLine("El numero mayor es " + enum2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es " + enum3);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("A ocurrido un error: " + error);
                    Console.ReadKey();
                }
            Console.ReadKey();
            break;
        case 2:
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese su edad en números para verificar si puede ingresar al club:");
                int eedad = int.Parse(Console.ReadLine());
                if (eedad >= 18)
                {
                    Console.WriteLine("Usted si puede ingresar al club");
                }
                else if (eedad <= 18 && eedad > 0)
                {
                    Console.WriteLine("Usted no puede ingresar al club.");
                }
                else
                {
                    Console.WriteLine("El digito ingresado no es valido");
                }
                Console.ReadKey();
            }catch (Exception error)
            {
               Console.WriteLine("A ocurrido un error: " + error);
                    Console.ReadKey();
                }
            break;
        case 3:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el precio en números, del producto que desea comprar para poder aplicarle un 10% de descuento:");
                    double eprecio = double.Parse(Console.ReadLine());
                    double edescuento = eprecio - (eprecio * 10 / 100);
                    Console.WriteLine("El total a pagar es de: " + edescuento);
                    Console.ReadKey();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error: " + error);
                    Console.ReadKey();
                }
                break;
        case 4:
            string eusuario = "Elusu2";
            string econtrasena = "1234";
            for (int i = 0; i != -1;)
            {
                Console.Clear();
                Console.WriteLine("bienvenido al inicio de sesión.\nPara poder ingresar debe agregar su nombre de usuario y contraseña correctos.\nEl nombre de usuario a ingresar es el siguiente: \"Elusu2\" y la contraseña es: \"1234\"\nIngrese su nombre de usuario:");
                string eusu = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña:");
                string econtra = Console.ReadLine();
                if (eusu == eusuario && econtra == econtrasena)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                    i = -1;
                }
                else
                {
                    Console.WriteLine("El usuario o contraseña son incorrectos, ingrese nuevamente.");
                }
                Console.ReadKey();
            }
            break;
        case 5:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el numero que desea saber si es par o impar:");
                    double enumero = double.Parse(Console.ReadLine());
                    double eprueba = enumero % 2;
                    if (eprueba == 0)
                    {
                        Console.WriteLine("El numero SI es par.");
                    }
                    else
                    {
                        Console.WriteLine("El numero NO es par");
                    }
                    Console.ReadKey();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error: " + error);
                    Console.ReadKey();
                }
            break;
        case 6:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Para aprobar su prestamo se necesita saber la cantidad del monto y su edad.\nIngrese la cantidad del préstamo solicitado:");
                    double emonto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora debe ingresar su edad:");
                    int eeedad = int.Parse(Console.ReadLine());

                    if (emonto < 5000 || eeedad > 60)
                    {
                        Console.WriteLine("Su solicitud a sido APROBADA.");
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, su solicitud NO a sido aprobada");
                    }
                    Console.ReadKey();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error: " + error);
                    Console.ReadKey();
                }
            break;
        case 7:
                try
                {
            Console.Clear();
            Console.WriteLine("Elija la figura de la cual quiere saber el área:\n1. Triangulo.\n2. Cuadrado.\n3. Círculo.");
            int emenu = int.Parse(Console.ReadLine());
            switch (emenu)
            {
                case 1:
                            try
                            {
                                Console.WriteLine("Debe ingresar la base y la altura del triangulo.\nIngresar la base:");
                                double ebase = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresar la altura:");
                                double ealtura = double.Parse(Console.ReadLine());
                                double earea = ebase * ealtura * 1 / 2;
                                Console.WriteLine("El area del triangulo es: " + earea);
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine("Ah ocurrido un error: " + error);
                                Console.ReadKey();
                            }
                            
                    break;
                case 2:
                            try
                            {
                                //=========================================================
                                Console.WriteLine("Debe ingresar el tamaño de un lado del cuadrado.\nIngrese el tamaño del lado del cuadrado:");
                                double ecuadrado = double.Parse(Console.ReadLine());
                                double earea = Math.Pow(ecuadrado, 2);
                                Console.WriteLine("El área del cuadrado es de: " + earea);
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine("Ah ocurrido un error: " + error);
                                Console.ReadKey();
                            }
                    break;
                case 3:
                            try
                            {
                                //=========================================================
                                Console.WriteLine("Debe ingresar el radio de la esfera:\nIngrese el radio: ");
                                double eradio = double.Parse(Console.ReadLine());
                                double earea = Math.PI * Math.Pow(eradio, 2);
                                Console.WriteLine("El area del circulo es de:" + earea);
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine("Ah ocurrido un error: " + error);
                                Console.ReadKey();
                            }
                    break;
            }
            Console.ReadKey();
                } catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error: " + error );
                    Console.ReadKey();
                }
            break;
        case 8:
                for (int jj = 0; jj != -1;)
                {
                    try
                    {
                        //=========================================================
                        Console.Clear();
                        Console.WriteLine("EJERCICIOS USANDO SWITCH.\n1. Convertir un Número de Letra a Número.\n2. Mostrar el Día de la Semana a partir de un Número.\n3. Calcular el Importe a Pagar por un Servicio.\n4. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas.\n5. Evaluar la Calificación de un Examen.\n-1. Atras.");
                        int emenu2 = int.Parse(Console.ReadLine());
                        switch (emenu2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese un numero del uno al cinco en letras para poder convertirlo en número");
                                string enumno = Console.ReadLine();
                                enumno.ToLower();
                                switch (enumno)
                                {
                                    case "uno":
                                        int num = 1;
                                        Console.WriteLine("El número que elejiste es: " + num);
                                        break;
                                    case "dos":
                                        num = 2;
                                        Console.WriteLine("El número que elejiste es: " + num);
                                        break;
                                    case "tres":
                                        num = 3;
                                        Console.WriteLine("El número que elejiste es: " + num);
                                        break;
                                    case "cuatro":
                                        num = 4;
                                        Console.WriteLine("El número que elejiste es: " + num);
                                        break;
                                    case "cinco":
                                        num = 5;
                                        Console.WriteLine("El número que elejiste es: " + num);
                                        break;
                                    default:
                                        Console.WriteLine("Lo siento, el número ingresado no está en la lista.");
                                        break;
                                }
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese un numero del 1 al 7:");
                                int eenumno = int.Parse(Console.ReadLine());
                                switch (eenumno)
                                {
                                    case 1:
                                        Console.WriteLine("Domingo");
                                        break;
                                    case 2:
                                        Console.WriteLine("Lunes");
                                        break;
                                    case 3:
                                        Console.WriteLine("Martes");
                                        break;
                                    case 4:
                                        Console.WriteLine("Miércoles");
                                        break;
                                    case 5:
                                        Console.WriteLine("Jueves");
                                        break;
                                    case 6:
                                        Console.WriteLine("Viernes");
                                        break;
                                    case 7:
                                        Console.WriteLine("Sabado");
                                        break;
                                    default:
                                        Console.WriteLine("El número ingresado no es correcto.");
                                        break;
                                }
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Elija el tipo de servicio que desea para saber su costo:\n1. Lavado de auto.\n2. Cambio de aceite.\n3. Revisión mecánica.");
                                int enumm = int.Parse(Console.ReadLine());
                                switch (enumm)
                                {
                                    case 1:
                                        Console.WriteLine("Lavado de auto:\nEl importe a pagar es de: Q20.00");
                                        break;
                                    case 2:
                                        Console.WriteLine("Cambio de aceite:\nEl importe a pagar es de: Q35.00");
                                        break;
                                    case 3:
                                        Console.WriteLine("Revisión mecánica:\nEl importe a pagar es de: Q50.00");
                                        break;
                                    default:
                                        Console.WriteLine("La opción ingresada no es valida.");
                                        break;
                                }
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese en texto el idioma de su preferencia:\nEspañol.\tInglés.\t\tfrancés.");
                                string eidio = Console.ReadLine();
                                eidio.ToLower();

                                switch (eidio)
                                {
                                    case "español":
                                        Console.WriteLine("Hola, bienvenido");
                                        break;
                                    case "inglés":
                                        Console.WriteLine("Hello, welcome.");
                                        break;
                                    case "francés":
                                        Console.WriteLine("Bonjour, bienvenue");
                                        break;
                                    default:
                                        Console.WriteLine("La opción que ingresó no está en la lista o ingresó mal algún caracter.");
                                        break;
                                }
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingrese con números la calificación de el examen para saber el desempeño.\nIngrese la nota:");
                                string enotaa = Console.ReadLine();
                                if (int.TryParse(enotaa, out int eenumm))
                                {
                                    switch (eenumm)
                                    {
                                        case >= 90 and <= 100:
                                            Console.WriteLine("Sobresaliente.");
                                            break;
                                        case >= 80 and <= 89:
                                            Console.WriteLine("Notable.");
                                            break;
                                        case >= 70 and <= 79:
                                            Console.WriteLine("Aprobatoria.");
                                            break;
                                        case >= 62 and <= 69:
                                            Console.WriteLine("Semi aprobatoria.");
                                            break;
                                        case 61:
                                            Console.WriteLine("Nota minima para aprobar.");
                                            break;
                                        case >= 0 and <= 60:
                                            Console.WriteLine("Nota Reprobatoria");
                                            break;
                                        default:
                                            Console.WriteLine("La nota ingresada no es valida.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Los dígitos ingresados no son validos.");
                                }
                                Console.ReadKey();
                                break;
                            default:
                                if (emenu2 == -1)
                                {
                                    jj = -1;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("El dígito ingresado no es valido. Inténtelo de nuevo.");
                                    Console.ReadKey();
                                }
                                break;
                        }
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Ah ocurrido un error: " + error);
                        Console.ReadKey();
                    }
                }
            break;
        default:
                if (eemenu == -1)
                {
                   ii = -1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El dígito ingresado no es valido. Inténtelo de nuevo.");
                    Console.ReadKey();
                }
            break;
    }
    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}
