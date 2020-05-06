using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalUnlabelledStatement : PascalAntlrCompositeElement<GPascalParser.UnlabelledStatementContext>
    {
        public PascalUnlabelledStatement(GPascalParser.UnlabelledStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnlabelledStatement;
    }
}