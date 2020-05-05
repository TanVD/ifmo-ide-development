using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalArrayType : PascalAntlrCompositeElement<GPascalParser.ArrayTypeContext>
    {
        public PascalArrayType(GPascalParser.ArrayTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ArrayType;
    }
}