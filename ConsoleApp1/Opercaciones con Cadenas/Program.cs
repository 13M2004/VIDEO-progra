// Operaciones con Cadenas

using System;

Console.WriteLine("------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                     OPERACIONES CON CADENAS");
Console.ResetColor();
Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(2000);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRING COMPARE");
Console.ResetColor();

string cadena1 = "Hola";
string cadena2 = "Hola";

int resultado = String.Compare(cadena1, cadena2);

if (resultado == 0)
{
    Console.WriteLine("Las cadenas son iguales");
}
else if (resultado < 0)
{
    Console.WriteLine("La cadena1 es menor que la cadena2");
}
else
{
    Console.WriteLine("La cadena1 es mayor que la cadena2");
}

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRIN.COMPARE ORDINAL");
Console.ResetColor();

string str1 = "Alexander";
string str2 = "alexander";

bool ordinalResult = str1.Equals(str2, StringComparison.Ordinal);
bool ordinalIgnoreCaseResult = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);

Console.WriteLine($"Ordinal comparison: {ordinalResult}");
Console.WriteLine($"OrdinalIgnoreCase comparison: {ordinalIgnoreCaseResult}");

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRIN.COMPARE TO");
Console.ResetColor();

string Rt1 = "Melissa";
string Rt2 = "Alexander";

int result = Rt1.CompareTo(Rt2);

if (result < 0)
{
    Console.WriteLine("Rt1 es menor que Rt2");
}
else if (result > 0)
{
    Console.WriteLine("Rt1 es mayor que Rt2");
}
else
{
    Console.WriteLine("Rt1 es igual a Rt2");
}

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRIN.STARSWITCH");
Console.ResetColor();

string Strr = "Naye, Manu";

bool staWit = Strr.StartsWith("Naye");
bool starManu = Strr.StartsWith("Manu");

Console.WriteLine($"La cadena comienza con 'Naye': {staWit}");
Console.WriteLine($"La cadena comienza con 'MANU': {starManu}");