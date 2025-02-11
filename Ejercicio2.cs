using System;

class Program
{
    static void Main()
    {
        double[] grupoA = new double[5];
        double[] grupoB = new double[5];
        double[] mejoresPromedios = new double[5];

        // Captura de promedios del grupo A
        Console.WriteLine("Ingrese los promedios del Grupo A:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Alumno {i + 1}: ");
            grupoA[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Captura de promedios del grupo B
        Console.WriteLine("\nIngrese los promedios del Grupo B:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Alumno {i + 1}: ");
            grupoB[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Determinar el mejor promedio por posición
        for (int i = 0; i < 5; i++)
        {
            mejoresPromedios[i] = Math.Max(grupoA[i], grupoB[i]);
        }

        // Mostrar los mejores promedios
        Console.WriteLine("\nPromedios más altos de cada posición:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Alumno {i + 1}: {mejoresPromedios[i]}");
        }
    }
}
