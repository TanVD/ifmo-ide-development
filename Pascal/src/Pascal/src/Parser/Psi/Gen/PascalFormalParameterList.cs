using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFormalParameterList : PascalAntlrCompositeElement<GPascalParser.FormalParameterListContext>
    {
        public PascalFormalParameterList(GPascalParser.FormalParameterListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FormalParameterList;
    }
}