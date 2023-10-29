using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace Vetores.Exercicio_de_Fixação
{
    class Projeto
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];
            Console.WriteLine("Escreva a quantidade de estudantes que vão alugar quartos");
            int qtdeEstudantes = int.Parse(Console.ReadLine());

            for (int x = 1; qtdeEstudantes >= x; x++)
            {
                Console.WriteLine($"Rent #{x}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                quartos[room] = new Quarto(name, email);
            }

            Console.WriteLine("Busy Room:");
            for (int x = 0; x < 10; x++)
            {
                if (quartos[x] is not null)
                      Console.WriteLine(x + ": " + quartos[x]);
            }

        }

    }
}
