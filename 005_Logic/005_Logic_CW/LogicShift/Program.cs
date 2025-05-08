namespace LogicShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 0xF8;  
            sbyte b = (sbyte)a; 
            Console.WriteLine($"byte = {a}, 0x{a:X2}, {a:B8}, sbyte = {b}, 0x{b:X2}, {b:B8}");
            a <<= 2;    
            b <<= 2;    
            Console.WriteLine($"byte = {a}, 0x{a:X2}, {a:B8}, sbyte = {b}, 0x{b:X2}, {b:B8}");

            for (int i = -128; i <= 127; i++)
            {
                Console.WriteLine($"{i} = 0x{(sbyte)i:X2} = {(sbyte)i:b8}");
            }
        }
    }
}