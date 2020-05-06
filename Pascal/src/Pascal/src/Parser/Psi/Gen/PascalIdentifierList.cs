using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalIdentifierList : PascalAntlrCompositeElement<GPascalParser.IdentifierListContext>
    {
        public PascalIdentifierList(GPascalParser.IdentifierListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.IdentifierList;
    }
}