using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        public Player(string name)
        {
            this.Name = name;
            Place = 0;
            Purse = 0;
            InPenaltyBox = false;
        }

        public string Name { get; set; }

        public int Place { get; set; }

        public int Purse { get; set; }

        public bool InPenaltyBox { get; set; }

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }
    }
}
