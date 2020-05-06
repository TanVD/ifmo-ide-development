using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalInitialValue : PascalAntlrCompositeElement<GPascalParser.InitialValueContext>
    {
        public PascalInitialValue(GPascalParser.InitialValueContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.InitialValue;
    }
}