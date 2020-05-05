using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalTypeList : PascalAntlrCompositeElement<GPascalParser.TypeListContext>
    {
        public PascalTypeList(GPascalParser.TypeListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeList;
    }
}