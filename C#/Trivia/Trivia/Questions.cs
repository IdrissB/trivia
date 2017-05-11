using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();

        public Questions() : this(new [] { "Pop", "Science", "Sports", "Rock" }, new QuestionsGenerator())
        {
        }

        public Questions(IEnumerable<string> categories, IQuestionsRepository questionsGenerator)
        {
            foreach (var category in categories)
            {
                var questionsStack = new QuestionsStack(category, questionsGenerator);
                _categories.Add(questionsStack);
            }
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _categories[currentPlayerPlace % _categories.Count].Category);
            _categories[currentPlayerPlace % _categories.Count].AskQuestionAndDiscard();
        }
    }
}