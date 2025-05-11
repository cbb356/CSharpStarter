namespace DrawingRectangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rectangle
            Console.WriteLine("Rectangle:\n");
            int width = 5, height = 7;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
