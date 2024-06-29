using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                int standardPrice = 10; // GHC10 for standard ticket
                int discountedPrice = 7; // GHC7 for seniors (65+) and children (12 and below)

                if (age >= 65 || age <= 12)
                {
                    Console.WriteLine($"Ticket price for age {age} is GHC{discountedPrice}");
                }
                else
                {
                    Console.WriteLine($"Ticket price for age {age} is GHC{standardPrice}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
            }

    }
}
