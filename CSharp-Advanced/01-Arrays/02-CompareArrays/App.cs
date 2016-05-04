namespace _02_CompareArrays
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firstArray = new int[n];
            var secondArray = new int[n];
            for (var i = 0; i < n * 2; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstArray[i] = currentNumber;
                }
                else
                {
                    secondArray[i - n] = currentNumber;
                }
            }
            Console.WriteLine(firstArray.SequenceEqual(secondArray) ? "Equal" : "Not equal");
        }
    }
}