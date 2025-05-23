using System;

namespace SelectionSort
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

        static void SelectionSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Get Index of the element with minimal value
                int minValue = array[i];
                int minValueIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (minValue >= array[j])
                    {
                        minValue = array[j];
                        minValueIndex = j;
                    }
                }

                //Swap array elements 
                int temp = array[i];
                array[i] = array[minValueIndex];
                array[minValueIndex] = temp;
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
            SelectionSortArray(array);
            ShowArray("Elements of the sorted array (asc): ", array);

            // Delay.
            Console.ReadKey();
        }
    }
}
