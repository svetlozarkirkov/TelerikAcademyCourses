namespace _05_ThirdDigit
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var thirdDigit = (inputNumber/100).ToString().Last();
            var isSeven = thirdDigit == '7';
            if (isSeven)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}