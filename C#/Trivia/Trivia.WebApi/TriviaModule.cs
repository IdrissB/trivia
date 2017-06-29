using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Trivia.Presentation;

namespace Trivia.WebApi
{
    public class TriviaModule : NancyModule
    {
        private static Game _game;
        private static WebEventDispatcher _eventDispatcher;

        public TriviaModule()
        {
            Post["/startGame"] = StartGame;
            Post["/rollDice"] = RollDice;
        }

        private dynamic RollDice(dynamic arg)
        {
            _eventDispatcher.Flush();
            var random = new Random();
            _game.Roll(random.Next(5) + 1);
            return _eventDispatcher.Output;
        }

        private dynamic StartGame(dynamic o)
        {
            _eventDispatcher = new WebEventDispatcher();
            var players = new Players(_eventDispatcher);
            players.Add("Chet");
            players.Add("Pat");
            players.Add("Sue");

            var categories = new[] { "Pop", "Science", "Sports", "Rock" };
            _game = new Game(players, new Questions(categories, new QuestionsGenerator(), _eventDispatcher), _eventDispatcher);

            return _eventDispatcher.Output;
        }
    }
}
