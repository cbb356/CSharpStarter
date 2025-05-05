namespace OperatorPrecedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initX = 10, initY = 12, initZ = 3;

            int x = initX, y = initY, z = initZ;
            Console.WriteLine(x += y - x++ * z);  //-8

            x = initX;
            y = initY; 
            z = initZ;
            Console.WriteLine(z = --x - y * 5);   //-51

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(y /= x + 5 % z);    //1

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(z = x++ + y * 5);   //70

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(x = y - x++ * z);   //-18
        }
    }
}
