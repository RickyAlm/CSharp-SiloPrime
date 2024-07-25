using ExImovelHeranca;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Casa casa = new Casa("RRAS", 4, 20, 5);
        casa.ExibirImovel();

        Console.WriteLine();

        Apartamento ap = new Apartamento("RRAS", 4, 20, 1, 2);
        ap.ExibirImovel();
    }
}