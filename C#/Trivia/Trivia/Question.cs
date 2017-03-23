using System.Collections;
using System.Collections.Generic;

namespace Trivia
{
    public class Question
    {
        public string Type { get; private set; }
        public List<string> Questions { get; private set; }

        public Question(string type, List<string> questions)
        {
            Type = type;
            Questions = questions;
                
        }

        public string CreateQuestion(string type, int i)
        {
            return type + " question " + i;
        }
    }
}