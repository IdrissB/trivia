using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {   
        private readonly Players _players;

        private readonly Questions _questions;
        
        bool _isGettingOutOfPenaltyBox;
        private readonly IDisplay _display;


        public Game(Players players, Questions questions, IDisplay display)
        {
            _players = players;
            _questions = questions;
            _display = display;
        }

        public void Roll(int roll)
        {
            _display.ConsoleDisplay(_players.Current.Name + " is the current player");
            _display.ConsoleDisplay("They have rolled a " + roll);

            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    _isGettingOutOfPenaltyBox = true;

                    _display.ConsoleDisplay(_players.Current.Name + " is getting out of the penalty box");
                    _players.Current.Move(roll);

                    _display.ConsoleDisplay(_players.Current.Name
                            + "'s new location is "
                            + _players.Current.Place);
                    _questions.AskQuestion(_players.Current.Place);
                }
                else
                {
                    _display.ConsoleDisplay(_players.Current.Name + " is not getting out of the penalty box");
                    _isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);

                _display.ConsoleDisplay(_players.Current.Name
                        + "'s new location is "
                        + _players.Current.Place);
                _questions.AskQuestion(_players.Current.Place);
            }

        }

        public bool WasCorrectlyAnswered()
        {
            bool winner;
            if (_players.Current.InPenaltyBox)
            {
                if (_isGettingOutOfPenaltyBox)
                {
                    _display.ConsoleDisplay("Answer was correct!!!!");
                    _players.Current.WinAGoldCoin();

                    winner = _players.Current.IsWinner();
                    _players.NextPlayer();

                    return winner;
                }

                _players.NextPlayer();
                return false;
            }

            _display.ConsoleDisplay("Answer was corrent!!!!");
            _players.Current.WinAGoldCoin();

            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            _display.ConsoleDisplay("Question was incorrectly answered");
            _display.ConsoleDisplay(_players.Current.Name + " was sent to the penalty box");
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }
}
