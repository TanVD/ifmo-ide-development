using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalCaseStatement : PascalAntlrCompositeElement<GPascalParser.CaseStatementContext>
    {
        public PascalCaseStatement(GPascalParser.CaseStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.CaseStatement;
    }
}