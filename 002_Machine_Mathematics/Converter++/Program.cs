namespace Converter__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input current rate of EUR");
            string answer = Console.ReadLine();
            float rate = float.Parse(answer);

            Console.WriteLine("Input sum in HRN");
            answer = Console.ReadLine();

            double sum = double.Parse(answer);   
            double result = sum / rate;
            result = Math.Round(result, 2);

            Console.WriteLine($"Sum in euro is {result}");

            Console.WriteLine(new String('*', 50));

            Console.WriteLine("Input sum in EUR");
            answer = Console.ReadLine();

            sum = double.Parse(answer);
            result = sum * rate;
            result = Math.Round(result, 2);

            Console.WriteLine($"Sum in hrn is {result}");

            Console.ReadKey();
        }
    }
}
