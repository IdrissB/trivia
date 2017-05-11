using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private readonly LinkedList<string> _questions = new LinkedList<string>();

        public QuestionsStack(string category)
        {
            _questions = GenerateQuestions(category);
        }

        public LinkedList<string> GenerateQuestions(string category)
        {
            LinkedList<string> generateQuestions = new LinkedList<string>();
            for (var i = 0; i < 50; i++)
            {
                _questions.AddLast(Category + " Question " + i);
            }
            return generateQuestions;
        }

        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}