using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalIfStatement : PascalAntlrCompositeElement<GPascalParser.IfStatementContext>
    {
        public PascalIfStatement(GPascalParser.IfStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.IfStatement;
    }
}