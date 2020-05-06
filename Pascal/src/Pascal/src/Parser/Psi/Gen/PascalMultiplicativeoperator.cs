using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalMultiplicativeoperator : PascalAntlrCompositeElement<GPascalParser.MultiplicativeoperatorContext>
    {
        public PascalMultiplicativeoperator(GPascalParser.MultiplicativeoperatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Multiplicativeoperator;
    }
}