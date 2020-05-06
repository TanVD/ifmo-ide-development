using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUnpackedStructuredType : PascalAntlrCompositeElement<GPascalParser.UnpackedStructuredTypeContext>
    {
        public PascalUnpackedStructuredType(GPascalParser.UnpackedStructuredTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UnpackedStructuredType;
    }
}