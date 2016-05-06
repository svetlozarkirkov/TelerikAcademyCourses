namespace _06_MaximalKSum
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}