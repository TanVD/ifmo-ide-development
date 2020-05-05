using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalParameterList : PascalAntlrCompositeElement<GPascalParser.ParameterListContext>
    {
        public PascalParameterList(GPascalParser.ParameterListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ParameterList;
    }
}