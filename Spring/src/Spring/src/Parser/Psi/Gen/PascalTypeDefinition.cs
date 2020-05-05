using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalTypeDefinition : PascalAntlrCompositeElement<GPascalParser.TypeDefinitionContext>
    {
        public PascalTypeDefinition(GPascalParser.TypeDefinitionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeDefinition;
    }
}