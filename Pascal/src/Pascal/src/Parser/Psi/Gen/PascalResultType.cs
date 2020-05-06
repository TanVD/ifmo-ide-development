using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalResultType : PascalAntlrCompositeElement<GPascalParser.ResultTypeContext>
    {
        public PascalResultType(GPascalParser.ResultTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ResultType;
    }
}