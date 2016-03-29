namespace _09_PrintSequence
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var currentNum = 2;
            for (var i = 0; i < 10; i++, currentNum++)
            {
                var output = (i%2 == 0 ? currentNum : currentNum*-1);
                Console.WriteLine(output);
            }
        }
    }
}