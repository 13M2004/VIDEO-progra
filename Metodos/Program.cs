//Metodos

using System;


Console.WriteLine("------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                          MÉTODOS");
Console.ResetColor();
Console.WriteLine("------------------------------------------------------------");

Thread.Sleep(1500);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("LENGTH");
Console.ResetColor();

string cadena = "Ingeniero en Proceso";
int longitud = cadena.Length;

Console.WriteLine("Ingeniero en Proceso");
Console.WriteLine("La longitud de la cadena es: " + longitud);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("TOUPPER");
Console.ResetColor();

string caden = "divide y venceras";
string cadenMayusculas = caden.ToUpper();

Console.WriteLine("divide y venceras");
Console.WriteLine(cadenMayusculas);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("TOLOWER");
Console.ResetColor();

string cdn = "DIVIDE Y VENCERAS";
string cadenMinusculas = cdn.ToLower();

Console.WriteLine("DIVIDE Y VENCERAS");
Console.WriteLine(cadenMinusculas);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("INDEX0F()");
Console.ResetColor();

string cadenN = "Hola Alexander";
int indice = cadenN.IndexOf("Alexander");

Console.WriteLine("El indice de la primera aparicion de 'Alexander' es: " + indice);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("LASTLNDEXOF()");
Console.ResetColor();

string caDena = "Tercer Ciclo";
int indiCe = caDena.LastIndexOf("o");

Console.WriteLine("Tercer Ciclo");
Console.WriteLine("El indice de la última aparición de 'o' es:" + indiCe);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("SUBSTRING");
Console.ResetColor();

string Cadena = "Hola Mundo";
string subcdena = Cadena.Substring(5, 5);

Console.WriteLine("Hola Mundo");
Console.WriteLine(subcdena);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("REPLACE");
Console.ResetColor();

string cadenaR = "Primer parcial";
string nuevaCadena = cadenaR.Replace("Primer", "mundo");

Console.WriteLine(nuevaCadena);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("TRIM()");
Console.ResetColor();

string trmi = "   Programación I!  ";
string Trim = trmi.Trim();

Console.WriteLine(Trim);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("STARS WITCH()");
Console.ResetColor();

string str = "Hello mucha";
bool starsHello = str.StartsWith("Hello");
bool starsHola = str.StartsWith("Hola");

Console.WriteLine(starsHello);
Console.WriteLine(starsHola);

Console.WriteLine("------------------------------------------------------------");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ENDS WHITH");
Console.ResetColor();

string StrM = "Hello; Chapin";
bool endswitH = StrM.EndsWith("Hello");
bool endswitC = StrM.EndsWith("Chapin");

Console.WriteLine(endswitH);
Console.WriteLine(endswitC);







