using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            Console.Write("Side 1: ");
            if (double.TryParse(Console.ReadLine(), out double side1) && side1 > 0)
            {
                Console.Write("Side 2: ");
                if (double.TryParse(Console.ReadLine(), out double side2) && side2 > 0)
                {
                    Console.Write("Side 3: ");
                    if (double.TryParse(Console.ReadLine(), out double side3) && side3 > 0)
                    {
                        if (side1 == side2 && side2 == side3)
                        {
                            Console.WriteLine("Triangle type: Equilateral");
                        }
                        else if (side1 == side2 || side1 == side3 || side2 == side3)
                        {
                            Console.WriteLine("Triangle type: Isosceles");
                        }
                        else
                        {
                            Console.WriteLine("Triangle type: Scalene");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for side 3. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for side 2. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for side 1. Please enter a positive number.");
            }

    }
}
