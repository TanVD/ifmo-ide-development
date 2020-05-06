using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFunctionDeclaration : PascalAntlrCompositeElement<GPascalParser.FunctionDeclarationContext>
    {
        public PascalFunctionDeclaration(GPascalParser.FunctionDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionDeclaration;
    }
}