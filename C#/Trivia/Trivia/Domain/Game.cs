using System;
using System.Collections.Generic;
using System.Linq;
using Trivia.Domain;

namespace Trivia
{
    public class Game
    {   
        private readonly Players _players;

        private readonly Questions _questions;
        
        bool _isGettingOutOfPenaltyBox;
        private readonly IDispatchEvent _dispatch;


        public Game(Players players, Questions questions, IDispatchEvent dispatch)
        {
            _players = players;
            _questions = questions;
            _dispatch = dispatch;
        }


        public void Roll(int roll)
        {
            _dispatch.Dispatch(new PlayerRolledDice(_players.Current.Name, roll));

            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    _isGettingOutOfPenaltyBox = true;

                    _dispatch.Dispatch(new PlayerGettingOutOfJail(_players.Current.Name));
                    _players.Current.Move(roll);

                    _dispatch.ConsoleDisplay(_players.Current.Name
                            + "'s new location is "
                            + _players.Current.Place);
                    _questions.AskQuestion(_players.Current.Place);
                }
                else
                {
                    _dispatch.Dispatch(new PlayerNotGettingOut(_players.Current.Name));
                    _isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);

                _dispatch.ConsoleDisplay(_players.Current.Name
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
                    _dispatch.Dispatch(new PlayerAnswerCorrect());
                    _players.Current.WinAGoldCoin();

                    winner = _players.Current.IsWinner();
                    _players.NextPlayer();

                    return winner;
                }

                _players.NextPlayer();
                return false;
            }

            _dispatch.Dispatch(new PlayerAnswerCorrect());
            _players.Current.WinAGoldCoin();

            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            _dispatch.ConsoleDisplay("Question was incorrectly answered");
            _dispatch.ConsoleDisplay(_players.Current.Name + " was sent to the penalty box");
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }
}
