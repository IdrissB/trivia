using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Display : IDispatchEvent
    {
        public void ConsoleDisplay(string txt)
        {
            Console.WriteLine(txt);
        }

        public void Dispatch<TEvent>(TEvent e)
        {
            if (e is PlayerRolledDice)
            {
                Console.WriteLine((e as PlayerRolledDice)._playerName + " is the current player");
                Console.WriteLine("They have rolled a " + (e as PlayerRolledDice)._roll);
            }
        }
    }
}
