using Antlr4.Runtime;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
{
    internal class PascalParser : IParser
    {
        private readonly ILexer _myLexer;
        private readonly GPascalParser _myParser;

        public PascalParser(ILexer lexer)
        {
            _myLexer = lexer;
            _myParser = new GPascalParser(new CommonTokenStream(((PascalLexer) lexer).Lexer));
        }

        public IFile ParseFile()
        {
            using (var def = Lifetime.Define())
            {
                var builder = new PsiBuilder(_myLexer, SpringFileNodeType.Instance, new TokenFactory(), def.Lifetime);
                var fileMark = builder.Mark();

                ParseBlock(builder);

                builder.Done(fileMark, SpringFileNodeType.Instance, null);
                var file = (IFile) builder.BuildTree();
                return file;
            }
        }

        private void ParseBlock(PsiBuilder builder)
        {
            while (!builder.Eof())
            {
                var tt = builder.GetTokenType();
                if (tt == PascalTokenTypes.BEGIN)
                {
                    var start = builder.Mark();
                    builder.AdvanceLexer();
                    ParseBlock(builder);

                    if (builder.GetTokenType() != PascalTokenTypes.END)
                        builder.Error("Expected 'END'");
                    else
                        builder.AdvanceLexer();

                    builder.Done(start, SpringCompositeNodeType.BLOCK, null);
                }
                else if (tt == PascalTokenTypes.END)
                    return;
                else builder.AdvanceLexer();
            }
        }
    }
}