namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initX = 5, initY = 10, initZ = 15;

            int x = initX, y = initY, z = initZ;
            Console.WriteLine(x += y >> x++ * z);  //5

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(z = ++x & y * 5);   //2

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(y /= x + 5 | z);    //0

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(z = x++ & y * 5);   //0

            x = initX;
            y = initY;
            z = initZ;
            Console.WriteLine(x = y << x++ ^ z);   //335

        }
    }
}
