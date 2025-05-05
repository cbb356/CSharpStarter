using System.Globalization;

namespace Converter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input current rate of UAH/EUR");
        float rate = float.Parse(Console.ReadLine());
        Console.WriteLine("Input sum in UAH");
        double sum = double.Parse(Console.ReadLine());
        double result = sum/rate;
        Console.WriteLine($"Sum in EUR: {Math.Round(result, 2)}");
        Console.ReadKey();
    }
}