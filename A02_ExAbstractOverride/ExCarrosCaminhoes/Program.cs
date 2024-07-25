using ExCarrosCaminhoes;
using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>
        {
            new Carro("Toyota", "Corolla", "2020"),
            new Carro("Honda", "Civic", "2018"),
            new Caminhao("Volvo", "FH16", "2019"),
            new Caminhao("Scania", "R450", "2021")
        };
        
        foreach (var veiculo in veiculos)
        {
            ExibirVeiculos(veiculo);
        }
    }

    static void ExibirVeiculos(Veiculo veiculo)
    {
        veiculo.Exibir();
    }
}