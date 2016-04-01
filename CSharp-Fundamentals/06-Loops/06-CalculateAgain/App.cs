namespace _06_CalculateAgain
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var result = CalculateFactorial(n)/CalculateFactorial(k);
            Console.WriteLine(result);
        }

        private static double CalculateFactorial(int number)
        {
            double fact = number;
            for (var i = number - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}