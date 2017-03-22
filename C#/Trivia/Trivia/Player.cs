using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        private string name;
        private int place;
        private int purse;
        private bool inPenaltyBox;

        public Player(string name)
        {
            this.Name = name;
            place = 0;
            purse = 0;
            inPenaltyBox = false;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Place
        {
            get { return place; }
            set { place = value; }
        }

        public int Purse
        {
            get { return purse; }
            set { purse = value; }
        }

        public bool InPenaltyBox
        {
            get { return inPenaltyBox; }
            set { inPenaltyBox = value; }
        }
    }
}
