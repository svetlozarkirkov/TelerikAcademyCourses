namespace _07_CalculateCombinations
{
    using System;
    using System.Numerics;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var result = CalculateFactorial(n)/(CalculateFactorial(k)*(CalculateFactorial(n - k)));
            Console.WriteLine(result);
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