using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalVariableDeclarationPart : PascalAntlrCompositeElement<GPascalParser.VariableDeclarationPartContext>
    {
        public PascalVariableDeclarationPart(GPascalParser.VariableDeclarationPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.VariableDeclarationPart;
    }
}