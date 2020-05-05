using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSimpleExpression : PascalAntlrCompositeElement<GPascalParser.SimpleExpressionContext>
    {
        public PascalSimpleExpression(GPascalParser.SimpleExpressionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SimpleExpression;
    }
}