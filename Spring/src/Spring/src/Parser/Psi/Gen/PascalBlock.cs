using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalBlock : PascalAntlrCompositeElement<GPascalParser.BlockContext>
    {
        public PascalBlock(GPascalParser.BlockContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Block;
    }
}