using System;
using Trivia.Domain;

namespace Trivia.Presentation
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
            else if( e is PlayerGettingOutOfJail)
            {
                Console.WriteLine((e as PlayerGettingOutOfJail)._playerName + " is getting out of the penalty box");
            }
            else if (e is PlayerNotGettingOut)
            {
                Console.WriteLine((e as PlayerNotGettingOut)._playerName + " is not getting out of the penalty box");
            }
            else if (e is PlayerAnswerCorrect)
            {
                Console.WriteLine("Answer was correct!!!!");
            }

        }
    }
}
