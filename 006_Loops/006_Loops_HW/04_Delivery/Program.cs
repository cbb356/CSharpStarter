namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of clients:");
            if ((!int.TryParse(Console.ReadLine(), out int clientsNumber)) || clientsNumber <= 0)
            {
                Console.WriteLine("Wrong input for number of clients.");
                return;
            }

            int deliveryVariants = 1;
            do
            {
                deliveryVariants *= clientsNumber--;
            }
            while (clientsNumber > 0);

            Console.WriteLine($"Number of delivery variants: {deliveryVariants}");
        }
    }
}
