using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public class FormularioReclamacao: Formulario
    {
        public string DetalhesReclamacao {  get; set; }

        public FormularioReclamacao(string nome, string descricao, string detalhesReclamacao): base(nome, descricao)
        {
            DetalhesReclamacao = detalhesReclamacao;
        }

        public override void Exibir()
        {
            Console.WriteLine(
                "Formulário de Reclamação:\n" +
                $"Nome: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"Detalhes da Reclamação: {DetalhesReclamacao}"
            );
        }
    }
}
