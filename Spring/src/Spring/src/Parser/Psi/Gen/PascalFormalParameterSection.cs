using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFormalParameterSection : PascalAntlrCompositeElement<GPascalParser.FormalParameterSectionContext>
    {
        public PascalFormalParameterSection(GPascalParser.FormalParameterSectionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FormalParameterSection;
    }
}