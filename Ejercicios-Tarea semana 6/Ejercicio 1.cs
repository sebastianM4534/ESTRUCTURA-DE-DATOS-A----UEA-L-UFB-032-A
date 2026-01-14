/*Implementar el método de búsqueda en la clase lista, el 
Implementar el método de búsqueda en la clase lista, el cual debe retornar el número de
veces que se encuentra el dato dentro 
cual debe retornar el número de
veces que se encuentra el dato dentro de la lista. En caso 
de la lista. En caso de no encontrarse, el método debe
de no encontrarse, el método debe
mostrar un mensaje indicando que el dato 
mostrar un mensaje indicando que el dato no fue encontrado. El parámetro 
no fue encontrado. El parámetro de entrada del
método es el valor que 
método es el valor que se desea buscar. */
using System;
using System.Collections.Generic;

class Lista
{
    private List<int> datos = new List<int>();

    // Método para agregar elementos a la lista
    public void Agregar(int valor)
    {
        datos.Add(valor);
    }

    // Método de búsqueda
    public int Buscar(int valorBuscado)
    {
        int contador = 0;

        // Recorre la lista contando las coincidencias
        foreach (int dato in datos)
        {
            if (dato == valorBuscado)
            {
                contador++;
            }
        }

        // Si no se encontró el valor
        if (contador == 0)
        {
            Console.WriteLine("El dato no fue encontrado en la lista.");
        }

        return contador;
    }
}

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        // Agregar valores a la lista
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(10);
        lista.Agregar(30);
        lista.Agregar(10);

        Console.Write("Ingrese el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        int resultado = lista.Buscar(valor);
        Console.WriteLine($"El valor {valor} se encontró {resultado} veces.");
    }
}
