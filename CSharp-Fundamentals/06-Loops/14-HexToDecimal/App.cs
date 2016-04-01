namespace _14_HexToDecimal
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var hexString = Console.ReadLine();
            long result = 0;

            for (int i = 0, k = hexString.Length - 1; i < hexString.Length; i++, k--)
            {
                var j = 0;

                switch (hexString[i])
                {
                    case 'A':
                        j = 10;
                        break;
                    case 'B':
                        j = 11;
                        break;
                    case 'C':
                        j = 12;
                        break;
                    case 'D':
                        j = 13;
                        break;
                    case 'E':
                        j = 14;
                        break;
                    case 'F':
                        j = 15;
                        break;
                    default:
                        j = Convert.ToInt32(hexString[i].ToString());
                        break;
                }

                result += (long)(j * Math.Pow(16, k));
            }

            Console.WriteLine(result);
        }
    }
}