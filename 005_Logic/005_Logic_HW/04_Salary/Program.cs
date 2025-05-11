namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of years the employee has worked at the company (int):");
            if ((!int.TryParse(Console.ReadLine(), out int yearsNumber)) || yearsNumber < 0)
            {
                Console.WriteLine("Wrong input for number");
                return;
            }

            int bonusAmount = yearsNumber switch
            {
                < 5 => 10,
                < 10 => 15,
                < 15 => 25,
                < 20 => 35,
                < 25 => 45,     
                _ => 50
            };

            Console.WriteLine($"The bonus amount for the employeer who has worked " +
                $"at the company for {yearsNumber} years is {bonusAmount}% of salary");
        }
    }
}
