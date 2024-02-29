// Ejercicio 1

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                     Ejercicios Prácticos");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------------------------");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("EJERCICIO #1");
        Console.ResetColor();
        Console.WriteLine();

        int numero;

        Console.WriteLine("Ingrese un número entero positivo:");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Calcular el factorial del número.");
            Console.WriteLine("2. Calcular la raíz cuadrada del número.");
            Console.WriteLine("3. Salir del programa.");

            Console.Write("Elija una opción: ");
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número entero válido.");
            }
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    int factorial = CalcularFactorial(numero);
                    Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
                    break;
                case 2:
                    double raizCuadrada = CalcularRaizCuadrada(numero);
                    Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, raizCuadrada);
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego Ingeniero!");
                    return;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

    static int CalcularFactorial(int numero)
    {
        int factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static double CalcularRaizCuadrada(int numero)
    {
        return Math.Sqrt(numero);
    }
}

