using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are your numbers:");
            var gen = new FibonacciGenerator();
            foreach (var digit in gen.Generate(15)) {
                Console.WriteLine(digit);
            }
        }
    }
}
