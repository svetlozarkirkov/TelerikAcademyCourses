namespace _11_ThirdBit
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var number = uint.Parse(Console.ReadLine());
            var thirdBit = (number >> 3) & 1;
            Console.WriteLine(thirdBit);
        }
    }
}