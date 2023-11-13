namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei på deg!");
            var input = Console.ReadLine();
            Console.WriteLine($"Du skrev: {input}");
            Console.ReadKey();
        }
    }
}