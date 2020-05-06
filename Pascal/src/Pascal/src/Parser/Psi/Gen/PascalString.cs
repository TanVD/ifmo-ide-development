using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalString : PascalAntlrCompositeElement<GPascalParser.StringContext>
    {
        public PascalString(GPascalParser.StringContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.String;
    }
}