using Exeção.Entities;
using Exeção.Entities.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        withException();
    }


    void Exercicio1()
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 / n2;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error! " + e.Message);
        }
    }

    static void noException()
    {
        Console.Write("Room number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());

        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkIn <= checkOut)
            Console.WriteLine("Error in reservation: Check-out date must be after check-in");
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine(reservation.ToString() + reservation);
            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
                Console.WriteLine("Error in reservation : Reservationd date must be future dates");
            else if (checkIn <= checkOut)
                Console.WriteLine("Error in reservation: Check-out date must be after check-in");
            else
            {
                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine(reservation.ToString() + reservation);
            }
        }
    }

    static void withException()
    {
        try
        {
            Console.Write("Room number:");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine(reservation.ToString() + reservation);
            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDate(checkIn, checkOut);
            Console.WriteLine("Reservation" + reservation);
        }
        catch (DomainException e)
        {
            Console.WriteLine($"Error in reservation: {e}");
        }
    }
}