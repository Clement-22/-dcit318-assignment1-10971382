using System;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side: ");
            double side1 = GetSideLength();

            Console.Write("Enter the length of the second side: ");
            double side2 = GetSideLength();

            Console.Write("Enter the length of the third side: ");
            double side3 = GetSideLength();

            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is {triangleType}.");
        }

        static double GetSideLength()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a positive number: ");
                }
            }
        }

        static string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
