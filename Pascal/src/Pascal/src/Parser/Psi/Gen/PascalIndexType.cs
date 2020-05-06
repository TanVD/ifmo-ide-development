using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalIndexType : PascalAntlrCompositeElement<GPascalParser.IndexTypeContext>
    {
        public PascalIndexType(GPascalParser.IndexTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.IndexType;
    }
}