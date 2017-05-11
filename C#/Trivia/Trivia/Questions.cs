using System;
using System.Collections.Generic;

namespace Trivia
{
    class Questions
    {
        private readonly Dictionary<int, TypeQuestion> _themeQuestions = new Dictionary<int, TypeQuestion> { { 0, new TypeQuestion("Pop ")}, { 1, new TypeQuestion("Science ")}, { 2,new TypeQuestion("Sports ")},
        { 3,new TypeQuestion("Rock ") } };


        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _themeQuestions[currentPlayerPlace % (_themeQuestions.Count)].NomType);
            _themeQuestions[currentPlayerPlace % (_themeQuestions.Count)].AskAquestion();
        }

        public void Generate()
        {
            for (int i = 0; i < 50; i++)
            {
                foreach (var variable in _themeQuestions)
                {
                    variable.Value.CreateQuestion(i);
                }
            }
        }

    }
}
