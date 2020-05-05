using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalRepetetiveStatement : PascalAntlrCompositeElement<GPascalParser.RepetetiveStatementContext>
    {
        public PascalRepetetiveStatement(GPascalParser.RepetetiveStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RepetetiveStatement;
    }
}