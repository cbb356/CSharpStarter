namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = array.Length; i > 0; i--)
            {
                Console.Write($"{array[i - 1]} ");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
