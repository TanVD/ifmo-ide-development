using System.IO;
using Antlr4.Runtime;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
{
    public class PascalParser : IParser
    {
        private readonly ILexer _lexer;

        public PascalParser(ILexer lexer)
        {
            _lexer = lexer;
        }

        public IFile ParseFile()
        {
            using (var def = Lifetime.Define())
            {
                var builder = new PsiBuilder(_lexer, SpringFileNodeType.Instance, new TokenFactory(), def.Lifetime);
                var listener = new PascalErrorListener(builder);

                var lexer = new GPascalLexer(new AntlrInputStream(_lexer.Buffer.GetText()));
                var parser = new GPascalParser(new CommonTokenStream(lexer));
                parser.AddErrorListener(listener);

                var fileMark = builder.Mark();

                new PascalParserVisitor(builder).Visit(parser.program());

                builder.Done(fileMark, SpringFileNodeType.Instance, null);
                var file = (IFile) builder.BuildTree();
                return file;
            }
        }

        class PascalErrorListener : BaseErrorListener
        {
            private readonly PsiBuilder _builder;

            public PascalErrorListener(PsiBuilder builder)
            {
                _builder = builder;
            }

            public override void SyntaxError(
                TextWriter output, IRecognizer recognizer, IToken offendingSymbol,
                int line, int charPositionInLine, string msg, RecognitionException e
            )
            {
                var curLexeme = _builder.GetCurrentLexeme();
                var curNonCommentLexeme = _builder.GetCurrentNonCommentLexeme();
                
                Logger.Log($"OFFENDING SYMBOL: {offendingSymbol.StartIndex} {offendingSymbol.StopIndex}");

                _builder.ResetCurrentLexeme(offendingSymbol.TokenIndex, offendingSymbol.TokenIndex);
                var mark = _builder.Mark();
                
                //TODO-tanvd need better solution to forward length 
                _builder.Error(mark, msg + $"#{offendingSymbol.StopIndex - offendingSymbol.StartIndex + 1}");

                _builder.ResetCurrentLexeme(curLexeme, curNonCommentLexeme);
            }
        }
    }
}