using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUnsignedNumber : PascalAntlrCompositeElement<GPascalParser.UnsignedNumberContext>
    {
        public PascalUnsignedNumber(GPascalParser.UnsignedNumberContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnsignedNumber;
    }
}