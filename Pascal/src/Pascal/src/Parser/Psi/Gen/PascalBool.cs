using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalBool : PascalAntlrCompositeElement<GPascalParser.BoolContext>
    {
        public PascalBool(GPascalParser.BoolContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Bool;
    }
}