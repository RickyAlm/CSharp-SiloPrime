using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca
{
    internal class FormularioImovel: Formulario
    {
        private string Endereco;
        private double Valor;

        public FormularioImovel(string nome, string cpf, string endereco, double valor): base(nome, cpf)
        {
            if (string.IsNullOrEmpty(endereco)) Console.WriteLine("O e-mail é OBRIGATÓRIO.");
            else Endereco = endereco;

            if (valor < 0) Console.WriteLine("O valor deve ser maior que 0.");
            else Valor = valor;
        }

        public void ExibirFormulario()
        {
            Console.WriteLine(
                "=== Formulário de Imóvel ===\n" +
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"Endereço: {Endereco}\n" +
                $"Valor: {Valor}"
            );
        }
    }
}
