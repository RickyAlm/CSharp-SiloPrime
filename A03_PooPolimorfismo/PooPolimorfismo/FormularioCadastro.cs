using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public class FormularioCadastro: Formulario
    {
        public string CPF { get; set; }
        public string DescricaoCadastro { get; set; }

        public FormularioCadastro(string nome, string descricao, string cpf, string descricaoCadastro): base(nome, descricao)
        {
            CPF = cpf;
            DescricaoCadastro = descricaoCadastro;
        }

        public override void Exibir()
        {
            Console.WriteLine(
                "Formulário de Reclamação:\n" +
                $"Nome: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"CPF: {CPF}\n" +
                $"Descrição do cadastro: {DescricaoCadastro}"
            );
        }


    }
}
