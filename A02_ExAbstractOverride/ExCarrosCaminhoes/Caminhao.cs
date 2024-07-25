using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCarrosCaminhoes
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string marca, string modelo, string ano) : base(marca, modelo, ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public override void Exibir()
        {
            Console.WriteLine(
                $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}"
            );
        }
    }
}
