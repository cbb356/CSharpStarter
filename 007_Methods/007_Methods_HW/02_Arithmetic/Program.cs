namespace Arithmetic
{
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first number A:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Wrong input for number A.");
                return;
            }

            Console.WriteLine("Input second number B:");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Wrong input for number B.");
                return;
            }

            double result;

            Console.WriteLine("Input operand (+ - * /):");
            string operation = Console.ReadLine().Trim();
            switch (operation)
            {
                case "+":
                {
                    result = Add(a, b);
                    break;
                }
                case "-":
                {
                    result = Sub(a, b);
                    break;
                }
                case "*":
                {
                    result = Mul(a, b);
                    break;
                }
                case "/":
                {
                    if (b == 0)
                    {
                        Console.WriteLine("You can't divide by 0");
                        return;
                    }
                    result = Div(a, b);
                    break;      
                }
                default:
                {
                    Console.WriteLine("You entered a wrong arithmetic operation");
                    return;
                }
            }

            Console.WriteLine($"The result of {a} {operation} {b} = {result}");

            // Delay.
            Console.ReadKey();
        }
    }       
}
