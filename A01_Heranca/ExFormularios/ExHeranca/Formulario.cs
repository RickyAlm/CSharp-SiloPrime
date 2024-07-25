using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca
{
    internal class Formulario
    {
        protected string Nome;
        protected string Cpf;

        public Formulario(string nome, string cpf)
        {
            if (String.IsNullOrWhiteSpace(nome)) Console.WriteLine("O nome é OBRIGATÓRIO.");
            else Nome = nome;

            if (String.IsNullOrWhiteSpace(cpf) || cpf.Length > 11) Console.WriteLine("O CPF está INVÁLIDO.");
            else Cpf = cpf;
        }

        public void ExibirFormulario()
        {
            Console.WriteLine(
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}"
            );
        }
    }
}
