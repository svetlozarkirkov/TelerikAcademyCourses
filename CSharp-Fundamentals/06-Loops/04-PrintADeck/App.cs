namespace _04_PrintADeck
{
    using System;

    internal class App
    {
        private static void Main()
        {
            string[] cardFaces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] cardSuits = {"spades", "clubs", "hearts", "diamonds"};
            var inputFace = Console.ReadLine();
            var currentCardFaceIndex = 0;
            while (true)
            {
                for (var cardSuitIndex = 0; cardSuitIndex < 4; cardSuitIndex++)
                {
                    Console.Write("{0} of {1}", cardFaces[currentCardFaceIndex], cardSuits[cardSuitIndex]);

                    if (cardSuitIndex != 3)
                    {
                        Console.Write(", ");
                    }
                }

                if (cardFaces[currentCardFaceIndex].Equals(inputFace))
                {
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine();
                currentCardFaceIndex++;
            }
        }
    }
}