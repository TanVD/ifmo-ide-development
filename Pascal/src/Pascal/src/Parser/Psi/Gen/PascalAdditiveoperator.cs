using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalAdditiveoperator : PascalAntlrCompositeElement<GPascalParser.AdditiveoperatorContext>
    {
        public PascalAdditiveoperator(GPascalParser.AdditiveoperatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Additiveoperator;
    }
}