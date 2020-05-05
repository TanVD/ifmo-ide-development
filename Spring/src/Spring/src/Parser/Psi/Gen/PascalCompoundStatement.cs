using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalCompoundStatement : PascalAntlrCompositeElement<GPascalParser.CompoundStatementContext>
    {
        public PascalCompoundStatement(GPascalParser.CompoundStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.CompoundStatement;
    }
}