using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalParameterGroup : PascalAntlrCompositeElement<GPascalParser.ParameterGroupContext>
    {
        public PascalParameterGroup(GPascalParser.ParameterGroupContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ParameterGroup;
    }
}