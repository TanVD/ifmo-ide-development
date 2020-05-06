using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSimpleStatement : PascalAntlrCompositeElement<GPascalParser.SimpleStatementContext>
    {
        public PascalSimpleStatement(GPascalParser.SimpleStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SimpleStatement;
    }
}