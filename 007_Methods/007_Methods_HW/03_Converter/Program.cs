namespace Converter
{
    internal class Program
    {
        static double Exchange(double amount, double rate)
        {
            return (amount * rate);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of EUR to convert:");
            if ((!double.TryParse(Console.ReadLine(), out double amount)) || amount < 0)
            {
                Console.WriteLine("Wrong input for amount");
                return;
            }

            Console.WriteLine("Input EUR -> UAH exchange rate:");
            if ((!double.TryParse(Console.ReadLine(), out double rate)) || rate <= 0)
            {
                Console.WriteLine("Wrong input for rate");
                return;
            }

            double result = Exchange(amount, rate);
            Console.WriteLine($"{amount} EUR converted at a rate of {rate} equals {result:F2} UAH");
        }        
    }
}
