using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalForStatement : PascalAntlrCompositeElement<GPascalParser.ForStatementContext>
    {
        public PascalForStatement(GPascalParser.ForStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ForStatement;
    }
}