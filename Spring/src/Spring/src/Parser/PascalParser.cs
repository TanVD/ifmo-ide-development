using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
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

                var lexer = new GPascalLexer(new AntlrInputStream(_lexer.Buffer.GetText()));
                var parser = new GPascalParser(new CommonTokenStream(lexer));

                var fileMark = builder.Mark();

                new PascalParserVisitor(builder).Visit(parser.program());

                builder.Done(fileMark, SpringFileNodeType.Instance, null);
                var file = (IFile) builder.BuildTree();
                return file;
            }
        }

        private class PascalParserVisitor : GPascalBaseVisitor<PsiBuilder>
        {
            private readonly PsiBuilder _psiBuilder;
            private ITerminalNode _prev;

            public PascalParserVisitor(PsiBuilder psiBuilder)
            {
                _psiBuilder = psiBuilder;
            }

            public override PsiBuilder VisitChildren(IRuleNode node)
            {
                Logger.Log($"Got in a node {node.GetText()}");
                var mark = _psiBuilder.Mark();
                base.VisitChildren(node);
                _psiBuilder.Done(mark, SpringCompositeNodeType.OTHER, null);
                return _psiBuilder;
            }

            public override PsiBuilder VisitTerminal(ITerminalNode node)
            {
                if (_prev != null && node.Symbol.TokenIndex != -1)
                {
                    Logger.Log($"PREV SYMBOL: {_prev.Symbol.TokenIndex}");
                    Logger.Log($"NODE SYMBOL: {node.Symbol.TokenIndex}");

                    var toLoop = node.Symbol.TokenIndex - _prev.Symbol.TokenIndex - 1;
                    while (toLoop > 0)
                    {
                        _psiBuilder.AdvanceLexer();
                        toLoop--;
                    }
                }

                _psiBuilder.AdvanceLexer();
                _prev = node;

                return _psiBuilder;
            }

            public override PsiBuilder VisitErrorNode(IErrorNode node)
            {
                Logger.Log($"SYMBOL: {node.Symbol.TokenIndex}");
                var mark = _psiBuilder.Mark();

                _psiBuilder.Error(mark, node.GetText());

                return _psiBuilder;
            }
        }
    }
}