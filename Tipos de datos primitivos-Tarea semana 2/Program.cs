using System;

// Esta clase representa un círculo
public class Circulo
{
    // Guardamos el radio del círculo
    private double radio;

    // Constructor: sirve para darle un valor al radio
    public Circulo(double r)
    {
        radio = r;
    }

    // Este método calcula el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;  
    }

    // Este método calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;  // fórmula del perímetro
    }
}

// Esta clase representa un rectángulo
public class Rectangulo
{
    
    private double largo;
    private double ancho;

    // Constructor: sirve para darle valores al rectángulo
    public Rectangulo(double l, double a)
    {
        largo = l;
        ancho = a;
    }

    // Calcula el área del rectángulo
    public double CalcularArea()
    {
        return largo * ancho;
    }

    // Calcula el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}

// Programa principal para probar las clases
public class Program
{
    public static void Main()
    {
        // Creamos un círculo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Creamos un rectángulo de 10 x 4
        Rectangulo r = new Rectangulo(10, 4);
        Console.WriteLine("\nÁrea del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
