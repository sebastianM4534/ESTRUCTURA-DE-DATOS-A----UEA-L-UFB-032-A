using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class BST
{
    public Nodo Raiz;

    // Insertar
    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = InsertarRec(raiz.Derecho, valor);

        return raiz;
    }

    // Buscar
    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (raiz.Valor == valor)
            return true;

        if (valor < raiz.Valor)
            return BuscarRec(raiz.Izquierdo, valor);

        return BuscarRec(raiz.Derecho, valor);
    }

    // Eliminar
    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo raiz, int valor)
    {
        if (raiz == null) return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = EliminarRec(raiz.Derecho, valor);
        else
        {
            if (raiz.Izquierdo == null)
                return raiz.Derecho;
            else if (raiz.Derecho == null)
                return raiz.Izquierdo;

            raiz.Valor = Minimo(raiz.Derecho);
            raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
        }
        return raiz;
    }

    // Recorridos
    public void Inorden()
    {
        InordenRec(Raiz);
        Console.WriteLine();
    }

    private void InordenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            InordenRec(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            InordenRec(raiz.Derecho);
        }
    }

    public void Preorden()
    {
        PreordenRec(Raiz);
        Console.WriteLine();
    }

    private void PreordenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            PreordenRec(raiz.Izquierdo);
            PreordenRec(raiz.Derecho);
        }
    }

    public void Postorden()
    {
        PostordenRec(Raiz);
        Console.WriteLine();
    }

    private void PostordenRec(Nodo raiz)
    {
        if (raiz != null)
        {
            PostordenRec(raiz.Izquierdo);
            PostordenRec(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // Minimo
    public int Minimo(Nodo raiz)
    {
        while (raiz.Izquierdo != null)
            raiz = raiz.Izquierdo;
        return raiz.Valor;
    }

    public int Minimo()
    {
        return Minimo(Raiz);
    }

    // Maximo
    public int Maximo()
    {
        Nodo actual = Raiz;
        while (actual.Derecho != null)
            actual = actual.Derecho;
        return actual.Valor;
    }

    // Altura
    public int Altura()
    {
        return AlturaRec(Raiz);
    }

    private int AlturaRec(Nodo raiz)
    {
        if (raiz == null)
            return -1;

        int izq = AlturaRec(raiz.Izquierdo);
        int der = AlturaRec(raiz.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // Limpiar
    public void Limpiar()
    {
        Raiz = null;
    }
}

class Program
{
    static void Main()
    {
        BST arbol = new BST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n===== ÁRBOL BINARIO DE BÚSQUEDA =====");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorrido Inorden");
            Console.WriteLine("5. Recorrido Preorden");
            Console.WriteLine("6. Recorrido Postorden");
            Console.WriteLine("7. Valor mínimo");
            Console.WriteLine("8. Valor máximo");
            Console.WriteLine("9. Altura del árbol");
            Console.WriteLine("10. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valor);
                    break;

                case 4:
                    Console.Write("Inorden: ");
                    arbol.Inorden();
                    break;

                case 5:
                    Console.Write("Preorden: ");
                    arbol.Preorden();
                    break;

                case 6:
                    Console.Write("Postorden: ");
                    arbol.Postorden();
                    break;

                case 7:
                    Console.WriteLine("Mínimo: " + arbol.Minimo());
                    break;

                case 8:
                    Console.WriteLine("Máximo: " + arbol.Maximo());
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura());
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol eliminado");
                    break;
            }

        } while (opcion != 0);
    }
}