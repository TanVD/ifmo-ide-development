using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalTypeDefinition : PascalAntlrCompositeElement<GPascalParser.TypeDefinitionContext>
    {
        public PascalTypeDefinition(GPascalParser.TypeDefinitionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeDefinition;
    }
}