using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalWithStatement : PascalAntlrCompositeElement<GPascalParser.WithStatementContext>
    {
        public PascalWithStatement(GPascalParser.WithStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.WithStatement;
    }
}