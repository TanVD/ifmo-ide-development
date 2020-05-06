using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFunctionType : PascalAntlrCompositeElement<GPascalParser.FunctionTypeContext>
    {
        public PascalFunctionType(GPascalParser.FunctionTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionType;
    }
}