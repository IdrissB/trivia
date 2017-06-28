using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Display : IDisplay
    {
        public void ConsoleDisplay(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
