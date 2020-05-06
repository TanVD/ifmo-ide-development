using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalVariant : PascalAntlrCompositeElement<GPascalParser.VariantContext>
    {
        public PascalVariant(GPascalParser.VariantContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Variant;
    }
}