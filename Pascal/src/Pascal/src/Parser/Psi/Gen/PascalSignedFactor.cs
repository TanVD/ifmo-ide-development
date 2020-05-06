using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalSignedFactor : PascalAntlrCompositeElement<GPascalParser.SignedFactorContext>
    {
        public PascalSignedFactor(GPascalParser.SignedFactorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SignedFactor;
    }
}