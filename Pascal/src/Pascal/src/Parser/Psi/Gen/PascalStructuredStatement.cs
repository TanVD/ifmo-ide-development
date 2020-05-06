using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalStructuredStatement : PascalAntlrCompositeElement<GPascalParser.StructuredStatementContext>
    {
        public PascalStructuredStatement(GPascalParser.StructuredStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.StructuredStatement;
    }
}