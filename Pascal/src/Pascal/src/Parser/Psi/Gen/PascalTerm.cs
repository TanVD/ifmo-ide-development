using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalTerm : PascalAntlrCompositeElement<GPascalParser.TermContext>
    {
        public PascalTerm(GPascalParser.TermContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Term;
    }
}