namespace CalculateDivision
{
    internal class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine($"{a} / 5 = {(double)a / 5}");
            Console.WriteLine($"{b} / 5 = {(double)b / 5}");
            Console.WriteLine($"{c} / 5 = {(double)c / 5}");
        }
        
        static void Main(string[] args)
        {
            Calculate(4, -11, 265);

            // Delay.
            Console.ReadKey();
        }
    }
}
