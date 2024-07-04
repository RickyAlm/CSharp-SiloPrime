using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExImovelHeranca
{
    public abstract class Imovel
    {
        protected string endereco;
        protected int nQuartos;
        protected float metragem;

        public Imovel(string pEndereco, int pNQuartos, float pMetragem)
        {
            if (String.IsNullOrWhiteSpace(pEndereco)) Console.WriteLine("Endereço é OBRIGATÓRIO.");
            else this.endereco = pEndereco;

            if (nQuartos < 0) Console.WriteLine("O número de quartos deve ser maior que 0.");
            else this.nQuartos = pNQuartos;

            if (metragem < 0) Console.WriteLine("A metragem deve ser maior que 0");
            else this.metragem = pMetragem;
        }
    }
}
