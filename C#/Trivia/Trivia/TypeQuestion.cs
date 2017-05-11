using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class TypeQuestion
    {
        public string NomType { get; private set; }
        private readonly LinkedList<string> _questions = new LinkedList<string>();
        //public string TypeJeu { get; private set; }

        public TypeQuestion(string nom)
        {
            NomType = nom;
        }

        public void CreateQuestion(int questionIndex)
        {
                _questions.AddLast(NomType + "Question " + questionIndex);
        }

        public void AskAquestion()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}