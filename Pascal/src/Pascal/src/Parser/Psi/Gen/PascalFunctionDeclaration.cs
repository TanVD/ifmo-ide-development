using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFunctionDeclaration : PascalAntlrCompositeElement<GPascalParser.FunctionDeclarationContext>
    {
        public PascalFunctionDeclaration(GPascalParser.FunctionDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionDeclaration;
    }
}