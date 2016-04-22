using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            List<string> cards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var cardIndex = cards.IndexOf(card);
            for (int ind = 0; ind <= cardIndex; ind++)
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[ind]);
        }
    }
}
