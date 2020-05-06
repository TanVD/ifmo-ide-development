using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalWithStatement : PascalAntlrCompositeElement<GPascalParser.WithStatementContext>
    {
        public PascalWithStatement(GPascalParser.WithStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.WithStatement;
    }
}