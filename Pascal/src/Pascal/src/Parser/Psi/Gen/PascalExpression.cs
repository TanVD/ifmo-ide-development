using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalExpression : PascalAntlrCompositeElement<GPascalParser.ExpressionContext>
    {
        public PascalExpression(GPascalParser.ExpressionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Expression;
    }
}