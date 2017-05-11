using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class QuestionFromFile : IQuestionsRepository
    {

        public LinkedList<string> GetQuestions(string category)
        {
            // Read the file as one string.
            System.IO.StreamReader myFile =
            new System.IO.StreamReader("c:\\test.txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

        }
    }
}
