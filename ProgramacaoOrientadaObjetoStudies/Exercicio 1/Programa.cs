using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace Vetores
{
    class Programa
    {
        static void Main(string[] args)
        {
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[quantidadeProdutos];

            for (int x = 0; x < quantidadeProdutos; x++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[x] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0d;
            for (int x = 0; x < quantidadeProdutos; x++)
            {
                soma += produtos[x].Preco;
            }

            double media = soma / quantidadeProdutos;
            Console.WriteLine("Preço Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
