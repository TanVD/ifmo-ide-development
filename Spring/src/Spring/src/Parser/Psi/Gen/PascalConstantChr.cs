using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalConstantChr : PascalAntlrCompositeElement<GPascalParser.ConstantChrContext>
    {
        public PascalConstantChr(GPascalParser.ConstantChrContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstantChr;
    }
}