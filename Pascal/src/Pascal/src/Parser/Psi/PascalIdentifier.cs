using System.Linq;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi
{
    public class PascalIdentifier : PascalAntlrCompositeElement<GPascalParser.IdentifierContext>
    {
        public TreeTextRange IdentifierRange => this.Children().Single(it => it.NodeType == PascalTokenTypes.IDENT).GetTreeTextRange();
        public string Name => Context.IDENT().GetText();

        public PascalIdentifier(GPascalParser.IdentifierContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Identifier;
    }
}