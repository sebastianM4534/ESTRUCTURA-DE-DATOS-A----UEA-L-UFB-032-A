using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main(string[] args)
    {
        //Universo: 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3️75 vacunados con AstraZeneca
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

    
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

    
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

    
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // Resultados
        Console.WriteLine("=== RESULTADOS ===\n");

        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);

        Console.WriteLine("\nEjemplo de ciudadanos con ambas dosis:");
        foreach (var c in ambasDosis.Take(10))
        {
            Console.WriteLine(c);
        }
    }
}