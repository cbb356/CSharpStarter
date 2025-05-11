using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exponent2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number (int):");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Wrong input for number");
                return;
            }

            if ((((number - 1) & number) == 0) && (number > 0))
            {
                Console.WriteLine("The number {0} is a power of 2", number);
            }
            else
            {
                Console.WriteLine("The number {0} isn't a power of 2", number);
            }
        }
    }
}
