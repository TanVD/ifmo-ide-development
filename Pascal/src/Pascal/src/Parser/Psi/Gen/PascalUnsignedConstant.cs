using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalUnsignedConstant : PascalAntlrCompositeElement<GPascalParser.UnsignedConstantContext>
    {
        public PascalUnsignedConstant(GPascalParser.UnsignedConstantContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnsignedConstant;
    }
}