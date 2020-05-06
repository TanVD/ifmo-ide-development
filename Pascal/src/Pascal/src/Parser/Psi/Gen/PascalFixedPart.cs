using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFixedPart : PascalAntlrCompositeElement<GPascalParser.FixedPartContext>
    {
        public PascalFixedPart(GPascalParser.FixedPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FixedPart;
    }
}