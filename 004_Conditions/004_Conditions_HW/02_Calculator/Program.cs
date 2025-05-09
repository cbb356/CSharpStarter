namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 6, operand2 = 0;
            Console.WriteLine("Enter the arithmetic operation (+, -, *, /, %):");
            string sign = Console.ReadLine();

            switch (sign) 
            {
                case "+":
                {
                    Console.WriteLine($"{operand1} {sign} {operand2} = {(operand1 + operand2)}");
                    break;
                }
                case "-":
                {
                    Console.WriteLine($"{operand1} {sign} {operand2} = {(operand1 - operand2)}");
                    break;
                }
                case "*":
                {
                    Console.WriteLine($"{operand1} {sign} {operand2} = {(operand1 * operand2)}");
                    break;
                }
                case "/":
                {
                    if (operand2 == 0)
                    {
                        Console.WriteLine($"You cannot divide by zero!");
                        break;
                    } 
                    Console.WriteLine($"{operand1} {sign} {operand2} = {((double)operand1 / operand2)}");
                    break;
                }
                case "%":
                {
                    if (operand2 == 0)
                    {
                        Console.WriteLine($"You cannot calculate the remainder of a division by zero!");
                        break;
                    } 
                    Console.WriteLine($"{operand1} {sign} {operand2} = {(operand1 % operand2)}");
                    break;
                }
                default:
                {
                    Console.WriteLine($"Incorrect operation");
                    break;
                }
            }
        }
    }
}
