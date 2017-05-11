using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private readonly LinkedList<string> _questions;

        public QuestionsStack(string category, IQuestionsRepository questionsGenerator)
        {
            Category = category;
            _questions = questionsGenerator.GetQuestions(category);
        }

       

        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}