using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            string input = Console.ReadLine();
            int grade;

            // Validate the input to ensure it is a valid integer within the range 0-100
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The letter grade for {grade} is {letterGrade}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
