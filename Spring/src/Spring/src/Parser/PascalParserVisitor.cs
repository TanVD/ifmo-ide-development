using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Plugins.Spring.Utils;
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

        public override PsiBuilder VisitVariableDeclaration(GPascalParser.VariableDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.VariableDeclaration);

            return _psiBuilder;
        }

        public override PsiBuilder VisitVariable(GPascalParser.VariableContext context)
        {
            VisitType(context, PascalNodeTypes.Variable);

            return _psiBuilder;
        }

        public override PsiBuilder VisitIdentifier(GPascalParser.IdentifierContext context)
        {
            VisitType(context, PascalNodeTypes.Identifier);

            return base.VisitIdentifier(context);
        }

        private void VisitType(RuleContext context, PascalAntlrNodeType type)
        {
            PLogger.Info($"Got in {type}");
            var mark = _psiBuilder.Mark();
            base.VisitChildren(context);
            _psiBuilder.Done(mark, type, context);
        }

        public override PsiBuilder VisitChildren(IRuleNode node)
        {
            base.VisitChildren(node);
            return _psiBuilder;
        }

        public override PsiBuilder VisitTerminal(ITerminalNode node)
        {
            //Restore whitespaces that ANTLR does not produce
            if (node.Symbol.TokenIndex != -1)
            {
                var toLoop = node.Symbol.TokenIndex - (_prev?.Symbol.TokenIndex ?? -1) - 1;
                while (toLoop > 0)
                {
                    if (!_psiBuilder.Eof()) _psiBuilder.AdvanceLexer();
                    toLoop--;
                }
            }

            if (!_psiBuilder.Eof()) _psiBuilder.AdvanceLexer();

            _prev = node;

            return _psiBuilder;
        }
    }
}