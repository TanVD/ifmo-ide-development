using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalUnpackedStructuredType : PascalAntlrCompositeElement<GPascalParser.UnpackedStructuredTypeContext>
    {
        public PascalUnpackedStructuredType(GPascalParser.UnpackedStructuredTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnpackedStructuredType;
    }
}