using System;
using System.Globalization;
namespace Produto.Entities
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto #" + i + "data: ");
                Console.Write("Comum,usado ou importado (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resp == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (resp == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.Write("Taxa alfandegaria: ");
                    double taxaAlfandegaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PREÇO TAGS:");
            foreach(Produto prod in lista)
            {
                Console.WriteLine(prod.PrecoTag());
            }
        }
    }
}        