namespace CylinderVolumeSurfaceArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 3.5, h = 4.5;
            double volume = Math.PI * Math.Pow(r, 2) * h;
            double surfaceArea = 2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h;
            Console.WriteLine($"The volume of cylinder with radius {r} and height {h} is {volume}");
            Console.WriteLine($"The surface area of cylinder with radius {r} and height {h} is {surfaceArea}");
        }
    }
}
