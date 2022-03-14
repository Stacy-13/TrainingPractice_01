class Program
{
    public static void Main()
    {
        string message = Console.ReadLine();
        while (message!=("exit"))
        {
            message = Console.ReadLine();
        }
        Console.WriteLine("Программа прекратила работу");
        Console.ReadLine();
    }
}