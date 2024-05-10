﻿const double Continentais = 10;
const double Marinhas = 15;

const decimal MultaBase = 1000;
const decimal MultaExcesso = 20;

Console.WriteLine("--- Pesca Amadora ---\n");

Console.Write("Peso (KG)...: ");
double pesoPescado = Convert.ToDouble(Console.ReadLine());

Console.Write("Águas [c]ontinentais ou [m]arinhas? ");
string localPesca = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.WriteLine();

if (localPesca != "C" && localPesca != "M")
{
    Console.WriteLine("Local não reconhecido.");
    return;
}

if (localPesca == "C" && pesoPescado <= Continentais ||
    localPesca == "M" && pesoPescado <= Marinhas)
{
    Console.WriteLine("Pescaria nos limites permitidos.");
    return;
}

double pesoPermitido = localPesca == "C" ? Continentais : Marinhas;
double pesoExcesso = pesoPescado - pesoPermitido;
decimal multa = MultaBase + MultaExcesso * Convert.ToDecimal(pesoExcesso);

Console.WriteLine($"Pescaria ultrapassa os limites legais em {pesoExcesso}kg.\nSujeito a multa de {multa:C}.");