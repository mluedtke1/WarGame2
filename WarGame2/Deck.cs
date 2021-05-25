//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WarGame2
//{
//    class Deck
//    {
//        public void Deal(List<string> player, )
//        {

//            List<string> deck = new List<string>();
//            List<string> playerDeck = new List<string>();
//            List<string> CPUDeck = new List<string>();
//            var suit = "";
//            //var value = "";

//            for (var j = 1; j <= 4; j++)
//            {
//                switch (j)
//                {
//                    case 1: suit = "Hearts"; break;
//                    case 2: suit = "Spades"; break;
//                    case 3: suit = "Diamonds"; break;
//                    case 4: suit = "Clubs"; break;
//                }
//                for (var i = 1; i <= 13; i++)
//                {
//                    if (i > 1 && i <= 10)
//                    {
//                        deck.Add($"{Convert.ToString(i)} of {suit}");
//                    }
//                    else
//                    {
//                        switch (i)
//                        {
//                            case 11: deck.Add($"Jack of {suit}"); break;
//                            case 12: deck.Add($"Queen of {suit}"); break;
//                            case 13: deck.Add($"King of {suit}"); break;
//                            case 1: deck.Add($"Ace of {suit}"); break;
//                        }
//                    }
//                } //end value assign
//            } //end deck building
//            for (var i = 0; i < 52; i += 2)
//            {
//                Random rand = new Random();
//                int r = rand.Next(deck.Count);
//                playerDeck.Add(deck[r]);
//                deck.Remove(playerDeck[playerDeck.Count - 1]);
//            }
//        }
//    }
//}
