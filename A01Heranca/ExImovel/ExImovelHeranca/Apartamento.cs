using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExImovelHeranca
{
    public class Apartamento: Imovel
    {
        private int _bloco;
        private int _andar;

        public Apartamento(string endereco, int nQuartos, float metragemQuinta, int bloco, int andar): base(endereco, nQuartos, metragemQuinta)
        {
            if (bloco < 0) Console.WriteLine("O bloco deve ser maior que 0.");
            else _bloco = bloco;

            if (andar < 0) Console.WriteLine("O andar deve ser maior que 0.");
            else _andar = andar;
        }

        public void ExibirImovel()
        {
            Console.WriteLine(
                "=== Dados do Apartamento ===\n" +
                $"Endereço: {this.endereco}\n" +
                $"N° Quartos: {this.nQuartos}\n" +
                $"Bloco: {this._bloco}\n" +
                $"Andar: {this._andar}"
            );
        }
    }
}
