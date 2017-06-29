using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class PlayerRolledDice
    {
        public string _playerName { get; set; }

        public int _roll { get; set; }

        public PlayerRolledDice(string playerName, int roll)
        {
            _playerName = playerName;
            _roll = roll;
        }
    }
}
