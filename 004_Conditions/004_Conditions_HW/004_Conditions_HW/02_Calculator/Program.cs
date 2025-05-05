namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 6, operand2 = 4;
            Console.WriteLine("Enter the operation:");
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
                        Console.WriteLine($"You can't divide by zero!");
                        break;
                    } 
                    else
                    {
                        Console.WriteLine($"{operand1} {sign} {operand2} = {((double)operand1 / operand2)}");
                    }                           
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
