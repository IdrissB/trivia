using System.Collections;
using System.Collections.Generic;

namespace Trivia
{
    public class TypeQuestion
    {
        private string NomType;
        private LinkedList<string> questions = new LinkedList<string>();
        //public string TypeJeu { get; private set; }

        public TypeQuestion(string nomType)
        {
            NomType = nomType;
        }

        public void CreateQuestion(int questionIndex)
        {
                questions.AddLast(NomType + "Question " + questionIndex);
        }

    }
}