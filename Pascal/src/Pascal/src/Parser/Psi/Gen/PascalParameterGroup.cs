using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalParameterGroup : PascalAntlrCompositeElement<GPascalParser.ParameterGroupContext>
    {
        public PascalParameterGroup(GPascalParser.ParameterGroupContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ParameterGroup;
    }
}