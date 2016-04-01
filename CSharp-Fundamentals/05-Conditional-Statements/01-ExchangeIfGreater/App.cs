namespace _01_ExchangeIfGreater
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                var temp = b;
                b = a;
                a = temp;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}