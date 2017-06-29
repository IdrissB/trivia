using System.Collections.Generic;

namespace Trivia
{
    public class QuestionsGenerator : IQuestionsRepository
    {
        public LinkedList<string> GetQuestions(string category)
        {
            LinkedList<string> questions = new LinkedList<string>();
            for (var i = 0; i < 50; i++)
            {
                questions.AddLast(category + " Question " + i);
            }
            return questions;
        }
    }
}
