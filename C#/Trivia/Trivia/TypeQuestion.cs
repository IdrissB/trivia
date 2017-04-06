using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class TypeQuestion
    {
        private string _nomType;
        private LinkedList<string> _questions = new LinkedList<string>();
        //public string TypeJeu { get; private set; }

        public TypeQuestion(string nom)
        {
            _nomType = nom;
        }

        public void CreateQuestion(int questionIndex)
        {
                _questions.AddLast(_nomType + "Question " + questionIndex);
        }

        public void AskAquestion()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}