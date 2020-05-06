using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalProgram : PascalAntlrCompositeElement<GPascalParser.ProgramContext>
    {
        public PascalProgram(GPascalParser.ProgramContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Program;
    }
}