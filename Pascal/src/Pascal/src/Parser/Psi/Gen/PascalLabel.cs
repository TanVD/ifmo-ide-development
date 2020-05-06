using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalLabel : PascalAntlrCompositeElement<GPascalParser.LabelContext>
    {
        public PascalLabel(GPascalParser.LabelContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Label;
    }
}