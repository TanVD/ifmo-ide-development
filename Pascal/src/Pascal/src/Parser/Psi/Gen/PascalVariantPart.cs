using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalVariantPart : PascalAntlrCompositeElement<GPascalParser.VariantPartContext>
    {
        public PascalVariantPart(GPascalParser.VariantPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.VariantPart;
    }
}