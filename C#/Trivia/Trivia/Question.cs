using System;
using System.Collections;
using System.Collections.Generic;

namespace Trivia
{
    public class Question
    {
        public string QuestionPose { get; private set; }
        public string Reponse { get; private set; }

        public Question(string questionPose, string reponse)
        {
            QuestionPose = questionPose;
            Reponse = reponse;
        }



        public override string ToString()
        {
            return "La question est la suivante " + QuestionPose;
        }
    }
}
