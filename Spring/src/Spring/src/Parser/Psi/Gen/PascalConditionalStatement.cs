using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalConditionalStatement : PascalAntlrCompositeElement<GPascalParser.ConditionalStatementContext>
    {
        public PascalConditionalStatement(GPascalParser.ConditionalStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConditionalStatement;
    }
}