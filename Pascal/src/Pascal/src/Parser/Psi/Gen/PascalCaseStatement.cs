using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalCaseStatement : PascalAntlrCompositeElement<GPascalParser.CaseStatementContext>
    {
        public PascalCaseStatement(GPascalParser.CaseStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.CaseStatement;
    }
}