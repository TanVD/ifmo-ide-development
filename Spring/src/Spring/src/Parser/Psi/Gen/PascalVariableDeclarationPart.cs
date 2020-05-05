using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalVariableDeclarationPart : PascalAntlrCompositeElement<GPascalParser.VariableDeclarationPartContext>
    {
        public PascalVariableDeclarationPart(GPascalParser.VariableDeclarationPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.VariableDeclarationPart;
    }
}