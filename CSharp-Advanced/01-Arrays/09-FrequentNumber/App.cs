namespace _09_FrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    var oldCount = dict[array[i]];
                    dict[array[i]] = oldCount + 1;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }
            var orderedItems = from pair in dict
                        orderby pair.Value descending
                        select pair;
            var result = orderedItems.First();
            Console.WriteLine("{0} ({1} times)", result.Key, result.Value);
        }
    }
}