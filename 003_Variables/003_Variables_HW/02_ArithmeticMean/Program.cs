namespace ArithmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            double mean = (double)(x + y + z) / 3;
            Console.WriteLine($"The arithmetic mean of numbers {x}, {y} and {z} is: {mean}");
        }
    }
}
