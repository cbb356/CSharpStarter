namespace Arrays
{
    internal class Program
    {
        static void ChangeArray (ref int[] array)
        {
            array = new int [] { 3, 6, 9};
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
        }
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2 };

            ChangeArray (ref array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
