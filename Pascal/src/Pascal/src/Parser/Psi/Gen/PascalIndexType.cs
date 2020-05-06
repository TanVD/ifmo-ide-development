using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalIndexType : PascalAntlrCompositeElement<GPascalParser.IndexTypeContext>
    {
        public PascalIndexType(GPascalParser.IndexTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.IndexType;
    }
}