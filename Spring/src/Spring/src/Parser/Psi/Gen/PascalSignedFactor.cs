using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSignedFactor : PascalAntlrCompositeElement<GPascalParser.SignedFactorContext>
    {
        public PascalSignedFactor(GPascalParser.SignedFactorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SignedFactor;
    }
}