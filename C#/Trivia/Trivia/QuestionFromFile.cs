using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class QuestionFromFile : IQuestionsRepository
    {

        public LinkedList<string> GetQuestions(string category)
        {
            var questions = new LinkedList<string>();
            using (var fileStream = File.OpenRead(category))
            using (var streamReader = new StreamReader(fileStream))
            {
                while (streamReader.EndOfStream)
                {
                    questions.AddLast(streamReader.ReadLine());
                }
            }

            return questions;

        }
    }
}
