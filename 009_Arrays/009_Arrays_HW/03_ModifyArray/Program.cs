namespace ModifyArray
{
    internal class Program
    {
        static int[] MyReverse(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[array.Length - (i + 1)] = array[i];
            }
            return result;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                if ((index + i) < array.Length)
                {
                    result[i] = array[index + i];
                }
                else
                {
                    result[i] = 1;
                }
                
            }
            return result;
        }

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

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ShowArray("Elements of the array: ", array);
            ShowArray("Elements of the reversed array: ", MyReverse(array));
            ShowArray("Elements of the subarray: ", SubArray(array, 1, 2));
            ShowArray("Elements of the subarray: ", SubArray(array, 2, 10));

            // Delay.
            Console.ReadKey();
        }
    }
}
