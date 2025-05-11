namespace LogicShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 0xF8, b = 0xF8, e = 0xF8;  
            sbyte c = (sbyte)a;
            sbyte d = (sbyte)b;
            sbyte f = (sbyte)e;
            Console.WriteLine($"byte before: {a}, 0x{a:X2}, {a:B8}, sbyte before: {c}, 0x{c:X2}, {c:B8}");
            a >>= 1;    
            b <<= 1;
            c >>= 1;
            d <<= 1;
            e >>>= 1;
            f >>>= 1;
            Console.WriteLine($"byte after >>: {a}, 0x{a:X2}, {a:B8}, sbyte after >>: {c}, 0x{c:X2}, {c:B8}");
            Console.WriteLine($"byte after <<: {b}, 0x{b:X2}, {b:B8}, sbyte after <<: {d}, 0x{d:X2}, {d:B8}");
            Console.WriteLine($"byte after >>>: {e}, 0x{e:X2}, {e:B8}, sbyte after >>>: {f}, 0x{f:X2}, {f:B8}");
            /*
            Під час виконання операцій з цілочисловими типами, меншими за int, 
            вони автоматично розширюються до int (або uint для беззнакових) 
            перед виконанням операції. Це називається "цілочисельне підвищення" (integral promotion). 
            Через це операції >> і >>> для типів менших за int дають однакові результати.
            */

            //for (int i = -128; i <= 127; i++)
            //{
            //    Console.WriteLine($"{i} = 0x{(sbyte)i:X2} = {(sbyte)i:b8}");
            //}


            int x = -8;
            Console.WriteLine($"Before:    {x,11}, hex: {x,8:x}, binary: {Convert.ToString(x, toBase: 2),32}");

            int y = x >> 2;
            Console.WriteLine($"After  >>: {y,11}, hex: {y,8:x}, binary: {Convert.ToString(y, toBase: 2),32}");

            int z = x >>> 2;
            Console.WriteLine($"After >>>: {z,11}, hex: {z,8:x}, binary: {Convert.ToString(z, toBase: 2).PadLeft(32, '0'),32}");
            // Output:
            // Before:             -8, hex: fffffff8, binary: 11111111111111111111111111111000
            // After  >>:          -2, hex: fffffffe, binary: 11111111111111111111111111111110
            // After >>>:  1073741822, hex: 3ffffffe, binary: 00111111111111111111111111111110
        }
    }
}