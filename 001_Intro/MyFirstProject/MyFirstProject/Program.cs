namespace MyFirstProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, "+ name +"!");
        
        Console.ReadKey();
    }
}