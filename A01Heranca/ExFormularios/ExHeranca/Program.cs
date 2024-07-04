using ExHeranca;
using System;

class Program
{
    public static void Main(string[] args)
    {
        FormularioImovel imovel = new FormularioImovel("Henrique", "45302649802", "RRAS", 50.00);
        imovel.ExibirFormulario();

        Console.WriteLine();

        FormularioVeiculo veiculo = new FormularioVeiculo("Henrique", "45302649802", "PCA2954", "Honda Civic");
        veiculo.ExibirFormulario();
    }
}