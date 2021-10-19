using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class MenuPrincipalClasse
    {
        public OpcaoMenu MenuPrincipal()
        {
             
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("1 - Adicionar mais um produto");
            Console.WriteLine("2 - Ver a lista completa");
            Console.WriteLine("3 - Média dos valores de todos os Produtos");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
                        
            return  (OpcaoMenu)int.Parse(Console.ReadLine());
        }
    }
}
