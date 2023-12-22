using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Enumerações
{
    public class Program
    {
        static void Main(string[] args)
        {           
            string name;
            string level;
            WorkerLevel workerLevel;
            double baseSalary;
            int numbersContract;
            DateTime incomeDate;

            Console.WriteLine("Enter departament's name: ");
            Departament departament = new Departament()
            {
                Name = Console.ReadLine()
            };

            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());
            Console.Write("BaseSalary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("How many contracts to this worker?");
            numbersContract = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker()
            {
                BaseSalary = baseSalary,
                departament = departament,
                Level = workerLevel,
                Name = name
            };
           

            for(int i = 0; i < numbersContract; i++)
            {
                DateTime date;
                double valuehour;
                int hours;

                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                HourContract hourContract = new HourContract()
                {
                    Date = date,
                    Hours = hours,
                    ValuePerHour = valuehour
                };

                worker.addContract(hourContract);
            }
           
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            incomeDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {departament.Name}");
            Console.WriteLine($"Income for {incomeDate.ToString("MM/yyyy")}: {worker.income(incomeDate.Year, incomeDate.Month)}");
        }
    }
}
