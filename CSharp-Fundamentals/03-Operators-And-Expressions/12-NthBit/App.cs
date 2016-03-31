namespace _12_NthBit
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var number = uint.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());
            var bitAtPosition = (number >> position) & 1;
            Console.WriteLine(bitAtPosition);
        }
    }
}