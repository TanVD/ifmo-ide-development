using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalSimpleExpression : PascalAntlrCompositeElement<GPascalParser.SimpleExpressionContext>
    {
        public PascalSimpleExpression(GPascalParser.SimpleExpressionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SimpleExpression;
    }
}