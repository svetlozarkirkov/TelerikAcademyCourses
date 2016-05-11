namespace _08_MaximalSum
{
    using System;
    using System.Collections.Generic;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var maxSum = 0;
            for (var i = 0; i < n; i++)
            {
                var currentSum = array[i];

                for (var j = i + 1; j < n; j++)
                {
                    currentSum += array[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}