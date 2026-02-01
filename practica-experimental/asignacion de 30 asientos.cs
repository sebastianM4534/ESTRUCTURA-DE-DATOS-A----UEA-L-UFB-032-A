using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase que representa a una persona
    class Persona
    {
        public string Nombre { get; set; }
        public int Turno { get; set; }

        public Persona(string nombre, int turno)
        {
            Nombre = nombre;
            Turno = turno;
        }
    }

    // Clase principal del sistema
    class SistemaAsientos
    {
        private Queue<Persona> colaPersonas;
        private const int MAX_ASIENTOS = 30;
        private int turnoActual;

        public SistemaAsientos()
        {
            colaPersonas = new Queue<Persona>();
            turnoActual = 1;
        }

        // Registrar persona en la cola
        public void RegistrarPersona()
        {
            if (colaPersonas.Count >= MAX_ASIENTOS)
            {
                Console.WriteLine("Todos los asientos ya han sido vendidos.\n");
                return;
            }

            Console.Write("Ingrese el nombre de la persona: ");
            string nombre = Console.ReadLine();

            Persona nuevaPersona = new Persona(nombre, turnoActual);
            colaPersonas.Enqueue(nuevaPersona);

            Console.WriteLine($"Persona registrada: {nombre} | Turno: {turnoActual}\n");
            turnoActual++;
        }

        // Mostrar personas en cola
        public void MostrarCola()
        {
            if (colaPersonas.Count == 0)
            {
                Console.WriteLine("La cola está vacía.\n");
                return;
            }

            Console.WriteLine("Personas en cola:");
            foreach (Persona p in colaPersonas)
            {
                Console.WriteLine($"- {p.Nombre} (Turno {p.Turno})");
            }
            Console.WriteLine();
        }

        // Asignar asientos
        public void AsignarAsientos()
        {
            if (colaPersonas.Count == 0)
            {
                Console.WriteLine("No hay personas para asignar asientos.\n");
                return;
            }

            Console.WriteLine("ASIGNACIÓN DE ASIENTOS:\n");
            int numeroAsiento = 1;

            while (colaPersonas.Count > 0)
            {
                Persona persona = colaPersonas.Dequeue();
                Console.WriteLine($"Asiento {numeroAsiento}: {persona.Nombre} (Turno {persona.Turno})");
                numeroAsiento++;
            }

            Console.WriteLine("\n Todos los asientos fueron asignados correctamente.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SistemaAsientos sistema = new SistemaAsientos();
            int opcion;

            do
            {
                Console.WriteLine("=== SISTEMA DE ASIGNACIÓN DE ASIENTOS ===");
                Console.WriteLine("1. Registrar persona");
                Console.WriteLine("2. Mostrar cola");
                Console.WriteLine("3. Asignar asientos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        sistema.RegistrarPersona();
                        break;
                    case 2:
                        sistema.MostrarCola();
                        break;
                    case 3:
                        sistema.AsignarAsientos();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
