// DIFERENCIA 

using System;

Console.WriteLine("-------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Diferencia entre cadenas literales y variables de tipo string");
Console.ResetColor();
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine();
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("CADENAS LITERALES");
Console.ResetColor();

string nombre1 = "Nayeli Urrutia";
Console.WriteLine(nombre1);

Console.WriteLine("-------------------------------------------------------------");

Thread.Sleep(1500);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("VARIABLES DE TIPO STRING");
Console.ResetColor();

string nombre;
nombre = "Manuel Monzón";

Console.WriteLine(nombre);
