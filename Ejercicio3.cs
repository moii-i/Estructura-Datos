using System;

class Program
{
    static void Main()
    {
        double[,] calificaciones = new double[5, 4];

        // Captura de calificaciones
        for (int i = 0; i < 5; i++)
        {
            double suma = 0;
            Console.WriteLine($"\nIngrese las calificaciones del Alumno {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Parcial {j + 1}: ");
                calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                suma += calificaciones[i, j];
            }
            // Calcular el promedio
            calificaciones[i, 3] = suma / 3;
        }

        // Mostrar la matriz de calificaciones y promedios
        Console.WriteLine("\nCalificaciones y Promedios:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Alumno {i + 1}: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{calificaciones[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
