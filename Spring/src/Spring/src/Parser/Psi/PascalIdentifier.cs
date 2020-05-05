using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalIdentifier : PascalAntlrCompositeElement<GPascalParser.IdentifierContext>
    {
        public string Name => Context.IDENT().GetText();

        public PascalIdentifier(GPascalParser.IdentifierContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Identifier;
    }
}