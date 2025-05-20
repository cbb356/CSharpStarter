namespace Loan
{
    internal class Program
    {
        static void PaymentProcess(ref decimal debt, decimal payment)
        {
            Console.WriteLine($"The payment has been accepted");
            debt -= payment;
            if (debt > 0)
            {
                Console.WriteLine($"The remaining debt amount is: {debt}");
            }
            else if (debt < 0)
            {
                Console.WriteLine($"The loan has been paid with an overpayment: {-debt}");
            }
            else
            {
                Console.WriteLine($"The loan has been paid completely");
            }
        }

        static void Main(string[] args)
        {
            const int paymentsRequired = 7;
            const decimal monthlyPaymentAmount = 100m;
            const decimal totalLoanAmount = paymentsRequired * monthlyPaymentAmount;
            decimal remainingDebt = totalLoanAmount;
            decimal paymentAmount = 0m;

            Console.WriteLine($"The total loan amount is: {totalLoanAmount}");
            Console.WriteLine($"{paymentsRequired} payments of {monthlyPaymentAmount} are expected");

            for (int i = 1; i <= paymentsRequired; i++)
            {
                if (remainingDebt <= 0)
                {
                    break;
                }

                //Input valid payment amount
                bool validPayment = false;
                while(!validPayment)
                {
                    Console.Write($"\nPlease enter amount of the payment {i}: ");
                    if ((decimal.TryParse(Console.ReadLine(), out paymentAmount)) && paymentAmount >= 0)
                    {
                        validPayment = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid payment amount");
                    }
                }

                PaymentProcess(ref remainingDebt, paymentAmount);
            }
            
            if (remainingDebt > 0)
            {
                Console.WriteLine("The loan was not paid on time");
            }
        }
    }
}
