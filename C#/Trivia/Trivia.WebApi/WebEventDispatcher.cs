using System;
using System.Xml;
using Trivia.Domain;
using Trivia.Presentation;

namespace Trivia.WebApi
{
    internal class WebEventDispatcher : IDispatchEvent
    {
        public object Flush { get; set; }

        public void ConsoleDisplay(string txt)
        {
            Output += txt + "\n";
        }

        public void Dispatch<TEvent>(TEvent e)
        {
            if (e is PlayerRolledDice)
            {
                Console.WriteLine((e as PlayerRolledDice)._playerName + " is the current player");
                Console.WriteLine("They have rolled a " + (e as PlayerRolledDice)._roll);
            }
            else if (e is PlayerGettingOutOfJail)
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

        public object Output { get; set; }
    }
}