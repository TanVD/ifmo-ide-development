using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalRepeatStatement : PascalAntlrCompositeElement<GPascalParser.RepeatStatementContext>
    {
        public PascalRepeatStatement(GPascalParser.RepeatStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RepeatStatement;
    }
}