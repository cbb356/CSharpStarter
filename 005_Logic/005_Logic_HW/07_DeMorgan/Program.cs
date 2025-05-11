namespace DeMorgan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = false;

            Console.WriteLine("A : {0}\nB : {1}", a, b);
            Console.WriteLine("A | B : {0}", a | b);
            Console.WriteLine("!(!A & !B) : {0}", !(!a & !b));

            if ((a | b) == !(!a & !b))
            {
                Console.WriteLine("The conversion is right");
            }
            else
            {
                Console.WriteLine("The conversion is wrong");
            }
        }
    }
}
