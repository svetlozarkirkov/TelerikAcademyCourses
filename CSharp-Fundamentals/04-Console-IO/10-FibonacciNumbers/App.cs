namespace _10_FibonacciNumbers
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var first = 0;
            var second = 1;
            for (var i = 0; i < n; i++)
            {
                Console.Write("{0}", first);
                first = second - first;
                second += first;
                if (i != n - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}