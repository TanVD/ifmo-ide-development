using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalPointerType : PascalAntlrCompositeElement<GPascalParser.PointerTypeContext>
    {
        public PascalPointerType(GPascalParser.PointerTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.PointerType;
    }
}