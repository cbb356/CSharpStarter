namespace Evaluate
{
    internal class Program
    {
        static bool IsDivisible(int number, int divider)
        {
            return (number % divider == 0);
        }

        static void CheckDivisibility(int number, int divider)
        {
            if (IsDivisible(number, divider))
            {
                Console.WriteLine($"{number} is divisible by {divider} with no remainder");
            }
            else
            {
                Console.WriteLine($"{number} is NOT divisible by {divider} with no remainder");
            }

        }

        static bool IsPrime(int number)
        {
            if (number < 2) { return false; }
            
            int counter = 2;
            while (counter < number)
            { 
                if (IsDivisible (number, counter))
                {
                    return false;
                }
                counter++;
            }

            return true;
        }

        static void CheckNumberProperties(int number) 
        {
            //Check positivity
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if(number < 0)
            {
                Console.WriteLine($"{number} is a negative number");

            }
            else
            {
                Console.WriteLine($"{number} is 0");
            }

            // Check if prime
            bool isPrime = IsPrime(number);
            Console.WriteLine($"{number} is a prime number: {isPrime}");

            //Check Divisibility
            CheckDivisibility(number, 2);
            CheckDivisibility(number, 5);
            CheckDivisibility(number, 3);
            CheckDivisibility(number, 6);
            CheckDivisibility(number, 9);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number (int):");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Wrong input for number");
                return;
            }

            CheckNumberProperties(number);
        }
    }
}
