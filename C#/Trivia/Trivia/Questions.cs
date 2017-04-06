using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Questions
    {
        private readonly Dictionary<int, string> _themeQuestions = new Dictionary<int, string> { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };

        readonly TypeQuestion _popQuestions = new TypeQuestion("Pop");
        readonly TypeQuestion _scienceQuestions = new TypeQuestion("Science");
        readonly TypeQuestion _sportsQuestions = new TypeQuestion("Sport");
        readonly TypeQuestion _rockQuestions = new TypeQuestion("Rock");


        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + CurrentCategory(currentPlayerPlace));
            if (CurrentCategory(currentPlayerPlace) == "Pop")
            {
                _popQuestions.AskAquestion();
            }
            if (CurrentCategory(currentPlayerPlace) == "Science")
            {
                _scienceQuestions.AskAquestion();
            }
            if (CurrentCategory(currentPlayerPlace) == "Sports")
            {
                _sportsQuestions.AskAquestion();
            }
            if (CurrentCategory(currentPlayerPlace) == "Rock")
            {
                _rockQuestions.AskAquestion();
            }
        }

        private string CurrentCategory(int currentPlayerPlace)
        {
            return _themeQuestions[currentPlayerPlace % 4];
        }

        public void Generate()
        {
            for (int i = 0; i < 50; i++)
            {
                _popQuestions.CreateQuestion(i);
                _scienceQuestions.CreateQuestion(i);
                _sportsQuestions.CreateQuestion(i);
                _rockQuestions.CreateQuestion(i);
            }
        }

    }
}
