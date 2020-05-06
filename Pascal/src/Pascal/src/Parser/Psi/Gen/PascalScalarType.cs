using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalScalarType : PascalAntlrCompositeElement<GPascalParser.ScalarTypeContext>
    {
        public PascalScalarType(GPascalParser.ScalarTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ScalarType;
    }
}