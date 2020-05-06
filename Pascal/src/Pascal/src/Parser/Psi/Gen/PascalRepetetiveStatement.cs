using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalRepetetiveStatement : PascalAntlrCompositeElement<GPascalParser.RepetetiveStatementContext>
    {
        public PascalRepetetiveStatement(GPascalParser.RepetetiveStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RepetetiveStatement;
    }
}