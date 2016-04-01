namespace _01_NumbersFrom1toN
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, n)));
        }
    }
}