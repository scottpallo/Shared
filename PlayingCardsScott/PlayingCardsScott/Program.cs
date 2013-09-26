using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardsScott
{
    internal class Program   
    {
        private static void Main(string[] args)
        {
            Card[] cards = new Card[52];
            int index = 0;

            for (int i = 0; i < 4; i++)
            {
                Suits suit = (Suits) Enum.Parse(typeof (Suits), i.ToString());

                for (int j = 1; j <= 13; j++)
                {
                    Values value = (Values) Enum.Parse(typeof (Values), j.ToString());

                    cards[index] = new Card(suit, value);
                    index++;
                }
            }

            Random rng = new Random();
            int[] indexesUsed = new int[] {-1, -1, -1, -1, -1};
            Card[] hand = new Card[5];

            for (int i = 0; i < 5; i++)
            {
                bool isUnique = false;

                while (!isUnique)
                {
                    int cardToDraw = rng.Next(0, 52);
                    if (!indexesUsed.Contains(cardToDraw))
                    {
                        isUnique = true;
                        hand[i] = cards[cardToDraw];
                        indexesUsed[i] = cardToDraw;
                    }
                }             
            }

            foreach (Card c in hand)
            {
                Console.WriteLine(c.Name);
            }

            Console.ReadLine();
        }
    }
}



    

