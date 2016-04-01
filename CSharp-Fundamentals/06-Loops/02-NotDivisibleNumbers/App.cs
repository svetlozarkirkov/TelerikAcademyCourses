namespace _02_NotDivisibleNumbers
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(
                string.Join(" ", Enumerable.Range(1, n).Where(i => i%3 != 0 && i%7 != 0)));
        }
    }
}