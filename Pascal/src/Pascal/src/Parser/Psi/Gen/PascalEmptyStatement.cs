using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalEmptyStatement : PascalAntlrCompositeElement<GPascalParser.EmptyStatementContext>
    {
        public PascalEmptyStatement(GPascalParser.EmptyStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.EmptyStatement;
    }
}