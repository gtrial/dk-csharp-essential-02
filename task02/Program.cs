using System;

namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            Converter converter = new Converter(1 / 28.1, 1 / 33.2, 1 / 0.4);
            Console.WriteLine($"UAH amount:");
            double uah = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"USD: {uah * converter.Usd}");
            Console.WriteLine($"USD amount:");
            double usd = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"UAH: {usd / converter.Usd}");
        }
    }
}
