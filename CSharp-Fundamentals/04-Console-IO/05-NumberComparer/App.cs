namespace _05_NumberComparer
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);
        }
    }
}