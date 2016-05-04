namespace _01_AllocateArray
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = i * 5;
            }
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}