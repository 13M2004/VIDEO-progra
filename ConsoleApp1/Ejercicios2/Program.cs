//EJERCICIO 2
class Program2
{
    static void Main(string[] args)
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("EJERCICIO #2");
        Console.ResetColor();
        Console.WriteLine();

        int numero1, numero2;
        char operador;

        Console.WriteLine("Ingrese el primer número entero:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el operador matemático (+, -, *, /):");
        operador = char.Parse(Console.ReadLine());

        int resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                resultado = numero1 / numero2;
                break;
            default:
                Console.WriteLine("Operador inválido");
                break;
        }

        Console.WriteLine("El resultado es: " + resultado);
    }
}