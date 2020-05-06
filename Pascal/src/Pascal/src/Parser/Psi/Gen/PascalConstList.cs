using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalConstList : PascalAntlrCompositeElement<GPascalParser.ConstListContext>
    {
        public PascalConstList(GPascalParser.ConstListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstList;
    }
}