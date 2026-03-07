using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, Libro> libros = new Dictionary<string, Libro>();
    static HashSet<string> autores = new HashSet<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Registrar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Mostrar autores");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarLibro();
                    break;

                case "2":
                    MostrarLibros();
                    break;

                case "3":
                    MostrarAutores();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    static void RegistrarLibro()
    {
        Console.Write("Código del libro: ");
        string codigo = Console.ReadLine();

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Año de publicación: ");
        string anio = Console.ReadLine();

        Libro libro = new Libro(titulo, autor, anio);

        libros[codigo] = libro;
        autores.Add(autor);

        Console.WriteLine("Libro registrado correctamente.");
    }

    static void MostrarLibros()
    {
        Console.WriteLine("\nListado de libros:");

        foreach (var item in libros)
        {
            Console.WriteLine("Código: " + item.Key +
                              " | Título: " + item.Value.Titulo +
                              " | Autor: " + item.Value.Autor +
                              " | Año: " + item.Value.Anio);
        }
    }

    static void MostrarAutores()
    {
        Console.WriteLine("\nAutores registrados:");

        foreach (var autor in autores)
        {
            Console.WriteLine(autor);
        }
    }
}

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Anio { get; set; }

    public Libro(string titulo, string autor, string anio)
    {
        Titulo = titulo;
        Autor = autor;
        Anio = anio;
    }
}