namespace Debt
{
    internal class Program
    {
        static void DebtPay(ref int debt, int payment)
        {
            debt -= payment;
            if (debt > 0)
            {
                Console.WriteLine($"The sum of debt: {debt}");
            }
            else if (debt < 0)
            {
                Console.WriteLine($"The debt is paid off"); 
                Console.WriteLine($"The sum of overpayment: {debt}");
            }
            else
            {
                Console.WriteLine($"The debt is paid off");
            }
        }
        static void Main(string[] args)
        {
            int debt = 700;
            int payment = 0;

            for (int i = 1; i <= 7; i++)
            {
                if (debt <= 0)
                {
                    break;
                }

                //Input sum of payment until it is valid
                bool validPayment = false;
                while(!validPayment)
                {
                    Console.WriteLine($"Input sum of {i} payment");
                    if ((int.TryParse(Console.ReadLine(), out payment)) && payment >= 0)
                    {
                        validPayment = true;
                        Console.WriteLine($"{i} payment: {payment}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input for payment");
                    }
                }

                DebtPay(ref debt, payment);
            }
            
            if (debt > 0)
            {
                Console.WriteLine("The debt is NOT paid off on time");
            }
        }
    }
}
