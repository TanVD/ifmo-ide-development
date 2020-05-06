using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalSubrangeType : PascalAntlrCompositeElement<GPascalParser.SubrangeTypeContext>
    {
        public PascalSubrangeType(GPascalParser.SubrangeTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SubrangeType;
    }
}