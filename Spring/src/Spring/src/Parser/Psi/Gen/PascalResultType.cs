using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalResultType : PascalAntlrCompositeElement<GPascalParser.ResultTypeContext>
    {
        public PascalResultType(GPascalParser.ResultTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ResultType;
    }
}