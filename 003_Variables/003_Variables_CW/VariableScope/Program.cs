namespace VariableScope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }

            //value = 5;
            Console.WriteLine($"Outide the code block: {value}");
        }
    }
}
