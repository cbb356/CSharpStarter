namespace ExpandArray
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

        static int[] ExpandArray(int[] array, int number)
        { 
            int[] result = new int[array.Length + 1];
            result[0] = number;
            for (int i = 0; i < array.Length; i++)
            {
                result[i + 1] = array[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ShowArray("Elements of the array: ", array);
            ShowArray("Elements of the modified array: ", ExpandArray(array, 10));

            // Delay.
            Console.ReadKey();
        }
    }
}
