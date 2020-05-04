using System;
using Antlr4.Runtime;
using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.Text;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.SpringTests
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void Test1()
        {
            String text = @"  program a;
                            begin
                            end.";

            var normal =
                new GPascalParser(new CommonTokenStream(new GPascalLexer(new AntlrInputStream(text)))).program();
            var b = 2;
        }
    }
}