namespace Delivery
{
    internal class Program
    {
        static int CalculateFactorial (int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return x * CalculateFactorial(x - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number of clients (max 12):");
            if ((!int.TryParse(Console.ReadLine(), out int clientsNumber)) || clientsNumber <= 0 || clientsNumber > 12)
            {
                Console.WriteLine("Wrong input for number of clients.");
                return;
            }

            Console.WriteLine($"Number of delivery variants: {CalculateFactorial(clientsNumber)}");

            // Delay.
            Console.ReadKey();
        }
    }
}
