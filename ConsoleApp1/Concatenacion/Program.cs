//Concatenación

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


Console.WriteLine("------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                  Concatenación de cadenas");
Console.ResetColor();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("OPERADOR +");
Console.ResetColor();

string Nombre = "Melissa";
string Apellido = "Urrutia";
string nomCom = Nombre + " " + Apellido;

Console.WriteLine("Nombre completo: " + nomCom);

Console.WriteLine("-------------------------------------------------------------");

Thread.Sleep(1500);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRING.CONCAT()");
Console.ResetColor();

string ciclO = "Tercer";
string numciclo = "Ciclo";
string ciCompleto1 = string.Concat(ciclO, " ", numciclo);
string ciCompleto2 = string.Concat("Hola, ", ciclO, "!");

Console.WriteLine("Secuencia de Carrera (Orden y Tipo): " + ciCompleto1);
Console.WriteLine("Secuencia de Carrera (Saludo con Orden): " + ciCompleto2);

Console.WriteLine("-------------------------------------------------------------");

Thread.Sleep(1500);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STRING.FORMAT()");
Console.ResetColor();

string nombre = "Manuel";
int edad = 20;
string ciudad = "Asunción Mita";

string saludoPerso = string.Format("Hola, {0}! Tienes {1} años y vives en {2}", nombre, edad, ciudad);

Console.WriteLine(saludoPerso);