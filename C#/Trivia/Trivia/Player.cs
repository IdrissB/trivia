﻿using System;

namespace Trivia
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Place = 0;
            GoldCoins = 0;
            InPenaltyBox = false;
        }

        public string Name { get; set; }

        public int Place { get; set; }

        public int GoldCoins { get; set; }

        public bool InPenaltyBox { get; set; }

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }

        public void WinAGoldCoin()
        {
            GoldCoins++;
            Console.WriteLine(Name+ " now has "+ GoldCoins + " Gold Coins.");
        }

        public void GoToPenaltyBox()
        {
            InPenaltyBox = true;
        }

        public bool IsWinner()
        {
            return  GoldCoins == 6;
        }
    }
}
