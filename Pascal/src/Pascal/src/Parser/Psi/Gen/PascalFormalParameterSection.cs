using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFormalParameterSection : PascalAntlrCompositeElement<GPascalParser.FormalParameterSectionContext>
    {
        public PascalFormalParameterSection(GPascalParser.FormalParameterSectionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FormalParameterSection;
    }
}