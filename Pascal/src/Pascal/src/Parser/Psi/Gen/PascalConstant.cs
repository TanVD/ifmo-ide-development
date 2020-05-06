using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalConstant : PascalAntlrCompositeElement<GPascalParser.ConstantContext>
    {
        public PascalConstant(GPascalParser.ConstantContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Constant;
    }
}