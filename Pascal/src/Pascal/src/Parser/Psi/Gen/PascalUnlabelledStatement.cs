using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUnlabelledStatement : PascalAntlrCompositeElement<GPascalParser.UnlabelledStatementContext>
    {
        public PascalUnlabelledStatement(GPascalParser.UnlabelledStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnlabelledStatement;
    }
}