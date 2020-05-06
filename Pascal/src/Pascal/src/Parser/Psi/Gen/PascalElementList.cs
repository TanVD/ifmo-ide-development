using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalElementList : PascalAntlrCompositeElement<GPascalParser.ElementListContext>
    {
        public PascalElementList(GPascalParser.ElementListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ElementList;
    }
}