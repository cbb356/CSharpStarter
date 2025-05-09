using System.Diagnostics.Metrics;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter an integer [0-100]:");
            string input = Console.ReadLine();

            bool success = int.TryParse(input, out number);

            if (success)
            {
                switch (number)
                {
                    case < 0:
                    case > 100:
                        Console.WriteLine($"Entered value is {number}; out of an acceptable range.");
                        break;
                    case < 15:
                        Console.WriteLine($"Entered value {number} is in range [0-14]");
                        break;
                    case < 36:
                        Console.WriteLine($"Entered value {number} is in range [15-35]");
                        break;
                    case < 51:
                        Console.WriteLine($"Entered value {number} is in range [36-50]");
                        break;
                    default:
                        Console.WriteLine($"Entered value {number} is in range [51-100]");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered wrong value");
            }
        }
    }
}
