using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalAssignmentStatement : PascalAntlrCompositeElement<GPascalParser.AssignmentStatementContext>
    {
        public PascalAssignmentStatement(GPascalParser.AssignmentStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.AssignmentStatement;
    }
}