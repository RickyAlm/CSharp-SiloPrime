using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PooPolimorfismo
{
    public abstract class Formulario
    {
        public string Nome {  get; set; }
        public string Descricao { get; set; }

        public Formulario(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public abstract void Exibir();
        }
    }


