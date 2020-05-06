using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalAssignmentStatement : PascalAntlrCompositeElement<GPascalParser.AssignmentStatementContext>
    {
        public PascalAssignmentStatement(GPascalParser.AssignmentStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.AssignmentStatement;
    }
}