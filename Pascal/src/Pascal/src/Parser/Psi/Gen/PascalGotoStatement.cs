using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalGotoStatement : PascalAntlrCompositeElement<GPascalParser.GotoStatementContext>
    {
        public PascalGotoStatement(GPascalParser.GotoStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.GotoStatement;
    }
}