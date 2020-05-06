using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProgramHeading : PascalAntlrCompositeElement<GPascalParser.ProgramHeadingContext>
    {
        public PascalProgramHeading(GPascalParser.ProgramHeadingContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProgramHeading;
    }
}