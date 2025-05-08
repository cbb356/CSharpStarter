namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal number = 0.1234567890123456789m;
            int number1 = 240;
            Console.WriteLine($"Decimal (no modifiers): {number}");
            Console.WriteLine($"Decimal (F3): {number:F3}");
            Console.WriteLine($"Decimal (C2): {number:C2}");
            Console.WriteLine($"Decimal (E5): {number:E5}");
            Console.WriteLine($"Decimal (G4): {number:G4}");
            Console.WriteLine($"Decimal (N4): {number:N4}");
            Console.WriteLine($"Decimal (P3): {number:P3}");
            Console.WriteLine($"Decimal (R6): {number:R6}");
            Console.WriteLine($"Int (B32): {number1:B32}");
            Console.WriteLine($"Int (X8): {number1:X8}");
            Console.WriteLine($"Int (N3): {number1:N3}");
            Console.WriteLine($"Int (G3): {number1:G3}");
        }
    }
}
