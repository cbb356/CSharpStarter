namespace ArrayEvaluation
{
    internal class Program
    {
        static void ShowArray(string name, int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < (array.Length - 1))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static int[] OddNumbersArray(int[] array)
        {
            int oddCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            int[] result = new int[oddCount];
            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result[currentIndex] = array[i];
                    currentIndex++;
                }
            }

            return result;
        }
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
                array[i] = rand.Next(-100, 101);
            }

            ShowArray("Elements of the array: ", array);

            Console.WriteLine($"Maximum value: {array.Max()}");
            Console.WriteLine($"Minimum value: {array.Min()}");
            Console.WriteLine($"Sum of all array elements: {array.Sum()}");
            Console.WriteLine($"Average value: {array.Average()}");

            //Create subarray with odd numbers only
            int[] oddNumbersArray = OddNumbersArray(array);
            ShowArray("Odd values: ", oddNumbersArray);

            Console.WriteLine();

            // Delay.
            Console.ReadKey();
        }
    }
}