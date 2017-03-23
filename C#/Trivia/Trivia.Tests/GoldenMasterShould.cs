using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace Trivia.Tests
{
    [TestFixture]
    public class GoldenMasterShould
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void NotChange()
        {
            var stringWriter = new StringWriter();
            var previousConsoleOut = Console.Out;
            Console.SetOut(stringWriter);
            GameRunner.Main(null);
            Console.SetOut(previousConsoleOut);
            Approvals.Verify(stringWriter.ToString());
        }
    }
}
