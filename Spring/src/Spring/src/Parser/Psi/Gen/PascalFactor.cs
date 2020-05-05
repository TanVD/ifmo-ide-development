using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFactor : PascalAntlrCompositeElement<GPascalParser.FactorContext>
    {
        public PascalFactor(GPascalParser.FactorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Factor;
    }
}