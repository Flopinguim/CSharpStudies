using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string[] lines  = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                    Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
