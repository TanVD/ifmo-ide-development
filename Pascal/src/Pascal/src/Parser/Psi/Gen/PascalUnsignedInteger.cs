using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUnsignedInteger : PascalAntlrCompositeElement<GPascalParser.UnsignedIntegerContext>
    {
        public PascalUnsignedInteger(GPascalParser.UnsignedIntegerContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnsignedInteger;
    }
}