using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalStatements : PascalAntlrCompositeElement<GPascalParser.StatementsContext>
    {
        public PascalStatements(GPascalParser.StatementsContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Statements;
    }
}