namespace _03_CompareCharArrays
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var firstArray = Console.ReadLine();
            var secondArray = Console.ReadLine();
            var result = string.CompareOrdinal(firstArray, secondArray);
            if (result == 0)
            {
                Console.WriteLine("=");
            }
            else if (result < 0)
            {
                Console.WriteLine("<");
            }
            else if (result > 0)
            {
                Console.WriteLine(">");
            }
        }
    }
}