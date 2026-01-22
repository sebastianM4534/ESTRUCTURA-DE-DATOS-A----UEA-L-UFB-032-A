using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    // Función para mostrar el estado actual de las torres
    static void MostrarTorres(
        Stack<int> torreA,
        Stack<int> torreB,
        Stack<int> torreC)
    {
        Console.WriteLine("A: " + string.Join(", ", torreA));
        Console.WriteLine("B: " + string.Join(", ", torreB));
        Console.WriteLine("C: " + string.Join(", ", torreC));
        Console.WriteLine(new string('-', 30));
    }

    // Función para mover un disco entre torres
    static void MoverDisco(
        Stack<int> origen,
        Stack<int> destino,
        char nombreOrigen,
        char nombreDestino)
    {
        int disco = origen.Pop();     // Extrae el disco superior
        destino.Push(disco);          // Inserta el disco en la torre destino
        Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
    }

    // Función recursiva que resuelve el problema de Hanoi
    static void Hanoi(
        int n,
        Stack<int> origen,
        Stack<int> auxiliar,
        Stack<int> destino,
        char nombreOrigen,
        char nombreAuxiliar,
        char nombreDestino)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            // Mover n-1 discos a la torre auxiliar
            Hanoi(n - 1, origen, destino, auxiliar,
                  nombreOrigen, nombreDestino, nombreAuxiliar);

            // Mover el disco mayor al destino
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            MostrarTorres(origen, auxiliar, destino);

            // Mover los n-1 discos al destino final
            Hanoi(n - 1, auxiliar, origen, destino,
                  nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }

    // Método principal
    static void Main(string[] args)
    {
        int nDiscos = 3;

        // Inicialización de las torres (pilas)
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Cargar los discos en la torre A
        for (int i = nDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("Estado inicial de las torres:");
        MostrarTorres(torreA, torreB, torreC);

        // Resolver el problema
        Hanoi(nDiscos, torreA, torreB, torreC, 'A', 'B', 'C');

        Console.WriteLine("Problema resuelto correctamente ✔");
    }
}
