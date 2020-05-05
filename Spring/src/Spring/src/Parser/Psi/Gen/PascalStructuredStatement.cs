using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalStructuredStatement : PascalAntlrCompositeElement<GPascalParser.StructuredStatementContext>
    {
        public PascalStructuredStatement(GPascalParser.StructuredStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.StructuredStatement;
    }
}