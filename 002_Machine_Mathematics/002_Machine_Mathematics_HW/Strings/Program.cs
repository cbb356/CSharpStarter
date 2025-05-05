namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string str1 = "\nмій рядок 1";
            string str2 = "\tмій рядок 2";
            string str3 = "\aмій рядок 3";

            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine("str3: " + str3);
        }
    }
}
