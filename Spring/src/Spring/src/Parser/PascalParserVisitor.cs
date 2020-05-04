using Antlr4.Runtime.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
{
    public class PascalParserVisitor : GPascalBaseVisitor<PsiBuilder>
    {
        private readonly PsiBuilder _psiBuilder;
        private ITerminalNode _prev;

        public PascalParserVisitor(PsiBuilder psiBuilder)
        {
            _psiBuilder = psiBuilder;
        }

        public override PsiBuilder VisitChildren(IRuleNode node)
        {
            var mark = _psiBuilder.Mark();
            base.VisitChildren(node);
            _psiBuilder.Done(mark, PascalCompositeNodeType.OTHER, null);
            return _psiBuilder;
        }

        public override PsiBuilder VisitTerminal(ITerminalNode node)
        {
            //Restore whitespaces that ANTLR does not produce
            if (_prev != null && node.Symbol.TokenIndex != -1)
            {
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
    }
}