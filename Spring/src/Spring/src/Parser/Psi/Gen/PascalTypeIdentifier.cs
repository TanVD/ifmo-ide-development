using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalTypeIdentifier : PascalAntlrCompositeElement<GPascalParser.TypeIdentifierContext>
    {
        public PascalTypeIdentifier(GPascalParser.TypeIdentifierContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeIdentifier;
    }
}