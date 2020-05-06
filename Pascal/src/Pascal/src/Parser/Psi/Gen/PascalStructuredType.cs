using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalStructuredType : PascalAntlrCompositeElement<GPascalParser.StructuredTypeContext>
    {
        public PascalStructuredType(GPascalParser.StructuredTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.StructuredType;
    }
}