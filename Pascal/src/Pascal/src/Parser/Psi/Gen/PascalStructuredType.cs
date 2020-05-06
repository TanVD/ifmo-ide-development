using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalStructuredType : PascalAntlrCompositeElement<GPascalParser.StructuredTypeContext>
    {
        public PascalStructuredType(GPascalParser.StructuredTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.StructuredType;
    }
}