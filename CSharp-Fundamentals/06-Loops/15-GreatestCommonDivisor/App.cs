namespace _15_GreatestCommonDivisor
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = 0;
            var biggestNumber = inputNumbers.Max();

            for (var i = 1; i <= biggestNumber; i++)
            {
                if (inputNumbers[0] % i == 0 && inputNumbers[1] % i == 0 && i != 0)
                {
                    result = i;
                }
            }

            Console.WriteLine(result);
        }
    }
}