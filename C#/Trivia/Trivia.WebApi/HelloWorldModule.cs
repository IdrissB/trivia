using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Conventions;

namespace Trivia.WebApi
{
    public class HelloWorldModule :  Nancy.NancyModule
    {
        public HelloWorldModule()
        {
            Get["/"] = _ => "Hello World";
        }
    }
}
