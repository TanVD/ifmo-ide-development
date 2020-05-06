using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node;
using JetBrains.ReSharper.Plugins.Pascal.Utils;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser
{
    public abstract class PascalBaseParserVisitor : GPascalBaseVisitor<object>
    {
        private readonly PsiBuilder _psiBuilder;
        private ITerminalNode _prev;

        private bool _withLogging = false;
        private string _tabs = "";

        protected PascalBaseParserVisitor(PsiBuilder psiBuilder)
        {
            _psiBuilder = psiBuilder;
        }

        protected void VisitType(RuleContext context, PascalAntlrNodeType type)
        {
            if (_withLogging)
            {
                _tabs = _tabs + "\t";
                PLogger.Info($"{_tabs}{type}");
            }

            var mark = _psiBuilder.Mark();
            base.VisitChildren(context);
            _psiBuilder.Done(mark, type, context);

            if (_withLogging)
            {
                PLogger.Info($"{_tabs}{type}");
                _tabs = _tabs.Substring(0, _tabs.Length - 1);
            }
        }

        public override object VisitTerminal(ITerminalNode node)
        {
            if (_withLogging)
            {
                _tabs = _tabs + "\t";
                PLogger.Info($"{_tabs}{PascalTokenTypes.Convert(node.Symbol.Type)}");
                _tabs = _tabs.Substring(0, _tabs.Length - 1);
            }

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

            return null;
        }
    }
}