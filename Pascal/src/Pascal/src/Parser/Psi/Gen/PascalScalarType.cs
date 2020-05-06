using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalScalarType : PascalAntlrCompositeElement<GPascalParser.ScalarTypeContext>
    {
        public PascalScalarType(GPascalParser.ScalarTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ScalarType;
    }
}