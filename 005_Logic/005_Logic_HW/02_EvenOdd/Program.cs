namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number (int):");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Wrong input for number");
                return;
            }

            if ((number << 31) == 0)
            {
                Console.WriteLine("The number {0} is even", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd", number);
            }

            if ((number | -2) == -1)
            {
                Console.WriteLine("The number {0} is odd", number);
            }
            else
            {
                Console.WriteLine("The number {0} is even", number);
            }
            
            if ((number & 1) == 0)
            {
                Console.WriteLine("The number {0} is even", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd", number);
            }
        }
    }
}
