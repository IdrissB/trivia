using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public interface IQuestionsRepository
    {
        LinkedList<string> GetQuestions(string category);
    }


}
