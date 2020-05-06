using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalConstantChr : PascalAntlrCompositeElement<GPascalParser.ConstantChrContext>
    {
        public PascalConstantChr(GPascalParser.ConstantChrContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstantChr;
    }
}