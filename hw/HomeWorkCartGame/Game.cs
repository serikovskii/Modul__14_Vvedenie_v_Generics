using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCartGame
{
    public class Game
    {
        public List<Card> DeckOfCards { get; set; }
        public List<Player> Players { get; set; }
        
        public Game(int countPlayer)
        {
            DeckOfCards = new List<Card>();
            Players = new List<Player>();
            Сroupier(countPlayer);
        }

        public void Сroupier(int countPlayer)
        {
            int rankCard = 1;
            foreach (var type in new[] { "шестерка", "семерка", "восмерка", "девятка", "десятка", "валет", "дама", "король", "туз" })
            {
                foreach (var suit in new[] { "черви", "бубни", "крести", "пики" })
                {
                    DeckOfCards.Add(new Card { Rank = rankCard, Type = type, Suit = suit});
                }
                rankCard++;
            }

            var rand = new Random();
            for(int i = 0; i < DeckOfCards.Count; i++)
            {
                var tmp = DeckOfCards[i];
                DeckOfCards.RemoveAt(i);
                DeckOfCards.Insert(rand.Next(DeckOfCards.Count), tmp);
            }
            
            int countCardForPlayer = /*Koloda.Count / countPlayer*/2;  // для теста поставил число 2  
            for (int j = 0; j < countPlayer; j++)
            {
                Players.Add(new Player());
                for (int i = 0; i < countCardForPlayer; i++)
                {
                    Players[j].Import.Add(DeckOfCards.First());
                    DeckOfCards.Remove(DeckOfCards.First());
                }
            }
        }

        public void StartGame(int countPlayer)
        {
            int countPlayerTmp = countPlayer;
            int countPlayerOut = 0;
            bool takeCard = true;
            int howMuchRank;
            var CardOnTheTable = new List<Card>();
            while (countPlayerTmp != 1)
            {
                for (int i = 0; i < countPlayer; i++)
                {
                    if (Players[i].Import.Count != 0)
                    {
                        Players[i].Export.Add(Players[i].Import.First());
                        CardOnTheTable.Add(Players[i].Export.Last());
                        Console.WriteLine($"Игрок {i + 1} положил карту {Players[i].Export.Last().Type} - {Players[i].Export.Last().Suit}");
                    }
                }

                howMuchRank = CardOnTheTable.Max(r => r.Rank);
                countPlayerTmp -= countPlayerOut;
                countPlayerOut = 0;
                for (int i = 0; i < countPlayer; i++)
                {
                    if (countPlayerTmp == 1 && Players[i].Import.Count != 0)
                    {
                        Console.WriteLine($"Победитель игрок {i + 1}");
                        break;
                    }
                    if (Players[i].Import.Count != 0)
                    {
                        if (Players[i].Export.Last().Rank == howMuchRank && takeCard)
                        {
                            Players[i].Import.Remove(Players[i].Import.First());
                            for (int j = 0; j < countPlayerTmp; j++)
                            {
                                Players[i].Import.Add(CardOnTheTable.Last());
                                CardOnTheTable.Remove(CardOnTheTable.Last());
                            }
                            takeCard = false;
                        }
                        else
                        {
                            Players[i].Import.Remove(Players[i].Import.First());
                            Players[i].Export.Remove(Players[i].Export.Last());
                            if (Players[i].Import.Count == 0)
                            {
                                countPlayerOut++;
                                Console.WriteLine($"Игрок {i + 1} покинул игру");
                            }
                        }
                    }
                    Console.WriteLine($"Игрок {i + 1} - карт {Players[i].Import.Count}");
                }
                takeCard = true;
            }
        }
    }
}
