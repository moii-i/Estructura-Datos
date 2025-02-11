using System;

class Program
{
    static void Main()
    {
        double[,] promedios = new double[10, 3];

        // Captura de promedios del grupo A
        Console.WriteLine("Ingrese los promedios del Grupo A:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Alumno {i + 1}: ");
            promedios[i, 0] = Convert.ToDouble(Console.ReadLine());
        }

        // Captura de promedios del grupo B
        Console.WriteLine("\nIngrese los promedios del Grupo B:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Alumno {i + 1}: ");
            promedios[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        // Determinar el mayor promedio entre los dos grupos
        for (int i = 0; i < 10; i++)
        {
            promedios[i, 2] = Math.Max(promedios[i, 0], promedios[i, 1]);
        }

        // Mostrar los resultados
        Console.WriteLine("\nPromedios:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Alumno {i + 1}: Grupo A: {promedios[i, 0]}, Grupo B: {promedios[i, 1]}, Mayor: {promedios[i, 2]}");
        }
    }
}
