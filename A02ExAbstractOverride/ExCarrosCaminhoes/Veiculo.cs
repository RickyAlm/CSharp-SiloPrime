using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCarrosCaminhoes
{
    public abstract class Veiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Ano {  get; set; }

        public Veiculo(string marca, string modelo, string ano)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Exibir();
    }
}
