using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Traductor
{
    static void Main(string[] args)
    {
        // Diccionario bidireccional
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        int opcion;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;

                case 2:
                    AgregarPalabra(diccionario);
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine();

        // Separar palabras conservando signos de puntuación
        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            // Limpiar signos de puntuación
            string palabraLimpia = Regex.Replace(palabras[i], @"[^\w]", "");

            if (diccionario.ContainsKey(palabraLimpia.ToLower()))
            {
                string traduccion = diccionario[palabraLimpia.ToLower()];

                // Reemplazar solo la palabra limpia dentro del texto original
                palabras[i] = palabras[i].Replace(palabraLimpia, traduccion);
            }
        }

        string resultado = string.Join(" ", palabras);

        Console.WriteLine("\nTraducción:");
        Console.WriteLine(resultado);
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese la palabra en español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}