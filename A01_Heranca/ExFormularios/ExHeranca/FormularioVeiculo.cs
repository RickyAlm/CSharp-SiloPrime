using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca
{
    internal class FormularioVeiculo : Formulario
    {
        private string Placa;
        private string Modelo;

        public FormularioVeiculo(string nome, string cpf, string placa, string modelo) : base(nome, cpf)
        {
            if (String.IsNullOrEmpty(placa)) Console.WriteLine("A placa é OBRIGATÓRIO.");
            else Placa = placa;

            if (String.IsNullOrEmpty(modelo)) Console.WriteLine("O modelo é OBRIGATÓRIO.");
            else Modelo = modelo;
        }

        public void ExibirFormulario()
        {
            Console.WriteLine(
                "=== Formulário de Veículo ===\n" +
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"Placa: {Placa}\n" +
                $"Modelo: {Modelo}"
            );
        }
    }
}
