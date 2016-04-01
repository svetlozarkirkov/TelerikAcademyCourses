namespace _16_TrailingZeroInFactorial
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var zeroes = 0;

            if (n == 5)
            {
                Console.WriteLine(1);
                return;
            }

            for (var i = 5; n / i >= 1; i *= 5)
            {
                zeroes += n / i;
            }

            Console.WriteLine(zeroes);
        }
    }
}