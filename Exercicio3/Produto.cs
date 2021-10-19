using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Produto
    {

        public string Nome { get; set; }

        public double Preco { get; set; }

        public override string ToString()
        {
            return $"Nome {Nome}, Preço: {Preco}";
        }

    }
}




