using Heranca_e_Polimorfismo.Entidades;
using Heranca_e_Polimorfismo.Enums;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 1, 2 ou 3?");
        int i = int.Parse(Console.ReadLine());

        if (i.Equals(1))
            Exercicio1();
        else if (i.Equals(2))
            Exercicio2();
        else if (i.Equals(3))
            Exercicio3();
    }

    private static void Exercicio3()
    {
        Console.Write("Enter the number of shapes: ");
        int numberShapes = int.Parse(Console.ReadLine());
        List<Shape> shapes = new List<Shape>();

        for (int i = 1; i <= numberShapes; i++)
        {

            Console.WriteLine($"Shape #{i} data: ");

            Console.Write("Rectangle or Circle (r/c)? ");
            string type = Console.ReadLine();

            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (type.Equals("r"))
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Height: ");
                double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Retangle(width,heigth, color));
            }
            else if (type.Equals("c"))
            {
                Console.WriteLine("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Circle(radius, color));
            }
        }
        Console.WriteLine("SHAPE AREAS");
        shapes.ForEach(i => Console.WriteLine(i.area().ToString("F2", CultureInfo.InvariantCulture)));
    }

    private static void Exercicio2()
    {
        List<Product> products = new List<Product>();

        Console.Write("Enter the number of products: ");
        int numberProducts = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberProducts; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported(c / u / i) ? ");
            string type = Console.ReadLine().ToLower();
            if (type.Equals("i"))
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Custom fee: ");
                double customFee = double.Parse(Console.ReadLine());

                products.Add(new ImportedProduct(name, price, customFee));
            }
            else if (type.Equals("c"))
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                products.Add(new Product(name, price));
            }
            else if (type.Equals("u"))
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Manufacture date (DD/MM/YYYY):: ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                products.Add(new UsedProduct(name, price, manufactureDate));
            }
        }

        Console.WriteLine("Price Tags: ");
        products.ForEach(i => Console.WriteLine(i.priceTag()));
    }

    public static void Exercicio1()
    {
        List<Employee> employees = new List<Employee>();

        Console.WriteLine("Enter the number of employees");
        int numberEmployees = int.Parse(Console.ReadLine());

        for (int num = 1; num <= numberEmployees; num++)
        {
            Console.WriteLine($"Employee {num} data:");

            Console.WriteLine("Outsourced (y/n)?");
            string isOutsourced = Console.ReadLine();

            if (isOutsourced.ToLower().Equals("y"))
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.WriteLine("Additional charge:");
                double additionalCharge = double.Parse(Console.ReadLine());

                employees.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                Console.WriteLine();
            }

            else if (isOutsourced.ToLower().Equals("n"))
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                employees.Add(new Employee(name, hours, valuePerHour));
                Console.WriteLine();
            }
        }

        Console.WriteLine("Payments:");
        employees.ForEach(i => Console.WriteLine($"{i.Name} - {i.payment().ToString("F2", CultureInfo.InvariantCulture)}"));
    }
}