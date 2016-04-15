namespace _05_Calculate
{
    using System;
    using System.Numerics;

    internal class App
    {
        private static void Main()
        {

        }

        private static BigInteger CalculateFactorial(BigInteger number)
        {
            var fact = number;

            for (var i = number - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}