namespace BubbleSort
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

        static void BubbleSortArray(int[] array)
        {
            int temp;
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }   
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            // Fill the array with random integers.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
            }

            ShowArray("Elements of the array: ", array);
            BubbleSortArray(array);
            ShowArray("Elements of the sorted array (asc): ", array);

            // Delay.
            Console.ReadKey();
        }
    }
}
