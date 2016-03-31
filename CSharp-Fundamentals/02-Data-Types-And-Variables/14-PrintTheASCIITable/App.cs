namespace _14_PrintTheASCIITable
{
    using System;

    internal class App
    {
        private static void Main()
        {
            for (var i = 33; i <= 126; i++)
            {
                Console.Write((char)i); // Not L10N
            }
            Console.WriteLine();
        }
    }
}