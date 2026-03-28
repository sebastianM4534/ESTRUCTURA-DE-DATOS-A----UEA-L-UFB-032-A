using System;
using System.Collections.Generic;

namespace Grafos
{
    class Program
    {
        static void MostrarGrafo(Dictionary<string, List<string>> grafo)
        {
            foreach (var nodo in grafo)
            {
                Console.Write(nodo.Key + " -> ");
                foreach (var conexion in nodo.Value)
                {
                    Console.Write(conexion + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== GRAFO 1: CONEXION DE CIUDADES =====");

            Dictionary<string, List<string>> grafoCiudades = new Dictionary<string, List<string>>()
            {
                {"Quito", new List<string>{"Ambato", "Ibarra"}},
                {"Ambato", new List<string>{"Riobamba"}},
                {"Ibarra", new List<string>{"Tulcan"}},
                {"Riobamba", new List<string>()},
                {"Tulcan", new List<string>()}
            };

            MostrarGrafo(grafoCiudades);

            Console.WriteLine("\n===== GRAFO 2: RED SOCIAL =====");

            Dictionary<string, List<string>> grafoSocial = new Dictionary<string, List<string>>()
            {
                {"Ana", new List<string>{"Luis", "Pedro"}},
                {"Luis", new List<string>{"Ana", "Carlos"}},
                {"Pedro", new List<string>{"Ana"}},
                {"Carlos", new List<string>{"Luis"}}
            };

            MostrarGrafo(grafoSocial);

            Console.ReadKey();
        }
    }
}