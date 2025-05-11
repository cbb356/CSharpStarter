namespace DrawingFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rectangle
            Console.WriteLine("Rectangle:\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // Right Triangle
            Console.WriteLine("\nRight Triangle:\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            //Equilateral Triangle
            Console.WriteLine("\nEquilateralTriangle\n");
            for (int i = 1; i <= 5; i++)
            {
                // Spaces
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            //Rhombus
            Console.WriteLine("\nRhombus\n");
            //Top
            for (int i = 1; i <= 4; i++)
            {
                // Spaces
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            //Bottom
            for (int i = 3; i > 0; i--)
            {
                // Spaces
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                // Stars
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
