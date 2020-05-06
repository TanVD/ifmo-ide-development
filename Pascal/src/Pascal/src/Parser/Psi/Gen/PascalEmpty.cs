using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalEmpty : PascalAntlrCompositeElement<GPascalParser.EmptyContext>
    {
        public PascalEmpty(GPascalParser.EmptyContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Empty;
    }
}