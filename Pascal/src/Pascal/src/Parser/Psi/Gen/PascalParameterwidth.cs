using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalParameterwidth : PascalAntlrCompositeElement<GPascalParser.ParameterwidthContext>
    {
        public PascalParameterwidth(GPascalParser.ParameterwidthContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Parameterwidth;
    }
}