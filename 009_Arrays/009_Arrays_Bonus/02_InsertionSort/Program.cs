using System;
using System.Reflection;

namespace InsertionSort
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
        static void InsertionSortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > temp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        static void InsertionSortArrayAlternative(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                //Get new position for the element;
                int newPositionIndex = i;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] < array[j])
                    {
                        newPositionIndex = j;
                        break;
                    }
                }

                //Insert the element to array
                if (newPositionIndex != i)
                {
                    int temp = array[i];
                    for (int k = i; k > newPositionIndex; k--)
                    {
                        array[k] = array[k - 1];
                    }
                    array[newPositionIndex] = temp;
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
            InsertionSortArray(array);
            ShowArray("Elements of the sorted array (asc): ", array);

            // Delay.
            Console.ReadKey();
        }
    }
}
