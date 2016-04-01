namespace _10_OddAndEvenProduct
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var oddProductValue = 1;
            var evenProductValue = 1;
            for (var i = 0; i < n; i++)
            {
                var currentNumber = numbers[i];

                if (i%2 == 0)
                {
                    oddProductValue *= currentNumber;
                }
                else
                {
                    evenProductValue *= currentNumber;
                }
            }
            if (oddProductValue == evenProductValue)
            {
                Console.WriteLine("yes {0}", oddProductValue);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProductValue, evenProductValue);
            }
        }
    }
}