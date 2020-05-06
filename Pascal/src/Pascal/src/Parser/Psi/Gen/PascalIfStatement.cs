using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalIfStatement : PascalAntlrCompositeElement<GPascalParser.IfStatementContext>
    {
        public PascalIfStatement(GPascalParser.IfStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.IfStatement;
    }
}