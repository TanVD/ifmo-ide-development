using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProgram : PascalAntlrCompositeElement<GPascalParser.ProgramContext>
    {
        public PascalProgram(GPascalParser.ProgramContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Program;
    }
}