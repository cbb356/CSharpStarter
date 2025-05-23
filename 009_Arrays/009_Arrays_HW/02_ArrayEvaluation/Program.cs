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

        static int GetMaxValue(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {   
                if (maxValue <= array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        static int GetMinValue(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue >= array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        static int GetArraySum(int[] array)
        {
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static double GetArrayAverage(int[] array)
        {
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }

        static int[] GetArrayOddNumbers(int[] array)
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
            Console.WriteLine($"Maximum value: {GetMaxValue(array)}");
            Console.WriteLine($"Minimum value: {GetMinValue(array)}");
            Console.WriteLine($"Sum of all array elements: {GetArraySum(array)}");
            Console.WriteLine($"Average value: {GetArrayAverage(array)}");
            ShowArray("Odd values: ", GetArrayOddNumbers(array));
            Console.WriteLine();

            // Delay.
            Console.ReadKey();
        }
    }
}