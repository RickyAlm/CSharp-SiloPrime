using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExImovelHeranca
{
    public class Casa: Imovel
    {
        protected float _metragemQuintal;

        public Casa(string pEndereco, int nQuartos, float metragem, float metragemQuintal): base(pEndereco, nQuartos, metragem)
        {
            if (metragemQuintal < 0) Console.WriteLine("A metragem do quintal deve ser maior que 0.");
            else this._metragemQuintal = metragemQuintal;
        }

        public void ExibirImovel()
        {
            Console.WriteLine(
                "=== Dados da Casa ===\n" +
                $"Endereço: {this.endereco}\n" +
                $"N° Quartos: {this.nQuartos}\n" +
                $"Metragem: {this.metragem}\n" +
                $"Metragem Quintal: {this._metragemQuintal}"
            );
        }
    }
}
