using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Arquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Projetos\Flopinguim\csharp-studies\Arquivos\Hello.txt";
            string targetPath = @"C:\Projetos\Flopinguim\csharp-studies\Arquivos\Hello2.txt";

            try
            {
                Console.Write("Faça: ");
                int faca = int.Parse(Console.ReadLine());

                if (faca.Equals(1))
                {
                    string[] lines = File.ReadAllLines(sourcePath);

                    foreach (string line in lines)
                        Console.WriteLine(line);
                }
                else if (faca.Equals(2))
                {
                    Console.WriteLine("Digite o caminho da pasta que deseja limpar:");
                    string pasta = Console.ReadLine();

                    if (Directory.Exists(pasta))
                    {
                        string[] arquivos = Directory.GetFiles(pasta);

                        foreach (string arquivo in arquivos)
                        {
                            File.Delete(arquivo);
                            Console.WriteLine($"Arquivo '{arquivo}' deletado com sucesso.");
                        }

                        Console.WriteLine("Todos os arquivos foram deletados.");
                    }
                    else
                        Console.WriteLine("O caminho da pasta não é válido ou não existe.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
