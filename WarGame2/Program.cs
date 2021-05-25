using System;
using System.Collections.Generic;

namespace WarGame2
{
    class Program
    {
        static void Main()
        {
            List<string> deck = new List<string>();
            List<string> playerDeck = new List<string>();
            List<string> CPUDeck = new List<string>();
            var suit = "";
            var round = 0;
            var winner = "";
            //var value = "";

            for (var j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1: suit = "Hearts"; break;
                    case 2: suit = "Spades"; break;
                    case 3: suit = "Diamonds"; break;
                    case 4: suit = "Clubs"; break;
                }
                for (var i = 1; i <= 13; i++)
                {
                    if (i > 1 && i <= 10)
                    {
                        deck.Add($"{Convert.ToString(i)} of {suit}");
                    }
                    else
                    {
                        switch (i)
                        {
                            case 11: deck.Add($"Jack of {suit}"); break;
                            case 12: deck.Add($"Queen of {suit}"); break;
                            case 13: deck.Add($"King of {suit}"); break;
                            case 1: deck.Add($"Ace of {suit}"); break;
                        }
                    }
                } //end value assign
            } //end deck building
            for (var i = 0; i < 52; i += 2)
            {
                Random rand = new Random();
                int r = rand.Next(deck.Count);
                playerDeck.Add(deck[r]);
                deck.Remove(playerDeck[playerDeck.Count - 1]);
            }
            foreach (var j in deck)
            {
                CPUDeck.Add(j);
                //deck.Remove(j);
            }


            //deck.ForEach(i => Console.WriteLine("{0}", i));
            //Console.WriteLine("player");
            //playerDeck.ForEach(i => Console.WriteLine("{0}", i));



            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, press any key to start");
            Console.ReadKey();

            while(playerDeck.Count > 0 && CPUDeck.Count > 0)
            {
                Random rand = new Random();
                
                int r = rand.Next(playerDeck.Count);
                string card = playerDeck[r];
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{name}: {card}");
                

                r = rand.Next(CPUDeck.Count);
                string card2 = CPUDeck[r];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"CPU: {card2}");

                int playerPoint = Point(card);
                int CPUPoint = Point(card2);

                if(playerPoint == 1 && CPUPoint == 13)
                {
                    playerDeck.Add(card2);
                    CPUDeck.Remove(card2);
                }
                else if (playerPoint == 13 && CPUPoint == 1)
                {
                    CPUDeck.Add(card);
                    playerDeck.Remove(card);
                }
                else if (playerPoint > CPUPoint)
                {
                    playerDeck.Add(card2);
                    CPUDeck.Remove(card2);

                }
                else if (CPUPoint > playerPoint)
                {
                    CPUDeck.Add(card);
                    playerDeck.Remove(card);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Cards left for {name}: {playerDeck.Count}  -  CPU: {CPUDeck.Count}");
                Console.WriteLine();
                round++;
                Console.ReadKey();
            }
            if(playerDeck.Count == 0)
            {
                winner = "CPU";
            }
            else
            {
                winner = name;
            }
            Console.WriteLine("");
            Console.WriteLine($"Winner is {winner}");
            Console.WriteLine($"{round} total rounds played");
            Console.WriteLine("");
            Console.WriteLine("Press any key to play again");
            Console.ReadKey();
            Main();
            
        }
        public static int Point(string card)
        {
            int point =0;
            string[] split = card.Split(' ');
            if (split[0] == "Jack" || split [0] == "Queen" || split[0] == "King" || split[0] == "Ace" )
            {
                switch (split[0])
                {
                    case "Jack": point = 11; break;
                    case "Queen": point = 12; break;
                    case "King": point = 13; break;
                    case "Ace": point = 1; break;
                }
            }
            else
            {
                point = Int32.Parse(split[0]);
            }
            return point;

        }
        //static void Draw(List<string> deck)
        //    {
        //        Random rand = new Random();
        //        int r = rand.Next(deck.Count);
        //        string card = deck[r];
        //        Console.WriteLine(card);
        //        deck.Remove(card);
        //    }
    }
}
