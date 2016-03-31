namespace _08_NumbersFrom1ToN
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}