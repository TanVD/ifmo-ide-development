using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalElementList : PascalAntlrCompositeElement<GPascalParser.ElementListContext>
    {
        public PascalElementList(GPascalParser.ElementListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ElementList;
    }
}