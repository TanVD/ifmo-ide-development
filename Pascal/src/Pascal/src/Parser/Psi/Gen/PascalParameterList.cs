using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalParameterList : PascalAntlrCompositeElement<GPascalParser.ParameterListContext>
    {
        public PascalParameterList(GPascalParser.ParameterListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ParameterList;
    }
}