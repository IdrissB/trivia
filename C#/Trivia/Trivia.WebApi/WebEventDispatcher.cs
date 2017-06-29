using System;
using System.Xml;
using Trivia.Domain;
using Trivia.Presentation;

namespace Trivia.WebApi
{
    internal class WebEventDispatcher : IDispatchEvent
    {

        public void ConsoleDisplay(string txt)
        {
            Output += txt + "\n";
        }

        public void Dispatch<TEvent>(TEvent e)
        {
            if (e is PlayerRolledDice)
            {
                Output = (e as PlayerRolledDice)._playerName + " is the current player";
                Output ="They have rolled a " + (e as PlayerRolledDice)._roll + "\n";
            }
            else if (e is PlayerGettingOutOfJail)
            {
                Output =(e as PlayerGettingOutOfJail)._playerName + " is getting out of the penalty box";
            }
            else if (e is PlayerNotGettingOut)
            {
                Output =(e as PlayerNotGettingOut)._playerName + " is not getting out of the penalty box";
            }
            else if (e is PlayerAnswerCorrect)
            {
                Output ="Answer was correct!!!!";
            }
        }

        public object Output { get; set; }

        public void Flush()
        {
            Output = String.Empty;
        }
    }
}