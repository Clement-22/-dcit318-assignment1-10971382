using System;

namespace MovieTicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate the input to ensure it is a valid integer
            if (int.TryParse(input, out age) && age >= 0)
            {
                int ticketPrice = GetTicketPrice(age);
                Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static int GetTicketPrice(int age)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            if (age <= 12 || age >= 65)
            {
                return discountedPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }
}
