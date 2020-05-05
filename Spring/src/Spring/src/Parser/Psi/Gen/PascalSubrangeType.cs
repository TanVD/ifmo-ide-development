using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSubrangeType : PascalAntlrCompositeElement<GPascalParser.SubrangeTypeContext>
    {
        public PascalSubrangeType(GPascalParser.SubrangeTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SubrangeType;
    }
}