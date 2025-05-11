namespace SumOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number A (int):");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Wrong input for number A.");
                return;
            }

            Console.WriteLine("Input second number B (int, B > A):");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Wrong input for number B.");
                return;
            }

            int sum = 0;
            string oddNumbers = string.Empty;

            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    sum += i;
                    if (i % 2 != 0)
                    {
                        oddNumbers += $"{i} ";
                    }
                }
                Console.WriteLine($"Odd numbers between {a} and {b} are {oddNumbers}");
                Console.WriteLine($"The sum of numbers between {a} and {b} is {sum}");
            }
            else
            {
                Console.WriteLine("Number B should be bigger than A");
            }

        }
    }
}
