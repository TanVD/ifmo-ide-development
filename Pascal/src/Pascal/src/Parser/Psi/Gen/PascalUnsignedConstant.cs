using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUnsignedConstant : PascalAntlrCompositeElement<GPascalParser.UnsignedConstantContext>
    {
        public PascalUnsignedConstant(GPascalParser.UnsignedConstantContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnsignedConstant;
    }
}