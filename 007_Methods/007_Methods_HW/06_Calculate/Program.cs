namespace Calculate
{
    internal class Program
    {
        static double Calculate(int a, int b, int c)
        {
            return (double)(a + b + c) / 3;
        }
        
        static void Main(string[] args)
        {
            int a = 6, b = 3, c = 4;
            Console.WriteLine ($"Mean of numbers {a}, {b}, {c} = {Calculate(a, b, c)}");
        }
    }
}
