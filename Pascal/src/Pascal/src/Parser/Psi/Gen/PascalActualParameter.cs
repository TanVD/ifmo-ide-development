using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalActualParameter : PascalAntlrCompositeElement<GPascalParser.ActualParameterContext>
    {
        public PascalActualParameter(GPascalParser.ActualParameterContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ActualParameter;
    }
}