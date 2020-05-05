using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalString : PascalAntlrCompositeElement<GPascalParser.StringContext>
    {
        public PascalString(GPascalParser.StringContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.String;
    }
}