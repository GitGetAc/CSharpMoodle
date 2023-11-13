using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Hello World! The number is: " + num);        //Simple WriteLine with +
            Console.WriteLine($"Hello World! The number is: {num}");        //Interpolated string
        }
    }
}
