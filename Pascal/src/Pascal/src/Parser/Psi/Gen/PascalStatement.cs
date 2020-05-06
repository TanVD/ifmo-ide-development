using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalStatement : PascalAntlrCompositeElement<GPascalParser.StatementContext>
    {
        public PascalStatement(GPascalParser.StatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Statement;
    }
}