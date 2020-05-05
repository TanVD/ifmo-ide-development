using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalBool : PascalAntlrCompositeElement<GPascalParser.BoolContext>
    {
        public PascalBool(GPascalParser.BoolContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Bool;
    }
}