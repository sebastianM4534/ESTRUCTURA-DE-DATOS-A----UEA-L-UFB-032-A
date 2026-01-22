using System;
using System.Collections.Generic;

class VerificarParentesis
{
    // Método que verifica si la expresión está balanceada
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            // Si es un símbolo de apertura, se apila
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter);
            }
            // Si es un símbolo de cierre
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                // Si la pila está vacía, no hay símbolo de apertura correspondiente
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                // Verificar correspondencia entre apertura y cierre
                if (!EsParCorrespondiente(ultimo, caracter))
                    return false;
            }
        }

        // Si la pila queda vacía, la expresión está balanceada
        return pila.Count == 0;
    }

    // Método auxiliar para verificar si los símbolos coinciden
    static bool EsParCorrespondiente(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    // Método principal
    static void Main(string[] args)
    {
        // Expresión de ejemplo
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        Console.WriteLine("Expresión ingresada:");
        Console.WriteLine(expresion);
        Console.WriteLine();

        // Verificar balanceo
        if (EstaBalanceada(expresion))
        {
            Console.WriteLine("Resultado: Fórmula balanceada ✔");
        }
        else
        {
            Console.WriteLine("Resultado: Fórmula NO balanceada ❌");
        }
    }
}
