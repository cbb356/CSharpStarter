namespace ArrayEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array (positive integer N): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int[] array = new int[n];
            Random rand = new Random();

            // Fill the array with random integers.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-1000, 1001);
            }

            Console.Write("Elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < (array.Length - 1))
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine($"\nMaximum value: {array.Max()}");
            Console.WriteLine($"Minimum value: {array.Min()}");
            Console.WriteLine($"Sum of all array elements: {array.Sum()}");
            Console.WriteLine($"Average value: {array.Average()}");
            Console.Write($"Odd values: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i]);
                    if (i < (array.Length - 1))
                    {
                        Console.Write(", ");
                    }
                }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}