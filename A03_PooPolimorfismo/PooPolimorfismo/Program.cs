using PooPolimorfismo;
using System;

class Program
{
    public static void Main(string[] args)
    {
        FormularioReclamacao reclamacao = new FormularioReclamacao("Henrique", "Descrição teste", "Reclamação teste");
        FormularioCadastro cadastro = new FormularioCadastro("Henrique", "Descrição teste", "45302649802", "Descrição cadastro teste");

        ExibirFormulario(reclamacao);
        ExibirFormulario(cadastro);
    }

    static void ExibirFormulario(Formulario formulario)
    {
        formulario.Exibir();
        Console.WriteLine();
    }
}