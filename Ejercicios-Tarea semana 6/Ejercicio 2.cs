/*rear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente. Una
Crear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente. Una
vez creada la lista, 
vez creada la lista, se deben eliminar los nodos que estén fuera 
se deben eliminar los nodos que estén fuera de un rango de valores 
de un rango de valores leídos
desde el teclado.*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> lista = new LinkedList<int>();
        Random random = new Random();

        // Crear lista enlazada con 50 números aleatorios
        for (int i = 0; i < 50; i++)
        {
            lista.AddLast(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        MostrarLista(lista);

        // Leer rango desde teclado
        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        LinkedListNode<int> nodo = lista.First;

        while (nodo != null)
        {
            LinkedListNode<int> siguiente = nodo.Next;

            if (nodo.Value < min || nodo.Value > max)
            {
                lista.Remove(nodo);
            }

            nodo = siguiente;
        }

        Console.WriteLine("\nLista después de eliminar valores fuera del rango:");
        MostrarLista(lista);
    }

    // Método para mostrar la lista enlazada
    static void MostrarLista(LinkedList<int> lista)
    {
        foreach (int valor in lista)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}
