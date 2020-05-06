using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalElement : PascalAntlrCompositeElement<GPascalParser.ElementContext>
    {
        public PascalElement(GPascalParser.ElementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Element;
    }
}