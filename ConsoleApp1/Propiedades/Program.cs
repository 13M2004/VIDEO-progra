//Propiedades

using System;
using System.Collections.Generic;
using System.Threading;



Console.WriteLine("------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                          PROPIEDADES");
Console.ResetColor();
Console.WriteLine("------------------------------------------------------------");

Thread.Sleep(1500);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("LENGTH");
Console.ResetColor();

string cadena = "Dividide y Venceras";
int longitud = cadena.Length;

Console.WriteLine("La longitud de la cadena es: " + longitud);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("IS READ ONLY");
Console.ResetColor();

List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine("La lista es de solo lectura: " + numeros.IsReadOnly);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("CHARS");
Console.ResetColor();

string Cadena = "Progra I";

char primerCaracter = Cadena[0] ;
char ultimoCaracter = cadena[cadena.Length - 1];

Console.WriteLine(primerCaracter);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" EQUALS(STRING)");
Console.ResetColor();

string cadena1 = "Hola";
string cadena2 = "Hola";

bool sonIguales = cadena1.Equals(cadena2);

Console.WriteLine("Las cadenas son iguales: " + sonIguales);