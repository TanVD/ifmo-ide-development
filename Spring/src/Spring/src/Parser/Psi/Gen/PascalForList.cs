using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalForList : PascalAntlrCompositeElement<GPascalParser.ForListContext>
    {
        public PascalForList(GPascalParser.ForListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ForList;
    }
}