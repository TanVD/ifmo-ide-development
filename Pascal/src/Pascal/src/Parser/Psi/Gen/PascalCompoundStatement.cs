using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalCompoundStatement : PascalAntlrCompositeElement<GPascalParser.CompoundStatementContext>
    {
        public PascalCompoundStatement(GPascalParser.CompoundStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.CompoundStatement;
    }
}