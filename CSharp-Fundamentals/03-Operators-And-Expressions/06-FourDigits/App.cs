namespace _06_FourDigits
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var inputNumString = Console.ReadLine();

            Console.WriteLine(inputNumString.Sum(digit => int.Parse(digit.ToString())));
            Console.WriteLine(ReverseString(inputNumString));
            Console.WriteLine((inputNumString.Substring(3,1) + inputNumString.Substring(0,3)));
            Console.WriteLine((string.Format("{0}{1}{2}{3}",
                inputNumString[0],
                inputNumString[2],
                inputNumString[1],
                inputNumString[3])));
        }

        private static string ReverseString(string inputString)
        {
            if (inputString == null) return null;
            var charArray = inputString.ToCharArray();
            var len = inputString.Length - 1;

            for (var i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray);
        }
    }
}