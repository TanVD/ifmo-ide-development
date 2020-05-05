using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSet : PascalAntlrCompositeElement<GPascalParser.SetContext>
    {
        public PascalSet(GPascalParser.SetContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Set;
    }
}