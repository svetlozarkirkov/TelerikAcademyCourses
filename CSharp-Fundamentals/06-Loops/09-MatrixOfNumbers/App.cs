namespace _09_MatrixOfNumbers
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(i, n)));
            }
        }
    }
}