using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFunctionType : PascalAntlrCompositeElement<GPascalParser.FunctionTypeContext>
    {
        public PascalFunctionType(GPascalParser.FunctionTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionType;
    }
}