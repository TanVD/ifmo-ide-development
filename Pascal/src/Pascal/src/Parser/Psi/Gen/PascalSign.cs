using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSign : PascalAntlrCompositeElement<GPascalParser.SignContext>
    {
        public PascalSign(GPascalParser.SignContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Sign;
    }
}