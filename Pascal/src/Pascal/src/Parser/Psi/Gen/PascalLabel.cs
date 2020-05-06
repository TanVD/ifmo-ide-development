using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalLabel : PascalAntlrCompositeElement<GPascalParser.LabelContext>
    {
        public PascalLabel(GPascalParser.LabelContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Label;
    }
}