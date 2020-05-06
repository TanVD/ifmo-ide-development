using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalWhileStatement : PascalAntlrCompositeElement<GPascalParser.WhileStatementContext>
    {
        public PascalWhileStatement(GPascalParser.WhileStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.WhileStatement;
    }
}