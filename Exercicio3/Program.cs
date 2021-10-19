using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do Produto: ");
            string recebeNomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do Produto: ");
            double recebePrecoProduto = double.Parse(Console.ReadLine());

            int IndiceLista = 0;

            Produto[] VetorProduto = new Produto[100];
            
            VetorProduto[IndiceLista] = new Produto { Nome = recebeNomeProduto, Preco = recebePrecoProduto };

            Console.WriteLine();
            Console.WriteLine("Você acabou de adicionar um produto !");

            MenuPrincipalClasse menuprincipal;
            menuprincipal = new MenuPrincipalClasse();

            Console.WriteLine();
            OpcaoMenu EscolheMenu = menuprincipal.MenuPrincipal();

            do
            {
                switch (EscolheMenu)
                {

                    case OpcaoMenu.AdicionarProduto:


                        IndiceLista++;
                        Console.WriteLine();

                        Console.Write("Digite o nome do Produto: ");
                        recebeNomeProduto = Console.ReadLine();

                        Console.Write("Digite o preço do Produto: ");
                        recebePrecoProduto = double.Parse(Console.ReadLine());

                        VetorProduto[IndiceLista] = new Produto { Nome = recebeNomeProduto, Preco = recebePrecoProduto };

                        Console.WriteLine();
                        Console.WriteLine("Você acabou de adicionar um produto");

                        Console.WriteLine();
                        EscolheMenu = menuprincipal.MenuPrincipal();
                        break;

                    case OpcaoMenu.VerLista:

                        Console.WriteLine();
                        int IndiceVetorial = IndiceLista + 1;

                        for (int i = 0; i < IndiceVetorial; i++)
                        {
                            Console.WriteLine($"Numero: {i + 1}, { VetorProduto[i]}");
                        }

                        Console.WriteLine();
                        EscolheMenu = menuprincipal.MenuPrincipal();
                        break;

                    case OpcaoMenu.MediaValoresProdutos:

                        Console.WriteLine();
                        IndiceVetorial = IndiceLista + 1;
                        double ValorTotalProduto = 0;
                        double MediaTotalProduto = 0;

                        for (int i = 0; i < IndiceVetorial; i++)
                        {
                            ValorTotalProduto += VetorProduto[i].Preco;
                        }

                        MediaTotalProduto = ValorTotalProduto / IndiceVetorial;

                        Console.WriteLine($"Média de todos os produtos somados: {MediaTotalProduto}");

                        Console.WriteLine();
                        EscolheMenu = menuprincipal.MenuPrincipal();
                        break;

                    case OpcaoMenu.Sair:

                        Console.WriteLine("Muito Obrigado por usar nossos sistemas");
                        break;

                    default:

                        Console.WriteLine();
                        EscolheMenu = menuprincipal.MenuPrincipal();
                        break;
                }

            } while (EscolheMenu != OpcaoMenu.Sair);

                     
            
        }
    }
}
