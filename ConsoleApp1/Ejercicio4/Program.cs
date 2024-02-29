// Ejercicio 4

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("EJERCICIO #3");
        Console.ResetColor();
        Console.WriteLine();

        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);
        int intentos = 0;
        int numeroUsuario = 0;

        Console.WriteLine("Adivina el número secreto entre 1 y 100.");

        while (numeroUsuario != numeroSecreto)
        {
            Console.Write("Introduce un número: ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (numeroUsuario > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
            else
            {
                Console.WriteLine("¡Felicidades! Adivinaste el número secreto en {0} intentos.", intentos);
            }
        }
    }
}