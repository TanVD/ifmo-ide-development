using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalTag : PascalAntlrCompositeElement<GPascalParser.TagContext>
    {
        public PascalTag(GPascalParser.TagContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Tag;
    }
}