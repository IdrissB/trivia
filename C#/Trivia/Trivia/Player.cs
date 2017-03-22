using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        private string name;

        public Player(string name)
        {
            this.Name = name;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
