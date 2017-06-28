using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();
        private readonly IDisplay _display;

        public Questions(IEnumerable<string> categories, IQuestionsRepository questionsGenerator, IDisplay display)
        {
            _display = display;
            foreach (var category in categories)
            {
                var questionsStack = new QuestionsStack(category, questionsGenerator);
                _categories.Add(questionsStack);
            }
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            _display.ConsoleDisplay("The category is " + _categories[currentPlayerPlace % _categories.Count].Category);
            _categories[currentPlayerPlace % _categories.Count].AskQuestionAndDiscard();
        }
    }
}