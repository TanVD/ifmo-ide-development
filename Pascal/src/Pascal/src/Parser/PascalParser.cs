using System.IO;
using Antlr4.Runtime;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Ide;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser
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
                var builder = new PsiBuilder(new PascalLexer(_lexer.Buffer), PascalNodeTypes.File, new TokenFactory(), def.Lifetime);

                var parser = new GPascalParser(new CommonTokenStream(new GPascalLexer(new AntlrInputStream(new BufferTextReader(_lexer.Buffer)))));
                parser.AddErrorListener(new PascalErrorListener(builder));

                var fileMark = builder.Mark();
                new PascalParserVisitor(builder).Visit(parser.program());
                builder.Done(fileMark, PascalNodeTypes.File, null);

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

                _builder.ResetCurrentLexeme(offendingSymbol.TokenIndex, offendingSymbol.TokenIndex);

                var mark = _builder.Mark();
                var length = offendingSymbol.StopIndex - offendingSymbol.StartIndex + 1;
                _builder.Done(mark, PascalNodeTypes.Error, new PascalErrorNodeType.Message(msg, length));

                _builder.ResetCurrentLexeme(curLexeme, curNonCommentLexeme);
            }
        }
    }
}