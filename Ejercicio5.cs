using System;

class Program
{
    static void Main()
    {
        // Declaramos un arreglo para almacenar las ventas de 100 clientes
        double[] ventas = new double[100];
        double totalIngresos = 0;

        // Simulamos la captura de las ventas de 100 clientes
        for (int i = 0; i < 100; i++)
        {
            Console.Write($"Ingrese la venta del cliente {i + 1}: ");
            ventas[i] = Convert.ToDouble(Console.ReadLine());
            totalIngresos += ventas[i]; // Sumamos cada venta al total de ingresos
        }

        // Mostramos el total de ingresos
        Console.WriteLine($"El total de ingresos es: {totalIngresos}");
    }
}