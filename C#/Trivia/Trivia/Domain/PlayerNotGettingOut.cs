using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Domain
{
    public class PlayerNotGettingOut
    {
        public string _playerName { get; set; }

        public PlayerNotGettingOut(string playerName)
        {
            _playerName = playerName;
        }
    }
}
