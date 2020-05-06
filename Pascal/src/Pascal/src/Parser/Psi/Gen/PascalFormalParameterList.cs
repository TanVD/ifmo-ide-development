using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFormalParameterList : PascalAntlrCompositeElement<GPascalParser.FormalParameterListContext>
    {
        public PascalFormalParameterList(GPascalParser.FormalParameterListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FormalParameterList;
    }
}