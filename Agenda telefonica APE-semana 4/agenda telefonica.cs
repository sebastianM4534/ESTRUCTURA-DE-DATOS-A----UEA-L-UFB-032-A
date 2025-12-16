using System; // Permite usar funcionalidades básicas como Console

// Clase Contacto: representa un registro (estructura de datos tipo registro)
class Contacto
{
    // Atributos del contacto (uso de tipos primitivos y arrays)
    public string Nombre;
    public string Apellido;

    // Array para almacenar hasta 3 números telefónicos por contacto
    public string[] Telefonos = new string[3];
}

// Clase principal del programa
class AgendaTelefonica
{
    // Método principal donde inicia la ejecución del programa
    static void Main(string[] args)
    {
        // Array de objetos Contacto (estructura de datos tipo vector)
        Contacto[] agenda = new Contacto[5]; // Capacidad máxima de 5 contactos

        int contador = 0; // Controla cuántos contactos se han registrado
        int opcion;       // Almacena la opción del menú

        // Ciclo do-while para mostrar el menú hasta que el usuario decida salir
        do
        {
            // Menú principal del sistema
            Console.WriteLine("\n===== AGENDA TELEFÓNICA =====");
            Console.WriteLine("1. Registrar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Lectura de la opción ingresada por el usuario
            opcion = int.Parse(Console.ReadLine());

            // Estructura de control para manejar las opciones del menú
            switch (opcion)
            {
                case 1: // Registrar un nuevo contacto
                    if (contador < agenda.Length)
                    {
                        // Se crea un nuevo objeto Contacto
                        agenda[contador] = new Contacto();

                        Console.Write("Nombre: ");
                        agenda[contador].Nombre = Console.ReadLine();

                        Console.Write("Apellido: ");
                        agenda[contador].Apellido = Console.ReadLine();

                        // Ciclo for para ingresar los números telefónicos
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write($"Teléfono {i + 1}: ");
                            agenda[contador].Telefonos[i] = Console.ReadLine();
                        }

                        contador++; // Incrementa el número de contactos registrados
                        Console.WriteLine("Contacto registrado correctamente.");
                    }
                    else
                    {
                        // Mensaje cuando el vector está lleno
                        Console.WriteLine("La agenda está llena.");
                    }
                    break;

                case 2: // Mostrar todos los contactos registrados
                    Console.WriteLine("\n--- LISTA DE CONTACTOS ---");

                    // Recorre el array de contactos registrados
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Nombre: {agenda[i].Nombre} {agenda[i].Apellido}");

                        // Recorre el array de teléfonos del contacto
                        foreach (string tel in agenda[i].Telefonos)
                        {
                            Console.WriteLine("Teléfono: " + tel);
                        }

                        Console.WriteLine("----------------------------");
                    }
                    break;

                case 3: // Buscar un contacto por nombre
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;

                    // Búsqueda secuencial dentro del vector
                    for (int i = 0; i < contador; i++)
                    {
                        if (agenda[i].Nombre.Equals(buscar, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Contacto encontrado: {agenda[i].Nombre} {agenda[i].Apellido}");

                            foreach (string tel in agenda[i].Telefonos)
                            {
                                Console.WriteLine("Teléfono: " + tel);
                            }

                            encontrado = true;
                        }
                    }

                    // Mensaje si no se encontró el contacto
                    if (!encontrado)
                    {
                        Console.WriteLine("Contacto no encontrado.");
                    }
                    break;

                case 4: // Salir del programa
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default: // Control de opciones inválidas
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4); // El programa se repite hasta que el usuario elija salir
    }
}
