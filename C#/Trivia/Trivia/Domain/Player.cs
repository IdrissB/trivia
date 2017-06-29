using Trivia.Presentation;

namespace Trivia.Domain
{
    public class Player
    {
        private readonly IDispatchEvent _display;
        public string Name { get; private set; }

        public int Place { get; private set; }

        public int GoldCoins { get; private set; }

        public bool InPenaltyBox { get; set; }

        public Player(string name)
        {
            Name = name;
            Place = 0;
            GoldCoins = 0;
            InPenaltyBox = false;
            _display = new Display();
        }


        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }

        public void WinAGoldCoin()
        {
            GoldCoins++;
            _display.ConsoleDisplay(Name + " now has " + GoldCoins + " Gold Coins.");
        }

        public void GoToPenaltyBox()
        {
            InPenaltyBox = true;
        }

        public bool IsWinner()
        {
            return GoldCoins == 6;
        }
    }
}