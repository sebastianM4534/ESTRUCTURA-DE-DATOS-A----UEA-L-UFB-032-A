using System;

class Estudiante
{
    public int ID;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3]; // Array para 3 números
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante est = new Estudiante();

        Console.WriteLine("=== Registro de Estudiante ===");

        Console.Write("Ingrese el ID: ");
        est.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");
        est.Direccion = Console.ReadLine();

        Console.WriteLine("\nIngrese los 3 números de teléfono:");

        // Bucle para llenar el arreglo
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar los datos ingresados
        Console.WriteLine("\n=== Datos del Estudiante Registrado ===");
        Console.WriteLine($"ID: {est.ID}");
        Console.WriteLine($"Nombres: {est.Nombres}");
        Console.WriteLine($"Apellidos: {est.Apellidos}");
        Console.WriteLine($"Dirección: {est.Direccion}");
        Console.WriteLine("Teléfonos:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" - {est.Telefonos[i]}");
        }

        Console.WriteLine("\nRegistro completado.");
    }
}
