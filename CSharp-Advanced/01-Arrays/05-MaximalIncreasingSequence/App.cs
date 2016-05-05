namespace _05_MaximalIncreasingSequence
{
    using System;
    using System.Collections.Generic;

    internal class App
    {
        // TODO: Fix
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var result = GetMaximalIncreasingSequence(array);
            Console.WriteLine(result);
        }

        private static int GetMaximalIncreasingSequence(IReadOnlyList<int> array)
        {
            var maxLength = 1;

            for (var i = 0; i < array.Count; i++)
            {
                var currentNum = array[i];
                var currentLength = 1;

                for (var j = i + 1; j < array.Count; j++)
                {
                    if (array[j] != currentNum + 1)
                    {
                        break;
                    }

                    currentLength++;
                    currentNum = array[j];
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            return maxLength;
        }
    }
}