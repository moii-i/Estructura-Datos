using System;

class Program
{
    static void Main()
    {
        // Declaramos un arreglo para almacenar 20 números
        int[] numeros = new int[20];
        int pares = 0, impares = 0;

        // Capturamos los 20 números
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            // Verificamos si el número es par o impar
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        // Mostramos la cantidad de números pares e impares
        Console.WriteLine($"Números pares: {pares}");
        Console.WriteLine($"Números impares: {impares}");
    }
}