using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFactor : PascalAntlrCompositeElement<GPascalParser.FactorContext>
    {
        public PascalFactor(GPascalParser.FactorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Factor;
    }
}