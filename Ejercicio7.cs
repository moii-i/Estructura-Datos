using System;

class Program
{
    static void Main()
    {
        // Declaramos tres arreglos para almacenar los números, sus cuadrados y sus cubos
        int[] numeros = new int[20];
        int[] cuadrados = new int[20];
        int[] cubos = new int[20];

        // Capturamos los 20 números
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            // Calculamos el cuadrado y el cubo del número
            cuadrados[i] = numeros[i] * numeros[i];
            cubos[i] = numeros[i] * numeros[i] * numeros[i];
        }

        // Mostramos los resultados
        Console.WriteLine("Números\tCuadrados\tCubos");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{numeros[i]}\t{cuadrados[i]}\t{cubos[i]}");
        }
    }
}