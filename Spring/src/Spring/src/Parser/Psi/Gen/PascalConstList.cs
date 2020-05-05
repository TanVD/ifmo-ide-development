using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalConstList : PascalAntlrCompositeElement<GPascalParser.ConstListContext>
    {
        public PascalConstList(GPascalParser.ConstListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstList;
    }
}