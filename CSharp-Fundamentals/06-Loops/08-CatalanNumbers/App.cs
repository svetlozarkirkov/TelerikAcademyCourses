namespace _08_CatalanNumbers
{
    using System;
    using System.Numerics;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            var result = CalculateFactorial(2*n)/(CalculateFactorial(n + 1)*CalculateFactorial(n));
            Console.WriteLine(result);
        }

        private static BigInteger CalculateFactorial(int number)
        {
            BigInteger fact = number;
            for (var i = number - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}