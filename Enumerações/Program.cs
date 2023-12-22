using Enumerações.Entities.Enums;
using System.Globalization;

namespace Enumerações
{
    public class Program
    {
        static void Main(string[] args)
        {
            string departament;
            string name;
            string level;
            WorkerLevel workerLevel;
            double basesalary;
            int numbersContract;

            Console.WriteLine("Enter departament's name:");
            departament = Console.ReadLine();
            Console.WriteLine("Enter Worker Data:");
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("BaseSalary:");
            basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("How many contracts to this worker?");
            numbersContract = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while ()
            {

            }
        }
    }
}
