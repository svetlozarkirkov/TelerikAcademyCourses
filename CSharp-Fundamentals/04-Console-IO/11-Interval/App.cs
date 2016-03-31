namespace _11_Interval
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var count = 0;
            for (var i = n + 1; i < m; i++)
            {
                if (i%5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}