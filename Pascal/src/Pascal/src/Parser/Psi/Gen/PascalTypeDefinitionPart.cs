using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalTypeDefinitionPart : PascalAntlrCompositeElement<GPascalParser.TypeDefinitionPartContext>
    {
        public PascalTypeDefinitionPart(GPascalParser.TypeDefinitionPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeDefinitionPart;
    }
}