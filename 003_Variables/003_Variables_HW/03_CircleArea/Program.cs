namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 3.5;
            double area = Math.PI*Math.Pow(r, 2);
            Console.WriteLine($"The area of circle with radius {r} is {area}");
        }
    }
}
