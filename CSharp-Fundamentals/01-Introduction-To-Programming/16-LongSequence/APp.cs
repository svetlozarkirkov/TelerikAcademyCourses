namespace _16_LongSequence
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var currentNum = 2;
            for (var i = 0; i < 1000; i++, currentNum++)
            {
                Console.WriteLine(i % 2 == 0 ? currentNum : currentNum*-1);
            }
        }
    }
}