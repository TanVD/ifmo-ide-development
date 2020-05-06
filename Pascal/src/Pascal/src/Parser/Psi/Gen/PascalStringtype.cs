using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalStringtype : PascalAntlrCompositeElement<GPascalParser.StringtypeContext>
    {
        public PascalStringtype(GPascalParser.StringtypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Stringtype;
    }
}